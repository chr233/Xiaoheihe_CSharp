using System.Threading;
using Xiaoheihe_Core;
using Xiaoheihe_Core.APIs;
using Xiaoheihe_Core.Data;
using Xiaoheihe_Core.Exceptions;
using Xiaoheihe_CShape.Data;
using Xiaoheihe_CShape.Storage;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormDailyTask : Form
    {
        private static Config Myconfig => Utils.GlobalConfig;
        private static HashSet<string> ChecledItems => Myconfig.CheckedItems.ToHashSet();
        private static Dictionary<string, Account> AccountsDict => Utils.AccountsDict;
        private static Dictionary<string, KeyValuePair<Account, DailyTaskData>> DailyTaskDict { get; } = new();

        public FormDailyTask()
        {
            InitializeComponent();
        }

        private void FormDailyTask_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;

            foreach (Account account in AccountsDict.Values)
            {
                DailyTaskDict[account.HeyboxID] = new(account, new());
            }

            updThreadCount.Value = Myconfig.DailyTaskThread;
            updTaskDelay.Value = Myconfig.DailyTaskDelay;

            InitAccountList();
        }

        private void FormDailyTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            Myconfig.DailyTaskThread = (uint)updThreadCount.Value;
            Myconfig.DailyTaskDelay = (uint)updTaskDelay.Value;

            List<string> checkedItems = new();
            foreach (ListViewItem item in lVAccounts.CheckedItems)
            {
                checkedItems.Add(item.SubItems[1].Text);
            }

            Myconfig.CheckedItems = checkedItems;
            Utils.SaveConfig();
        }


        private void UpdateAccountListAsync()
        {
            lVAccounts.Invoke(UpdateAccountList);
        }

        private void InitAccountList()
        {
            lVAccounts.BeginUpdate();
            lVAccounts.Items.Clear();

            uint count = 1;
            foreach (var pair in DailyTaskDict.Values)
            {
                Account account = pair.Key;
                DailyTaskData data = pair.Value;

                ListViewItem item = new("")
                {
                    Text = count++.ToString(),
                    SubItems =
                    {
                        account.HeyboxID,
                        account.NickName,
                        account.Level,
                        account.Experience,
                        data.Tasks,
                        data.Status
                    },
                    Checked = ChecledItems.Contains(account.HeyboxID)
                };
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
                    var pair = DailyTaskDict[userID];

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

        private void TSMAll_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = true;
            }
            lVAccounts.EndUpdate();
        }

        private void TSMNone_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = false;
            }
            lVAccounts.EndUpdate();
        }

        private void TSMNot_Click(object sender, EventArgs e)
        {
            var items = lVAccounts.Items;
            lVAccounts.BeginUpdate();
            foreach (ListViewItem item in items)
            {
                item.Checked = !item.Checked;
            }
            lVAccounts.EndUpdate();
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        private void BtnStartTask_Click(object sender, EventArgs e)
        {
            int delay = (int)updTaskDelay.Value;
            int thread = (int)updThreadCount.Value;

            Myconfig.DailyTaskDelay = (uint)delay;
            Myconfig.DailyTaskThread = (uint)thread;
            Utils.SaveConfig();

            var checkedItems = lVAccounts.CheckedItems;

            HashSet<KeyValuePair<Account, DailyTaskData>> selectedAccounts = new();

            foreach (ListViewItem item in checkedItems)
            {
                string heyboxID = item.SubItems[1].Text;
                if (AccountsDict.ContainsKey(heyboxID))
                {
                    selectedAccounts.Add(DailyTaskDict[heyboxID]);
                }
            }

            if (selectedAccounts.Count > 0)
            {
                btnStartTask.Enabled = false;
                updTaskDelay.Enabled = false;
                updThreadCount.Enabled = false;
                lblStatus.Text = "执行中";

                Task.Run(() => StartTask(selectedAccounts, thread, delay));
            }
            else
            {
                MessageBox.Show("尚未勾选任何账号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task StartTask(HashSet<KeyValuePair<Account, DailyTaskData>> accounts, int threadCount, int delay)
        {
            SemaphoreSlim semaphore = new(threadCount);

            Task[] tasks = new Task[accounts.Count];

            int i = 0;

            foreach (var pair in accounts)
            {
                tasks[i++] = Task.Run(async () => {
                    Account account = pair.Key;
                    DailyTaskData data = pair.Value;
                    data.Tasks = "待更新";
                    data.Status = "等待执行";

                    try
                    {
                        await DoDailyTask(account, data, semaphore, delay);
                    }
                    catch (Exception ex)
                    {
                        data.Status = ex.Message;
                    }
                });
            }

            if (tasks.Length > 0)
            {
                await Task.WhenAll(tasks).ConfigureAwait(false);
            }

            Invoke(() => {
                btnStartTask.Enabled = true;
                updTaskDelay.Enabled = true;
                updThreadCount.Enabled = true;

                lblStatus.Text = "未运行";
                Utils.SaveConfig();
            });
        }

        private async Task DoDailyTask(Account account, DailyTaskData data, SemaphoreSlim semaphore, int delay)
        {
            await semaphore.WaitAsync();

            XiaoheiheClient xhh = new(account, Myconfig.XhhVersion, Myconfig.HkeyServer);

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
                LevelInfoData levelInfo = taskListResponse.Result.LevelInfo;

                account.NickName = userData.UserName;
                account.Level = userData.LevelInfo.Level.ToString();
                account.Experience = $"{levelInfo.Exp}/{levelInfo.MaxExp}";

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

                            await Task.Delay(delay);

                            if (!share2)
                            {
                                data.Status = "分享评论任务";
                                UpdateAccountListAsync();
                                await xhh.ShareComment().ConfigureAwait(false);
                                share2 = true;
                            }

                            await Task.Delay(delay);

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

                                await Task.Delay(delay);
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
    }
}
