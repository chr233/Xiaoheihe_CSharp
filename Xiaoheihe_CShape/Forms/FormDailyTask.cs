using System.Net;
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
        private static Config MyConfig => Utils.GlobalConfig;
        private static HashSet<string> ChecledItems => MyConfig.CheckedItems.ToHashSet();
        private static Dictionary<string, Account> AccountsDict => Utils.AccountsDict;
        private static Dictionary<string, KeyValuePair<Account, DailyTaskData>> DailyTaskDict { get; } = new();

        private int NextProxyIndex = -1;

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

            updThreadCount.Value = MyConfig.DailyTaskThread;
            updTaskDelay.Value = MyConfig.DailyTaskDelay;

            bool proxyAvilable = MyConfig.Proxies.Count > 0;
            chkUseProxy.Enabled = proxyAvilable;
            chkUseProxy.Checked = MyConfig.UseProxy && proxyAvilable;

            if (proxyAvilable)
            {
                gbProxy.Text = $"代理设置 可用 {MyConfig.Proxies.Count} 条";
            }
            else
            {
                gbProxy.Text = "代理设置 (无可用代理)";
            }

            InitAccountList();
        }

        private void FormDailyTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyConfig.DailyTaskThread = (uint)updThreadCount.Value;
            MyConfig.DailyTaskDelay = (uint)updTaskDelay.Value;

            List<string> checkedItems = new();
            foreach (ListViewItem item in lVAccounts.CheckedItems)
            {
                checkedItems.Add(item.SubItems[1].Text);
            }

            MyConfig.CheckedItems = checkedItems;
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

            MyConfig.DailyTaskDelay = (uint)delay;
            MyConfig.DailyTaskThread = (uint)thread;
            MyConfig.UseProxy = chkUseProxy.Checked;

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
                bool useProxy = MyConfig.Proxies.Count > 0 && chkUseProxy.Checked;

                NextProxyIndex = useProxy ? 0 : -1;

                chkUseProxy.Enabled = false;
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
                chkUseProxy.Enabled = MyConfig.Proxies.Count > 0;
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

            WebProxy? proxy = null;

            if (NextProxyIndex != -1)
            {
                int i = 3;
                while (i-- > 0)
                {
                    if (NextProxyIndex >= MyConfig.Proxies.Count)
                    {
                        NextProxyIndex = 0;
                    }
                    string uri = MyConfig.Proxies[NextProxyIndex++].ToLower();

                    if (!uri.StartsWith("http://"))
                    {
                        uri = "http://" + uri;
                    }

                    try
                    {
                        proxy = new WebProxy(new Uri(uri))
                        {
                            BypassProxyOnLocal = true
                        };

                        XiaoheiheClient testXhh = new(account, MyConfig.XhhVersion, MyConfig.HkeyServer, proxy);

                        var result = await testXhh.GetTaskList();
                        if (result.Status == "ok")
                        {
                            break;
                        }
                    }
                    catch
                    {
                        PrintLog(account.HeyboxID, data, "代理配置有误");
                    }
                }

                if (proxy == null)
                {
                    PrintLog(account.HeyboxID, data, "找不到可用代理, 使用直连模式");
                }
            }

            XiaoheiheClient xhh = new(account, MyConfig.XhhVersion, MyConfig.HkeyServer);


            if (xhh == null)
            {
                return;
            }

            PrintLog(xhh.HeyboxID, data, "开始执行任务");
            UpdateAccountListAsync();

            bool sign = false, share1 = false, share2 = false, share3 = false;

            async Task CheckTask()
            {
                TaskListResponse taskListResponse = await xhh.GetTaskList();

                if (taskListResponse == null || taskListResponse.Result == null)
                {
                    PrintLog(xhh.HeyboxID, data, "读取任务出错 响应为空");
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
                                if (task.Title.Contains("头条"))
                                {
                                    share1 = task.State == "finish";
                                }
                                else if (task.Title.Contains("评论"))
                                {
                                    share2 = task.State == "finish";
                                }
                                else
                                {
                                    share3 = task.State == "finish";
                                }
                            }
                        }
                    }
                }

                data.Tasks = $"签到{Utils.B2S(sign)}分享{Utils.B2S(share1)}{Utils.B2S(share2)}{Utils.B2S(share3)}";
                PrintLog(xhh.HeyboxID, data, "读取任务状态");
                UpdateAccountListAsync();
            }

            try
            {
                TaskListResponse taskListResponse = await xhh.GetTaskList();

                if (taskListResponse == null || taskListResponse.Result == null)
                {
                    PrintLog(xhh.HeyboxID, data, "读取任务出错 响应为空");
                    return;
                }

                await CheckTask().ConfigureAwait(false);

                if (!sign)
                {
                    PrintLog(xhh.HeyboxID, data, "签到任务");
                    UpdateAccountListAsync();

                    await xhh.TaskSign();
                }

                if (!share1 || !share2 || !share3)
                {
                    PrintLog(xhh.HeyboxID, data, "读取新闻列表");
                    UpdateAccountListAsync();

                    AppFeedNewsResponse appFeedNews = await xhh.GetFeedNews(0);
                    if (appFeedNews == null || appFeedNews.Result == null)
                    {
                        PrintLog(xhh.HeyboxID, data, "读取新闻列表 响应为空");
                        return;
                    }

                    HashSet<NewsLinkData>? newsLinks = appFeedNews.Result.Links;

                    int index = 0;
                    foreach (NewsLinkData news in newsLinks)
                    {
                        index++;

                        if (news.ContentType == 1)
                        {
                            if (!share1)
                            {
                                PrintLog(xhh.HeyboxID, data, "分享新闻任务");
                                UpdateAccountListAsync();
                                await xhh.ShareNews(news.LinkID, index).ConfigureAwait(false);
                                share1 = true;
                            }

                            await Task.Delay(delay);

                            if (!share2)
                            {
                                PrintLog(xhh.HeyboxID, data, "分享评论任务");
                                UpdateAccountListAsync();
                                await xhh.ShareComment().ConfigureAwait(false);
                                share2 = true;
                            }

                            await Task.Delay(delay);

                            if (!share3)
                            {
                                PrintLog(xhh.HeyboxID, data, "分享游戏任务");
                                UpdateAccountListAsync();
                                await xhh.ShareGame().ConfigureAwait(false);
                                share2 = true;
                            }

                            await Task.Delay(delay);
                        }

                        if (share1 && share2 && share3)
                        {
                            break;
                        }
                    }
                    await CheckTask().ConfigureAwait(false);
                }
                PrintLog(xhh.HeyboxID, data, (sign && share1 && share2 && share3) ? "每日任务全部完成" : "每日任务未全部完成");
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

        private void PrintLog(uint heyboxId, DailyTaskData data, string msg)
        {
            PrintLog(heyboxId.ToString(), data, msg);
        }

        private void PrintLog(string heyboxId, DailyTaskData data, string msg)
        {
            Invoke(() => {
                data.Status = msg;
                lstLog.Items.Add($"[{DateTime.Now:T}] {heyboxId} {msg}");
                lstLog.TopIndex = lstLog.Items.Count - 1;
            });
        }
    }
}
