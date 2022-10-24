using Xiaoheihe_Core;
using Xiaoheihe_Core.APIs;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_CShape.Forms
{
    public partial class FormAccountInfo : Form
    {
        private static string HkeyServer => Utils.GlobalConfig.HkeyServer;
        private static string XhhVersion => Utils.GlobalConfig.XhhVersion;

        private uint UserID { get; }

        public FormAccountInfo(uint userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void FormAccountInfo_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            Task.Run(() => LoadUserInfo(UserID));
        }

        private async Task LoadUserInfo(uint userID)
        {
            XiaoheiheClient xhh = new(new() { HeyboxID = "0" }, XhhVersion, HkeyServer);

            HeyboxUserDetailData user;
            try
            {
                UserEventsResponse response = await xhh.GetUserEvents(userID).ConfigureAwait(false);
                if (response != null && response.Result != null)
                {
                    user = response.Result.User;
                }
                else
                {
                    user = new() { UserName = "读取出错" };
                }
            }
            catch (Exception ex)
            {
                user = new() { UserName = "读取出错", Signature = ex.Message };
            }

            Invoke((Delegate)(() => {
                picAvatar.ImageLocation = user.Avatar ?? "";
                txtUserName.Text = user.UserName;
                txtUserID.Text = user.UserID;
                txtSignature.Text = user.Signature;
                txtLevel.Text = user.LevelInfo.Level.ToString();
                txtFanCount.Text = user.FollowerCount.ToString();
                txtFollowCount.Text = user.FollowingCount.ToString();
                txtAwardedCount.Text = user.AwardedCount.ToString();
                UseWaitCursor = false;
            }));
        }
    }
}
