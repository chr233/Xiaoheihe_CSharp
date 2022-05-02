using Xiaoheihe_Core;
using Xiaoheihe_Core.APIs;
using Xiaoheihe_Core.Data;
using Xiaoheihe_Core.Exceptions;
using Xiaoheihe_CShape.Data;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormDailyTask : Form
    {
        private static HashSet<string> ChecledItems => Utils.GlobalConfig.CheckedItems;
        private static uint DailyTaskThread => Utils.GlobalConfig.DailyTaskThread;
        private static uint DailyTaskDelay => Utils.GlobalConfig.DailyTaskDelay;
        private static string HkeyServer => Utils.GlobalConfig.HkeyServer;
        private static string XhhVersion => Utils.GlobalConfig.XhhVersion;

        private readonly Dictionary<string, KeyValuePair<Account, DailyTaskData>> AccountsDict = new();

        public FormDailyTask()
        {
            InitializeComponent();

            foreach (Account account in Utils.GlobalConfig.Accounts)
            {
                AccountsDict[account.HeyboxID] = new(account, new DailyTaskData());
            }

            tSTxtThread.Text = DailyTaskThread.ToString();
            tSTxtDelay.Text = DailyTaskDelay.ToString();

            Icon = Properties.Resources.icon;

            InitAccountList();
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

                    ListView.CheckedListViewItemCollection checkedItems = lVAccounts.CheckedItems;

                    HashSet<KeyValuePair<Account, DailyTaskData>> selectedAccounts = new();

                    foreach (ListViewItem item in checkedItems)
                    {
                        string heyboxID = item.SubItems[1].Text;
                        if (AccountsDict.ContainsKey(heyboxID))
                        {
                            selectedAccounts.Add(AccountsDict[heyboxID]);
                        }
                    }

                    if (selectedAccounts.Count > 0)
                    {
                        tSBtnStartTask.Enabled = false;
                        tSTxtDelay.Enabled = false;
                        tSTxtThread.Enabled = false;
                        tSLblStatus.Text = "状态: 执行中";


                        Task.Run(() => StartTask(selectedAccounts));
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

        private async Task StartTask(HashSet<KeyValuePair<Account, DailyTaskData>> accounts)
        {
            SemaphoreSlim semaphore = new((int)DailyTaskThread);

            Task[] tasks = new Task[accounts.Count];

            int i = 0;

            foreach (KeyValuePair<Account, DailyTaskData> pair in accounts)
            {
                tasks[i++] = Task.Run(async () => {
                    Account account = pair.Key;
                    DailyTaskData data = pair.Value;
                    data.Tasks = "待更新";
                    data.Status = "等待执行";
                    await DoDailyTask(account, data, semaphore);

                });
            }

            if (tasks.Length > 0)
            {
                await Task.WhenAll(tasks).ConfigureAwait(false);
            }

            Invoke(() => {
                tSBtnStartTask.Enabled = true;
                tSTxtDelay.Enabled = true;
                tSTxtThread.Enabled = true;
                tSLblStatus.Text = "状态: 结束";
                Utils.SaveConfig();
            });
        }

        private async Task DoDailyTask(Account account, DailyTaskData data, SemaphoreSlim semaphore)
        {
            await semaphore.WaitAsync();

            XiaoheiheClient xhh = new(account, XhhVersion, HkeyServer);

            data.Status = "开始执行";
            UpdateAccountListAsync();

            bool sign = false, share1 = false, share2 = false, like = false;

            async Task CheckTask()
            {
                TaskListResponse taskListResponse = await xhh.GetTaskList();

                if (taskListResponse == null || taskListResponse.Result == null)
                {
                    data.Status = "读取任务出错 响应为空";
                    return;
                }

                HeyboxUserData userData = taskListResponse.Result.User;

                account.NickName = userData.UserName;
                account.Level = userData.LevelInfo.Level.ToString();
                account.Experience = $"{userData.LevelInfo.Exp}/{userData.LevelInfo.MaxExp}";

                HashSet<TaskWithTitleData> taskGroups = taskListResponse.Result.TaskList;

                foreach (TaskWithTitleData taskWithTitle in taskGroups)
                {
                    if (taskWithTitle != null && taskWithTitle.Title == "每日任务")
                    {
                        foreach (TaskDetailData task in taskWithTitle.Tasks)
                        {
                            if (task.Type == "sign")
                            {
                                sign = task.State == "finish";
                            }
                            else if (task.Title.StartsWith("分享"))
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
                        }
                    }
                }

                data.Tasks = $"签到{Utils.B2S(sign)}分享{Utils.B2S(share1)}|{Utils.B2S(share2)}点赞{Utils.B2S(like)}";
                data.Status = "读取任务状态";
                UpdateAccountListAsync();
            }

            try
            {
                TaskListResponse taskListResponse = await xhh.GetTaskList();

                if (taskListResponse == null || taskListResponse.Result == null)
                {
                    data.Status = "读取任务出错 响应为空";
                    return;
                }

                await CheckTask().ConfigureAwait(false);

                if (!sign)
                {
                    data.Status = "签到任务";
                    UpdateAccountListAsync();

                    await xhh.TaskSign();
                }

                if (!share1 || !share2 || !like)
                {
                    data.Status = "读取新闻列表";
                    UpdateAccountListAsync();

                    AppFeedNewsResponse appFeedNews = await xhh.GetFeedNews(0);
                    if (appFeedNews == null || appFeedNews.Result == null)
                    {
                        data.Status = "读取新闻列表 响应为空";
                        return;
                    }

                    HashSet<NewsLinkData>? newsLinks = appFeedNews.Result.Links;

                    int index = 0;
                    int likes = 0;
                    int likesMax = 5;
                    foreach (NewsLinkData news in newsLinks)
                    {
                        index++;

                        if (news.ContentType == 1)
                        {
                            if (!share1)
                            {
                                data.Status = "分享新闻任务";
                                UpdateAccountListAsync();
                                await xhh.ShareNews(news.LinkID, index).ConfigureAwait(false);
                                share1 = true;
                            }

                            await Task.Delay((int)DailyTaskDelay);

                            if (!share2)
                            {
                                data.Status = "分享评论任务";
                                UpdateAccountListAsync();
                                await xhh.ShareComment().ConfigureAwait(false);
                                share2 = true;
                            }

                            await Task.Delay((int)DailyTaskDelay);

                            if (likes <= likesMax)
                            {
                                data.Status = $"点赞文章任务 {likes}/{likesMax}";
                                UpdateAccountListAsync();
                                BasicResponse result = await xhh.LikeNews(news.LinkID, index);

                                if (result != null)
                                {
                                    if (result.Status == "ok")
                                    {
                                        likes++;
                                    }
                                    else
                                    {
                                        data.Status = result.Message;
                                    }
                                }

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

                data.Status = (sign && share1 && share2 && like) ? "每日任务全部完成" : "每日任务未全部完成";
                UpdateAccountListAsync();
            }
            catch (XhhCSBaseException ex)
            {
                data.Status = ex.Message;
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

        private void InitAccountList()
        {
            lVAccounts.BeginUpdate();
            lVAccounts.Items.Clear();

            foreach (KeyValuePair<Account, DailyTaskData> pair in AccountsDict.Values)
            {
                ListViewItem item = new("");

                Account account = pair.Key;
                DailyTaskData data = pair.Value;

                item.SubItems.Add(account.HeyboxID);
                item.SubItems.Add(account.NickName);
                item.SubItems.Add(account.Level);
                item.SubItems.Add(account.Experience);
                item.SubItems.Add(data.Tasks);
                item.SubItems.Add(data.Status);

                item.Checked = ChecledItems.Contains(account.HeyboxID);

                lVAccounts.Items.Add(item);
            }

            lVAccounts.EndUpdate();
        }

        private void UpdateAccountList()
        {
            lVAccounts.BeginUpdate();

            foreach (ListViewItem item in lVAccounts.Items)
            {
                string userID = item.SubItems[1].Text;

                if (AccountsDict.ContainsKey(userID))
                {
                    KeyValuePair<Account, DailyTaskData> pair = AccountsDict[userID];

                    Account account = pair.Key;
                    DailyTaskData data = pair.Value;

                    item.SubItems[2].Text = account.NickName;
                    item.SubItems[3].Text = account.Level;
                    item.SubItems[4].Text = account.Experience;
                    item.SubItems[5].Text = data.Tasks;
                    item.SubItems[6].Text = data.Status;
                }
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
