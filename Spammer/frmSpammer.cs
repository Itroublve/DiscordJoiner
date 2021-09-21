using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tokens.rip_Token_Manager
{
    public partial class frmSpammer : Form
    {
        #region GUI
        public frmSpammer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Region = Region.FromHrgn(TokenSettings.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void BalloonTip_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            Show();
            TopMost = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var newMainfrm = Application.OpenForms.OfType<newMainFrm>().FirstOrDefault();
            newMainfrm.Location = Location;
            if (newMainfrm == null)
                newMainfrm = new newMainFrm();
            newMainfrm.Show();
            Close();
        }

        private void TTSBtn_Click(object sender, EventArgs e)
        {
            if (TTSBtn.FillColor != Color.FromArgb(105, 105, 205))
                TTSBtn.FillColor = Color.FromArgb(105, 105, 205);
            else
                TTSBtn.FillColor = Color.White;
        }
        private void TTSLbl_Click(object sender, EventArgs e) => TTSBtn_Click(sender, e);
        #endregion
        private async void SpamBtn_Click(object sender, EventArgs e)
        {
            new Thread(delegate ()
            {
                bool startSpam;
                if (SpamBtn.Text == "Start Spammer")
                {
                    startSpam = true;
                    SpamBtn.Text = "Stop Spammer";
                }
                else
                {
                    startSpam = false;
                    SpamBtn.Text = "Start Spammer";
                }
                var PrxArray = MessageTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                while (startSpam)
                {
                    if (!string.IsNullOrEmpty(ProxiesTxt.Text))
                    {
                        ThreadPool.SetMinThreads(1000, 1000);
                        Parallel.ForEach(Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), (token, state) =>
                        {
                            TokenSettings.SendMsg(token.Value, spammerChannelIdTxt.Text, MessageTxt.Text, TTSBtn.FillColor == Color.FromArgb(105, 105, 205), msgRefIdTxt.Text, true, PrxArray[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(MessageTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]);
                        });
                    }
                    else
                    {
                        //ThreadPool.SetMinThreads(1000, 1000);
                        //Parallel.ForEach(Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), (token, state) =>
                        //{
                        //    TokenSettings.SendMsg(token.Value, spammerChannelIdTxt.Text, MessageTxt.Text, TTSBtn.FillColor == Color.FromArgb(105, 105, 205), msgRefIdTxt.Text, false);
                        //    if (!startSpam) state.Stop();
                        //});
                        foreach (Match match in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                        {
                            Task.Run(() => TokenSettings.SendMsg(match.Value, spammerChannelIdTxt.Text, MessageTxt.Text, TTSBtn.FillColor == Color.FromArgb(105, 105, 205), msgRefIdTxt.Text, false));
                        }
                    }
                }
                BalloonTip.BalloonTipTitle = "Successfully Stopped Spamming";
                BalloonTip.BalloonTipText = "Click to return.";
                BalloonTip.BalloonTipClicked += BalloonTip_Click;
                BalloonTip.ShowBalloonTip(1000);
            }).Start();
        }

        private async void AddReactionBtn_Click(object sender, EventArgs e)
        {
            var PrxArray = MessageTxt.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            await Task.Run(async () =>
            {
                if (!string.IsNullOrEmpty(MessageTxt.Text))
                {
                    Parallel.ForEach(Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}").Cast<Match>(), async (token) =>
                    {
                        await TokenSettings.AddReaction(token.Value, reactionChannelIdTxt.Text, MsgIdTxt.Text, EmojiTxt.Text, true, PrxArray[new Random(Guid.NewGuid().GetHashCode()).Next(Regex.Matches(MessageTxt.Text, @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b:\d{2,5}").Count)]).ConfigureAwait(false);
                    });
                }
                else
                {
                    foreach (Match token in Regex.Matches(TokensRichTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{25,27}|mfa\.[\w-]{84}"))
                    {
                        await TokenSettings.AddReaction(token.Value, reactionChannelIdTxt.Text, MsgIdTxt.Text, EmojiTxt.Text, false).ConfigureAwait(false);
                    }
                }
                BalloonTip.BalloonTipTitle = "Successfully Added Reactions";
                BalloonTip.BalloonTipText = "Click to return.";
                BalloonTip.BalloonTipClicked += BalloonTip_Click;
                BalloonTip.ShowBalloonTip(1000);
            });
        }
    }
}
