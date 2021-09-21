using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Tokens.rip_Token_Manager
{
    public partial class addReactionFrm : Form
    {
        #region GUI
        public static string[] PrxArray;
        public string Proxy;
        public string Token;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        private void BalloonTip_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Show();
            this.TopMost = true;
        }
        public addReactionFrm(string _Token, string _Proxy = null)
        {
            Proxy = _Proxy;
            Token = _Token;
            InitializeComponent();
            HeadLbl.Left = (ClientSize.Width - HeadLbl.Width) / 2;
            RainbowPnlUp.Left = (ClientSize.Width - RainbowPnlUp.Width) / 2;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            if (!string.IsNullOrEmpty(Proxy))
                PrxArray = Proxy.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (string.IsNullOrEmpty(Token) | !Regex.IsMatch(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
            {
                NoTokenPnl.Visible = true;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion

        #region Add Reaction
        private async void AddReactionBtn_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                AddReactionBtn.Enabled = false;
                if (!string.IsNullOrEmpty(Proxy))
                {
                    Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (token) =>
                    {
                        await TokenSettings.AddReaction(token.Value, ChannelIdTxt.Text, MsgIdTxt.Text, EmojiTxt.Text, true, PrxArray[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Proxy, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]).ConfigureAwait(false);
                    });
                }
                else
                {
                    foreach (Match token in Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                    {
                        await TokenSettings.AddReaction(token.Value, ChannelIdTxt.Text, MsgIdTxt.Text, EmojiTxt.Text, false).ConfigureAwait(false);
                    }
                }
                FriendNotification.BalloonTipTitle = "Successfully Added Reactions";
                FriendNotification.BalloonTipText = "Click to return.";
                FriendNotification.BalloonTipClicked += BalloonTip_Click;
                FriendNotification.ShowBalloonTip(1000);
            });
        }
        #endregion
    }
}
