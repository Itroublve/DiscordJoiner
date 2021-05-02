using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;

namespace Itroublve_Joiner_v3
{
    public partial class TokenManager : Form
    {
        #region List & Driver
        public List<string> sad = new List<string>();
        public List<string> Tokens = new List<string>();
        public List<string> WorkingTokens = new List<string>();
        public bool flag = true;
        ChromeDriver driver;
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
            this.FormClosing += this.CloseBtn_Click;
            RainbowTimer.Start();
        }
        private void TknSettingsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Releasing in newer versions.", "Itroublve Token Manager");
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
            CurrentStatusLbl.Text = $"Checking: {WorkingTokens.Count}/{Tokens.Count}";
            CurrentStatusLbl.ForeColor = Color.Yellow;
            if (Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Count == Tokens.Count)
            {
                TokensRichTxt.ReadOnly = false;
                CurrentStatusLbl.Text = $"Valid Tokens: {WorkingTokens.Count}/{Tokens.Count}";
                CurrentStatusLbl.ForeColor = Color.Green;
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
            try
            {
                Process[] procs = Process.GetProcessesByName("chromedriver.exe");
                foreach (Process p in procs) p.Kill();
            }
            catch
            {
                driver?.Quit();
            }

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
        #region Joiner 
        public async Task Joiner()
        {
            var options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--log-level=3");
            options.AddArgument("--disable-crash-reporter");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-in-process-stack-traces");
            options.AddArgument("--disable-logging");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--ignore-certificate-errors");
            try
            {
                var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string proxy = proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)];
                var prx = new Proxy();
                prx.Kind = ProxyKind.Manual;
                prx.IsAutoDetect = false;
                prx.HttpProxy = proxy;
                options.Proxy = prx;
            }
            catch
            { }
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            service.EnableVerboseLogging = true;
            if (Regex.Match(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Success)
            {
                string invite = InviteTxtbox.Text;
                invite = invite.Replace("discord.gg/", "");
                invite = invite.Replace("discord.com/invite/", "");
                invite = invite.Replace("https://", "");
                var request = new HttpClient();
                var response = await request.GetAsync($"https://discord.com/api/v9/invites/{invite}").ConfigureAwait(false);
                dynamic info = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                string guildId = info.guild.id.ToString();
                driver = new ChromeDriver(service, options);
                driver.Navigate().GoToUrl("https://discord.com/api/invites/ichpro");
                if (!string.IsNullOrEmpty(ProxiesRichTxt.Text))
                {
                    CurrentStatusLbl.Text = "Joining [Proxied]";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                    {
                        if (!string.Join("\n", sad).Contains(m.Value))
                        {
                            sad.Add(m.Value);
                            try
                            {
                                await Task.Delay(DelayBar.Value * 1000);
                                driver.ExecuteScript("fetch(\"https://discord.com/api/v9/invites/" + invite + "\", { \"headers\": { \"authorization\": \"" + m.Value + "\", \"x-super-properties\": \"eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzkwLjAuNDQzMC45MyBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTAuMC40NDMwLjkzIiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiJodHRwczovL3JlcGwuaXQvIiwicmVmZXJyaW5nX2RvbWFpbiI6InJlcGwuaXQiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMzNjQsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9\"},  \"method\": \"POST\"});");
                                request.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", m.Value);
                                try 
                                {
                                    await Task.Delay(500).ConfigureAwait(false);
                                    var sadness = await request.GetAsync($"https://discord.com/api/v9/guilds/{guildId}/member-verification?with_guild=false&invite_code={invite}");
                                    dynamic form = JsonConvert.DeserializeObject(sadness.Content.ReadAsStringAsync().Result);
                                    string msg = form.form_fields.ToString();
                                    msg = msg.Replace("\n", "").Replace("\r", "");
                                    msg = msg.Replace("}]", "");
                                    msg = Regex.Replace(msg, @".*(?="").*(?="")",
                                    match => { return match.Value.Replace("\"", "\\\""); });
                                    msg = msg.Replace("\"", "\\\""); msg = msg.Replace("\\\\\"", "\\\"");
                                    string date = sadness.Content.ReadAsStringAsync().Result.Substring(13, 32);
                                    string oof = ("fetch(\"https://discord.com/api/v9/guilds/" + guildId + "/requests/@me\", { \"headers\": {\"authorization\": \"" + m.Value + "\",\"content-type\": \"application/json\",\"x-super-properties\": \"eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzkwLjAuNDQzMC45MyBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTAuMC40NDMwLjkzIiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiJodHRwczovL3JlcGwuaXQvIiwicmVmZXJyaW5nX2RvbWFpbiI6InJlcGwuaXQiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMzNjQsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9\"},  \"body\": \"{\\\"version\\\":\\\"" + date + "\\\",\\\"form_fields\\\":" + msg + ",\\\"response\\\":true}]}\",\"method\": \"PUT\"});");
                                    driver.ExecuteScript(oof);
                                }
                                catch { }
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }
                        }
                    }
                }
                else
                {
                    CurrentStatusLbl.Text = "Joining";
                    CurrentStatusLbl.ForeColor = Color.Yellow;
                    foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                    {
                        if (!string.Join("\n", sad).Contains(m.Value))
                        {
                            sad.Add(m.Value);
                            try
                            {
                                await Task.Delay(DelayBar.Value * 1000);
                                driver.ExecuteScript("fetch(\"https://discord.com/api/v9/invites/" + invite + "\", { \"headers\": { \"authorization\": \"" + m.Value + "\", \"x-super-properties\": \"eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzkwLjAuNDQzMC45MyBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTAuMC40NDMwLjkzIiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiJodHRwczovL3JlcGwuaXQvIiwicmVmZXJyaW5nX2RvbWFpbiI6InJlcGwuaXQiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMzNjQsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9\"},  \"method\": \"POST\"});");
                                request.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", m.Value);
                                try
                                {
                                    await Task.Delay(500).ConfigureAwait(false);
                                    var sadness = await request.GetAsync($"https://discord.com/api/v9/guilds/{guildId}/member-verification?with_guild=false&invite_code={invite}");
                                    dynamic form = JsonConvert.DeserializeObject(sadness.Content.ReadAsStringAsync().Result);
                                    string msg = form.form_fields.ToString();
                                    msg = msg.Replace("\n", "").Replace("\r", "");
                                    msg = msg.Replace("}]", "");
                                    msg = Regex.Replace(msg, @".*(?="").*(?="")",
                                    match => { return match.Value.Replace("\"", "\\\""); });
                                    msg = msg.Replace("\"", "\\\""); msg = msg.Replace("\\\\\"", "\\\"");
                                    string date = sadness.Content.ReadAsStringAsync().Result.Substring(13, 32);
                                    string oof = ("fetch(\"https://discord.com/api/v9/guilds/" + guildId + "/requests/@me\", { \"headers\": {\"authorization\": \"" + m.Value + "\",\"content-type\": \"application/json\",\"x-super-properties\": \"eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiQ2hyb21lIiwiZGV2aWNlIjoiIiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiYnJvd3Nlcl91c2VyX2FnZW50IjoiTW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzkwLjAuNDQzMC45MyBTYWZhcmkvNTM3LjM2IiwiYnJvd3Nlcl92ZXJzaW9uIjoiOTAuMC40NDMwLjkzIiwib3NfdmVyc2lvbiI6IjEwIiwicmVmZXJyZXIiOiJodHRwczovL3JlcGwuaXQvIiwicmVmZXJyaW5nX2RvbWFpbiI6InJlcGwuaXQiLCJyZWZlcnJlcl9jdXJyZW50IjoiIiwicmVmZXJyaW5nX2RvbWFpbl9jdXJyZW50IjoiIiwicmVsZWFzZV9jaGFubmVsIjoic3RhYmxlIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMzNjQsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9\"},  \"body\": \"{\\\"version\\\":\\\"" + date + "\\\",\\\"form_fields\\\":" + msg + ",\\\"response\\\":true}]}\",\"method\": \"PUT\"});");
                                    driver.ExecuteScript(oof);
                                }
                                catch { }
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }
                        }
                    }
                    driver.Quit();
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

        private async void JoinBtn_Click(object sender, EventArgs e)
        {
            JoinBtn.Enabled = false;
            TokensRichTxt.ReadOnly = true;
            sad.Clear();
            BeginInvoke(new MethodInvoker(async delegate ()
            {
                await Task.Run(Joiner).ConfigureAwait(false);
            }));
        }
        #endregion
        #region Token Checker
        private void ChkTknPrx_Click(object sender, EventArgs e)
        {
            ChkTknPrxBtn.Enabled = false;
            TokensRichTxt.ReadOnly = true;
            CountToken.Start();
            BeginInvoke(new MethodInvoker(async delegate ()
            {
                Parallel.ForEach(Regex.Matches(TokensRichTxt.Text,  @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}").Cast<Match>(),
                async token =>
                {
                    await Task.Run(() => Checker(token.Value)).ConfigureAwait(false);
                });
            }));
        }
        public async Task Checker(string Token)
        {
            try
            {
                var wc = new WebClient();
                wc.Headers.Add("Content-Type", "application/json");
                wc.Headers.Add(HttpRequestHeader.Authorization, Token);
                wc.DownloadString("https://discordapp.com/api/v9/users/@me/guilds");
                WorkingTokens.Add(Token);
                wc.Dispose();
            }
            catch
            {
                try
                {
                    var wc = new WebClient();
                    wc.Headers.Add("Content-Type", "application/json");
                    wc.Headers.Add(HttpRequestHeader.Authorization, Token);
                    wc.DownloadString("https://discordapp.com/api/v8/users/@me/guilds");
                    wc.Dispose();
                    WorkingTokens.Add(Token);
                }
                catch
                {
                }
            }
            Tokens.Add(Token);
        }
        #endregion
    }
}