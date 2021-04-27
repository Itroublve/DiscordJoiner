using Leaf.xNet;
using System;
using System.Drawing;
using System.Security.Authentication;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Itroublve_Joiner_v2
{
    public partial class ItroublveJoiner : Form
    {
        #region GUI
        public ItroublveJoiner()
        {
            InitializeComponent();
            TokensRichTxt.DragDrop += new DragEventHandler(TokensRichTxt_DragDrop);
            TokensRichTxt.AllowDrop = true;
            ProxiesRichTxt.DragDrop += new DragEventHandler(ProxiesRichTxt_DragDrop);
            ProxiesRichTxt.AllowDrop = true;
            RainbowTimer.Start();
        }
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
                        richTextBox3.Text += match.Value;
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
                        richTextBox3.Text += match.Value;
                    }
                    ProxiesRichTxt.Clear(); ProxiesRichTxt.Text = richTextBox3.Text;
                }

            }
        }

        private void RainbowTimer_Tick(object sender, EventArgs e)
        {
            Rainbow.RainbowEffect();
            RainbowPnlUp.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
            RainbowPnlDown.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void InviteTxtbox_Enter(object sender, EventArgs e)
        {
            if (InviteTxtbox.Text == "Enter Invite") InviteTxtbox.Text = string.Empty;
        }

        private void InviteTxtbox_Leave(object sender, EventArgs e)
        {
            if (InviteTxtbox.Text == string.Empty) InviteTxtbox.Text = "Enter Invite";
        }
        #endregion
        #region Joiner
        private void JoinBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProxiesRichTxt.Text))
            {
                foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                {
                    bool valid = true;
                    while (valid)
                    {
                        var proxies = ProxiesRichTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                        string proxy = proxies[new Random().Next(0, Regex.Matches(ProxiesRichTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)];
                        try
                        {
                            CurrentStatusLbl.Text = "Joining [Proxied]";
                            CurrentStatusLbl.ForeColor = Color.LightYellow;
                            HttpRequest request = new HttpRequest();
                            request.Proxy = HttpProxyClient.Parse(proxy);
                            request.ConnectTimeout = 1000;
                            request.KeepTemporaryHeadersOnRedirect = false;
                            request.ClearAllHeaders();
                            request.EnableMiddleHeaders = false;
                            request.AllowEmptyHeaderValues = false;
                            request.AddHeader("Accept", "*/*");
                            request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                            request.AddHeader("Accept-Language", "en-US");
                            request.AddHeader("Authorization", m.Value);
                            request.AddHeader("Connection", "keep-alive");
                            request.AddHeader("Cookie", "__cfduid=db537515176b9800b51d3de7330fc27d61618084707; __dcfduid=ec27126ae8e351eb9f5865035b40b75d; locale=en-US");
                            request.AddHeader("DNT", "1");
                            request.AddHeader("origin", "https://discord.com");
                            request.AddHeader("Referer", "https://discord.com/channels/@me");
                            request.AddHeader("TE", "Trailers");
                            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                            request.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                            request.SslProtocols = SslProtocols.Tls12;
                            string invite = InviteTxtbox.Text;
                            invite = invite.Replace("discord.gg/", "");
                            invite = invite.Replace("discord.com/invite/", "");
                            invite = invite.Replace("https://", "");
                            request.Post("https://discord.com/api/v9/invites/" + invite);
                            valid = false;
                        }
                        catch (Exception x)
                        {
                            if (x.Message.Contains("401")) valid = false;
                            else if (x.Message.Contains("403")) valid = false;
                            if (x.Message == "Unable to connect to the HTTP-server 'discord.com'.") ProxiesRichTxt.Text = ProxiesRichTxt.Text.Replace(proxy, "");
                        }
                    }
                }
                if (CurrentStatusLbl.Text != "Joining [Proxied]")
                {
                    CurrentStatusLbl.Text = "No Tokens";
                    CurrentStatusLbl.ForeColor = Color.Red;
                }
                else
                {
                    CurrentStatusLbl.Text = "Successfully Joined";
                    CurrentStatusLbl.ForeColor = Color.Green;
                }
            }
            else
            {
                foreach (Match m in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                {
                    try
                    {
                        CurrentStatusLbl.Text = "Joining";
                        CurrentStatusLbl.ForeColor = Color.LightYellow;
                        HttpRequest request = new HttpRequest();
                        request.KeepTemporaryHeadersOnRedirect = false;
                        request.ClearAllHeaders();
                        request.EnableMiddleHeaders = false;
                        request.AllowEmptyHeaderValues = false;
                        request.AddHeader("Accept", "*/*");
                        request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                        request.AddHeader("Accept-Language", "en-US");
                        request.AddHeader("Authorization", m.Value);
                        request.AddHeader("Connection", "keep-alive");
                        request.AddHeader("Cookie", "__cfduid=db537515176b9800b51d3de7330fc27d61618084707; __dcfduid=ec27126ae8e351eb9f5865035b40b75d; locale=en-US");
                        request.AddHeader("DNT", "1");
                        request.AddHeader("origin", "https://discord.com");
                        request.AddHeader("Referer", "https://discord.com/channels/@me");
                        request.AddHeader("TE", "Trailers");
                        request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0");
                        request.AddHeader("X-Super-Properties", "eyJvcyI6IldpbmRvd3MiLCJicm93c2VyIjoiRGlzY29yZCBDbGllbnQiLCJyZWxlYXNlX2NoYW5uZWwiOiJzdGFibGUiLCJjbGllbnRfdmVyc2lvbiI6IjEuMC45MDAxIiwib3NfdmVyc2lvbiI6IjEwLjAuMTkwNDIiLCJvc19hcmNoIjoieDY0Iiwic3lzdGVtX2xvY2FsZSI6ImVuLVVTIiwiY2xpZW50X2J1aWxkX251bWJlciI6ODMwNDAsImNsaWVudF9ldmVudF9zb3VyY2UiOm51bGx9");
                        request.SslProtocols = SslProtocols.Tls12;
                        string invite = InviteTxtbox.Text;
                        invite = invite.Replace("discord.gg/", "");
                        invite = invite.Replace("discord.com/invite/", "");
                        invite = invite.Replace("https://", "");
                        request.Post("https://discord.com/api/v9/invites/" + invite);
                    }
                    catch
                    { }
                }
                if (CurrentStatusLbl.Text != "Joining")
                {
                    CurrentStatusLbl.Text = "No Tokens";
                    CurrentStatusLbl.ForeColor = Color.Red;
                }
                else
                {
                    CurrentStatusLbl.Text = "Successfully Joined";
                    CurrentStatusLbl.ForeColor = Color.Green;
                }
            }
        }
        #endregion
    }
}
