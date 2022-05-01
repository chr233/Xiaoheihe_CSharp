using Xiaoheihe_Core;
using Xiaoheihe_Core.APIs;
using Xiaoheihe_Core.Data;


namespace Xiaoheihe_CShape.Forms
{
    public partial class FormDailyTask : Form
    {
        private static HashSet<string> ChecledItems => Utils.GlobalConfig.CheckedItems;
        private static uint DailyTaskThread => Utils.GlobalConfig.DailyTaskThread;
        private static uint DailyTaskDelay => Utils.GlobalConfig.DailyTaskDelay;
        private static string HkeyServer => Utils.GlobalConfig.HkeyServer;
        private static string XhhVersion => Utils.GlobalConfig.XhhVersion;

        private readonly Dictionary<string, Account> AccountsDict = new();

        public FormDailyTask()
        {
            InitializeComponent();

            foreach (Account account in Utils.GlobalConfig.Accounts)
            {
                AccountsDict[account.HeyboxID] = account;
            }

            UpdateAccountList();

            tSTxtThread.Text = DailyTaskThread.ToString();
            tSTxtDelay.Text = DailyTaskDelay.ToString();
        }

        private void TSBtnStartTask_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(tSTxtThread.Text, out uint thread) && thread > 0)
            {
                if (uint.TryParse(tSTxtDelay.Text, out uint delay))
                {
                    Utils.GlobalConfig.DailyTaskThread = thread;
                    Utils.GlobalConfig.DailyTaskDelay = delay;
                    Utils.SaveConfig();

                    if (lVAccounts.CheckedItems.Count > 0)
                    {
                        tSBtnStartTask.Enabled = false;
                        tSLblStatus.Text = "状态: 执行中";

                        Task.Run(StartTask);
                    }
                    else
                    {
                        MessageBox.Show("尚未勾选任何账号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("延迟时间非法", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tSTxtDelay.SelectAll();
                    tSTxtDelay.Focus();
                }
            }
            else
            {
                MessageBox.Show("线程数非法, 线程数必须 > 0", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tSTxtThread.SelectAll();
                tSTxtThread.Focus();
            }
        }

        private async Task StartTask()
        {
            HashSet<Account> selectedAccounts = new();
            foreach (string heyboxID in lVAccounts.CheckedItems)
            {
                if (AccountsDict.ContainsKey(heyboxID))
                {
                    selectedAccounts.Add(AccountsDict[heyboxID]);
                }
            }

            SemaphoreSlim semaphore = new((int)DailyTaskThread);

            Task[] tasks = new Task[selectedAccounts.Count];

            int i = 0;

            foreach (Account account in selectedAccounts)
            {
                tasks[i++] = Task.Run(async () => {
                    account.Tasks = "待更新";
                    account.Status = "等待执行";
                    await DoDailyTask(account, semaphore);

                });
            }

            if (tasks.Length > 0)
            {
                await Task.WhenAll(tasks).ConfigureAwait(false);
            }

            Invoke(() => {
                tSBtnStartTask.Enabled = true;
                tSLblStatus.Text = "状态: 结束";
                Utils.SaveConfig();
            });
        }

        private async Task DoDailyTask(Account account, SemaphoreSlim semaphore)
        {
            await semaphore.WaitAsync();

            XiaoheiheClient xhh = new(account, XhhVersion, HkeyServer);

            account.Status = "开始执行";
            UpdateAccountListAsync();

            bool sign = false, share1 = false, share2 = false, like = false;

            async Task CheckTask()
            {
                TaskListResponse taskList = await xhh.GetTaskList();

                if (taskList == null || taskList.Result == null)
                {
                    account.Status = "读取任务出错 响应为空";
                    return;
                }

                HashSet<TaskWithTitleData>? taskGroups = taskList.Result.TaskList;

                foreach (TaskWithTitleData? taskWithTitle in taskGroups)
                {
                    if (taskWithTitle != null)
                    {
                        foreach (TaskDetailData? task in taskWithTitle.Tasks)
                        {
                            switch (task.Type)
                            {
                                case "sign":
                                    sign = task.State == "finish";
                                    break;
                                case "goto_tab":
                                    if (task.Title.Contains("分享"))
                                    {
                                        if (!task.Title.Contains("评论"))
                                        {
                                            share1 = task.State == "finish";
                                        }
                                        else
                                        {
                                            share2 = task.State == "finish";
                                        }
                                    }
                                    else
                                    {
                                        like = task.State == "finish";
                                    }
                                    break;
                            }
                        }
                    }
                }

                account.Tasks = $"签到{Utils.B2S(sign)}分享{Utils.B2S(share1)}|{Utils.B2S(share2)}点赞{Utils.B2S(like)}";
                account.Status = "读取任务状态";
                UpdateAccountListAsync();
            }

            try
            {
                TaskListResponse taskListResponse = await xhh.GetTaskList();

                if (taskListResponse == null || taskListResponse.Result == null)
                {
                    account.Status = "读取任务出错 响应为空";
                    return;
                }

                await CheckTask().ConfigureAwait(false);

                if (!sign)
                {
                    account.Status = "签到任务";
                    UpdateAccountListAsync();

                    await xhh.TaskSign();
                }

                if (!share1 || !share2 || !like)
                {
                    account.Status = "读取新闻列表";
                    UpdateAccountListAsync();

                    AppFeedNewsResponse appFeedNews = await xhh.GetFeedNews(0);
                    if (appFeedNews == null || appFeedNews.Result == null)
                    {
                        account.Status = "读取新闻列表 响应为空";
                        return;
                    }

                    HashSet<NewsLinkData>? newsLinks = appFeedNews.Result.Links;

                    int index = 0;
                    int likes = 0;
                    int likesMax = 6;
                    foreach (NewsLinkData news in newsLinks)
                    {
                        index++;

                        if (news.ContentType == 1)
                        {
                            if (!share1)
                            {
                                account.Status = "分享新闻任务";
                                UpdateAccountListAsync();
                                await xhh.ShareNews(news.LinkID, index).ConfigureAwait(false);
                                share1 = true;
                            }

                            await Task.Delay((int)DailyTaskDelay);

                            if (!share2)
                            {
                                account.Status = "分享评论任务";
                                UpdateAccountListAsync();
                                await xhh.ShareComment().ConfigureAwait(false);
                                share2 = true;
                            }

                            await Task.Delay((int)DailyTaskDelay);

                            if (likes < likesMax)
                            {
                                account.Status = $"点赞文章任务 {likes++}/{likesMax}";
                                UpdateAccountListAsync();
                                await xhh.LikeNews(news.LinkID, index);
                                await Task.Delay((int)DailyTaskDelay);
                            }
                        }

                        if (likes >= likesMax && share1 && share2)
                        {
                            break;
                        }
                    }
                    await CheckTask().ConfigureAwait(false);
                }
                account.Status = "更新账号信息";
                UpdateAccountListAsync();

                AccountInfoResponse accountInfo = await xhh.GetAccountInfo().ConfigureAwait(false);

                if (accountInfo != null && accountInfo.Result != null)
                {
                    HeyboxUserData userData = accountInfo.Result.AccountDetail;
                    account.NickName = userData.UserName;
                    account.Level = userData.LevelInfo.Level.ToString();
                }

                account.Status = (sign && share1 && share2 && like) ? "每日任务全部完成" : "每日任务未全部完成";
                UpdateAccountListAsync();
            }
            finally
            {
                semaphore.Release();
            }
        }

        private void UpdateAccountListAsync()
        {
            lVAccounts.Invoke(UpdateAccountList);
        }


        private void UpdateAccountList()
        {
            lVAccounts.BeginUpdate();
            lVAccounts.Items.Clear();

            foreach (Account account in AccountsDict.Values)
            {
                ListViewItem item = new("");

                item.SubItems.Add(account.HeyboxID);
                item.SubItems.Add(account.NickName);
                item.SubItems.Add(account.Level ?? "0");
                item.SubItems.Add(account.Tasks);
                item.SubItems.Add(account.Status);

                item.Checked = ChecledItems.Contains(account.HeyboxID);

                lVAccounts.Items.Add(item);
            }

            lVAccounts.EndUpdate();
        }

        private void TSBtnAll_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = true;
            }
            lVAccounts.EndUpdate();
        }

        private void TSBtnNone_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = false;
            }
            lVAccounts.EndUpdate();
        }

        private void TSBtnNot_Click(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = !item.Checked;
            }
            lVAccounts.EndUpdate();
        }
    }

}
