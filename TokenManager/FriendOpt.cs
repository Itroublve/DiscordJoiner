using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tokens.rip_Token_Manager
{
    public partial class FriendOpt : Form
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
        public FriendOpt(string _Token, string _Proxy)
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void HeadLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BalloonTip_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            this.Show();
            this.TopMost = true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (NoTokenPnl.Visible) Close();
            if (CurrentStatusLbl.Text == "Idling") Close();
            Hide();
        }
        private void MassGuildBtn_Click(object sender, EventArgs e)
        {
            if (MassGuildBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                FrndTxt.PlaceholderText = "Enter Guild ID";
                MassGuildBtn.FillColor = Color.FromArgb(105, 105, 205);
            }
            else
            {
                FrndTxt.PlaceholderText = "Enter User ID";
                MassGuildBtn.FillColor = Color.White;
            }
        }
        private void MassGuildLbl_Click(object sender, EventArgs e)
        {
            if (MassGuildBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                FrndTxt.PlaceholderText = "Enter Guild ID";
                MassGuildBtn.FillColor = Color.FromArgb(105, 105, 205);
            }
            else
            {
                FrndTxt.PlaceholderText = "Enter User ID";
                MassGuildBtn.FillColor = Color.White;
            }
        }
        #endregion
        #region Send Friend Request
        private async void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (MassGuildBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                if (string.IsNullOrEmpty(FrndTxt.Text))
                {
                    MessageBox.Show("Enter UserID or Username", "Friend Options");
                }
                await Task.Run(async () =>
                {
                    CurrentStatusLbl.Text = $"Friending {FrndTxt.Text}";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    if (!string.IsNullOrEmpty(Proxy))
                    {
                        Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (token) =>
                        {
                            await TokenSettings.SendFriendReq(FrndTxt.Text, token.Value, true, PrxArray[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Proxy, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]).ConfigureAwait(false);
                        });
                    }
                    else
                    {
                        foreach (Match token in Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                        {
                            await TokenSettings.SendFriendReq(FrndTxt.Text, token.Value, false).ConfigureAwait(false);
                        }
                    }
                    CurrentStatusLbl.Text = $"Finished Friending {FrndTxt.Text}";
                    CurrentStatusLbl.ForeColor = Color.Green;
                    FriendNotification.BalloonTipTitle = "Successfully Sent Friend Requests";
                    FriendNotification.BalloonTipText = "Click to return.";
                    FriendNotification.BalloonTipClicked += BalloonTip_Click;
                    FriendNotification.ShowBalloonTip(1000);
                });
            }
            else
            {
                MessageBox.Show("Not yet implemented", "Friend Options");
            }
        }
        #endregion
        #region Remove Friend Request
        private async void RmvUserBtn_Click(object sender, EventArgs e)
        {
            if (MassGuildBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                if (FrndTxt.Text.Contains("#") || String.IsNullOrEmpty(FrndTxt.Text))
                {
                    MessageBox.Show("Enter UserID", "Friend Options");
                    return;
                }
                await Task.Run(async () =>
                {
                    CurrentStatusLbl.Text = $"Removing {FrndTxt.Text}";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    if (!string.IsNullOrEmpty(Proxy))
                    {
                        ThreadPool.SetMinThreads(500, 500);
                        Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (token) =>
                        {
                            await TokenSettings.RemoveFriend(FrndTxt.Text, token.Value, true, PrxArray[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Proxy, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]).ConfigureAwait(false);
                        });
                    }
                    else
                    {
                        foreach (Match token in Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                        {
                            await TokenSettings.RemoveFriend(FrndTxt.Text, token.Value, false, null).ConfigureAwait(false);
                        }
                    }
                    CurrentStatusLbl.Text = $"Finished Removing {FrndTxt.Text}";
                    CurrentStatusLbl.ForeColor = Color.Green;
                    FriendNotification.BalloonTipTitle = "Successfully Removed Requests";
                    FriendNotification.BalloonTipText = "Click to return.";
                    FriendNotification.BalloonTipClicked += BalloonTip_Click;
                    FriendNotification.ShowBalloonTip(1000);
                });
            }
            else
            {
                MessageBox.Show("Not yet implemented", "Friend Options");
            }
        }
        #endregion
        #region Block User
        private async void BlockUserBtn_Click(object sender, EventArgs e)
        {
            if (MassGuildBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                if (FrndTxt.Text.Contains("#") || String.IsNullOrEmpty(FrndTxt.Text))
                {
                    MessageBox.Show("Enter UserID", "Friend Options");
                    return;
                }
                await Task.Run(async () =>
                {
                    CurrentStatusLbl.Text = $"Blocking {FrndTxt.Text}";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    if (!string.IsNullOrEmpty(Proxy))
                    {
                        ThreadPool.SetMinThreads(500, 500);
                        Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (token) =>
                        {
                            await TokenSettings.BlockFriend(FrndTxt.Text, token.Value, true, PrxArray[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Proxy, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]).ConfigureAwait(false);
                        });
                    }
                    else
                    {
                        foreach (Match token in Regex.Matches(Token , @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                        {
                            await TokenSettings.BlockFriend(FrndTxt.Text, token.Value, false, null).ConfigureAwait(false);
                        }
                    }
                    CurrentStatusLbl.Text = $"Finished Blocking {FrndTxt.Text}";
                    CurrentStatusLbl.ForeColor = Color.Green;
                    FriendNotification.BalloonTipTitle = "Successfully Blocked User";
                    FriendNotification.BalloonTipText = "Click to return.";
                    FriendNotification.BalloonTipClicked += BalloonTip_Click;
                    FriendNotification.ShowBalloonTip(1000);
                });
            }
            else
            {
                MessageBox.Show("Not yet implemented", "Friend Options");
            }
        }
        #endregion
    }
}
