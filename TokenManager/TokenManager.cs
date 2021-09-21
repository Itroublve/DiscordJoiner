using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tokens.rip_Token_Manager
{
    public partial class TokenSettingsFrm : Form
    {
        #region idk what these shall be called
        public static string _Token;
        public string[] Username;
        public string[] Pfp;
        public static string[] _Proxy;
        public static string Prx;
        public ChromeDriver driver;
        #endregion
        #region GUI
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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void RandomUsernameLbl_Click(object sender, EventArgs e) => RandomizeUsernameBtn_Click(sender, e);
        private void RandomPfpLbl_Click(object sender, EventArgs e) => RandomizePfpBtn_Click(sender, e);
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
        public TokenSettingsFrm(string Token, string Proxy)
        {
            InitializeComponent();
            HeadLbl.Left = (ClientSize.Width - HeadLbl.Width) / 2;
            RainbowPnlUp.Left = (ClientSize.Width - RainbowPnlUp.Width) / 2;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _Token = Token;
            Prx = Proxy;
            if (!string.IsNullOrEmpty(Proxy))
                _Proxy = Proxy.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion
        #region Set Profile Picture & Apply
        private void RandomizePfpBtn_Click(object sender, EventArgs e)
        {
            if (RandomizePfpBtn.FillColor != Color.FromArgb(105, 105, 205))
                RandomizePfpBtn.FillColor = Color.FromArgb(105, 105, 205);
            else
                RandomizePfpBtn.FillColor = Color.White;
        }
        private async void PictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            bool flag = true;
            if (RandomizePfpBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                try
                {
                    filedialog.Title = "Tokens.rip Token Manager | Mass Profile Picture Changer";
                    filedialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg";
                    if (filedialog.ShowDialog() == DialogResult.OK) flag = false;
                    PictureBox.Image = Image.FromFile(filedialog.FileName);
                }
                catch { return; }
            }
            else
            {
                try
                {
                    List<string> _Pfp = new List<string>();
                    filedialog.Title = "Tokens.rip Token Manager | Mass Random Profile Picture Changer";
                    filedialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg";
                    filedialog.Multiselect = true;
                    if (filedialog.ShowDialog() == DialogResult.OK) flag = false;
                    foreach (string image in filedialog.FileNames)
                    {
                        _Pfp.Add(image);
                    }
                    Pfp = _Pfp.ToArray();
                }
                catch { return; }
            }
            if (flag) return;
            await Task.Run(async () =>
            {
                if (!string.IsNullOrEmpty(Prx))
                {
                    ThreadPool.SetMinThreads(500, 500);
                    Parallel.ForEach(Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (match) =>
                    {
                        if (RandomizePfpBtn.FillColor != Color.FromArgb(105, 105, 205))
                            await TokenSettings.ChangePfp(filedialog.FileName, match.Value, true, _Proxy[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Prx, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                        else
                            await TokenSettings.ChangePfp(Pfp[new Random(Guid.NewGuid().GetHashCode()).Next(Pfp.Length)], match.Value, true, _Proxy[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Prx, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                    });
                }
                else
                {
                    Parallel.ForEach(Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (match) =>
                    {
                        if (RandomizePfpBtn.FillColor != Color.FromArgb(105, 105, 205))
                            await TokenSettings.ChangePfp(filedialog.FileName, match.Value, false);
                        else
                            await TokenSettings.ChangePfp(Pfp[new Random(Guid.NewGuid().GetHashCode()).Next(Pfp.Length)], match.Value, false);
                    });
                }
            });
            TokenSettingsNotification.BalloonTipTitle = "Successfully Changed Profile Picture(s)!";
            TokenSettingsNotification.BalloonTipText = "Click to return.";
            TokenSettingsNotification.BalloonTipClicked += BalloonTip_Click;
            TokenSettingsNotification.ShowBalloonTip(1000);
        }
        #endregion
        #region Login Token
        private void TokenLgnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new ChromeOptions();
                options.AddArgument("--disable-crash-reporter");
                options.AddArgument("--disable-extensions");
                options.AddArgument("--disable-in-process-stack-traces");
                options.AddArgument("--ignore-certificate-errors");
                options.AddArgument("--disable-logging");
                options.AddArgument("--disable-popup-blocking");
                var service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                service.EnableVerboseLogging = true;
                driver = new ChromeDriver(service, options);
                driver.Navigate().GoToUrl("https://discord.com/login");
                driver.ExecuteScript("(function() { window.gay = \"" + LgnTknTxt.Text + "\"; window.localStorage = document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage;window.setInterval(() => window.localStorage.token = `\"${window.gay}\"`);window.location.reload();})();");
            }
            catch (Exception x) 
            {
                MessageBox.Show(x.Message);
            }
        }
        #endregion
        #region Change Username
        private void RandomizeUsernameBtn_Click(object sender, EventArgs e)
        {
            if (RandomizeUsernameBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                try
                {
                    var Nickname = new OpenFileDialog();
                    Nickname.Title = "Tokens.rip Token Manager | Nickname Changer [Nickname List]";
                    Nickname.Filter = "All files (*.*)|*.*";
                    Nickname.ShowDialog();
                    string Nicknames = File.ReadAllText(Nickname.FileName);
                    Username = Nicknames.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                }
                catch { return; }
                RandomizeUsernameBtn.FillColor = Color.FromArgb(105, 105, 205);
                UsernameTxt.Text = ""; UsernameTxt.Enabled = false;
            }
            else
            {
                UsernameTxt.Enabled = true;
                RandomizeUsernameBtn.FillColor = Color.White;
            }
        }

        private async void ChangeUserName_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                if (ChangeUserName.Text != "Change Username")
                {
                    ChangeUserName2_Click(sender, e);
                    return;
                }
                if (RandomizeUsernameBtn.FillColor != Color.FromArgb(105, 105, 205))
                {
                    if (!string.IsNullOrEmpty(Prx))
                    {
                        ThreadPool.SetMinThreads(500, 500);
                        Parallel.ForEach(Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (match) =>
                        {
                            await TokenSettings.ChangeUsername(match.Value, PasswordTxt.Text, UsernameTxt.Text, true, _Proxy[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Prx, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                        });
                    }
                    else
                    {
                        foreach (Match match in Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                        {
                            await TokenSettings.ChangeUsername(match.Value, PasswordTxt.Text, UsernameTxt.Text, false);
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Prx))
                    {
                        ThreadPool.SetMinThreads(500, 500);
                        Parallel.ForEach(Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (match) =>
                        {
                            await TokenSettings.ChangeUsername(match.Value, PasswordTxt.Text, Username[new Random(Guid.NewGuid().GetHashCode()).Next(Username.Length)], true, _Proxy[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(Prx, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                        });
                    }
                    else
                    {
                        foreach (Match match in Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                        {
                            await TokenSettings.ChangeUsername(match.Value, PasswordTxt.Text, Username[new Random(Guid.NewGuid().GetHashCode()).Next(Username.Length)], false);
                        }
                    }
                }
                TokenSettingsNotification.BalloonTipTitle = "Successfully Changed Username(s)!";
                TokenSettingsNotification.BalloonTipText = "Click to return.";
                TokenSettingsNotification.BalloonTipClicked += BalloonTip_Click;
                TokenSettingsNotification.ShowBalloonTip(1000);
            });
        }

        #endregion
        #region Send Token Online
        private async void SendOnlineBtn_click(object sender, EventArgs e)
        {
            await TokenSettings.SendOnline("").ConfigureAwait(false);
            await Task.Run(() =>
            {
                ThreadPool.SetMinThreads(500, 500);
                Parallel.ForEach(Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (m) =>
                {
                    await TokenSettings.SendOnline(m.Value).ConfigureAwait(false);
                });
                TokenSettingsNotification.BalloonTipTitle = "Successfully Send All Tokens Online!";
                TokenSettingsNotification.BalloonTipText = "Click to return.";
                TokenSettingsNotification.BalloonTipClicked += BalloonTip_Click;
                TokenSettingsNotification.ShowBalloonTip(1000);
            });
        }
        #endregion
        #region Default Zone idfk
        private void DefaultLbl_Click(object sender, EventArgs e) => DefaultBtn_Click(sender, e);
        private void DefaultBtn_Click(object sender, EventArgs e)
        {
            if (DefaultBtn.FillColor != Color.FromArgb(105, 105, 205))
            {
                DefaultBtn.FillColor = Color.FromArgb(105, 105, 205);
                ChangeUserName.Text = "Randomize Token";
            }
            else
            {
                ChangeUserName.Text = "Change Username";
                DefaultBtn.FillColor = Color.White;
            }
        }
        private async void ChangeUserName2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are gay.");
        }
        #endregion
    }
}