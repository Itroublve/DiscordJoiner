using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itroublve_Joiner_v3
{
    public partial class FriendOpt : Form
    {
        #region GUI
        public static string _Token;

        public FriendOpt(string Token)
        {
            _Token = Token;
            InitializeComponent();
            HeadLbl.Left = (ClientSize.Width - HeadLbl.Width) / 2;
            RainbowTimer.Start();
            if (string.IsNullOrEmpty(_Token))
            {
                NoTokenPnl.Visible = true;
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
            Hide();
        }
        #endregion
        #region Functions
        private async void AddUserBtn_Click(object sender, EventArgs e)
        {
            foreach (Match m in Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
            {
                CurrentStatusLbl.Text = $"Friending {FrndTxt.Text}";
                CurrentStatusLbl.ForeColor = Color.Yellow;
                await Task.Run(() => TokenSettings.SendFriendReq(FrndTxt.Text, m.Value)).ConfigureAwait(false);
            }
            CurrentStatusLbl.Text = $"Finished Friending {FrndTxt.Text}";
            CurrentStatusLbl.ForeColor = Color.Green;
        }

        private async void RmvUserBtn_Click(object sender, EventArgs e)
        {
            foreach (Match m in Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
            {
                CurrentStatusLbl.Text = $"Removing {FrndTxt.Text}";
                CurrentStatusLbl.ForeColor = Color.Yellow;
                await Task.Run(() => TokenSettings.RemoveFriend(FrndTxt.Text, m.Value)).ConfigureAwait(false);
            }
            CurrentStatusLbl.Text = $"Finished Removing {FrndTxt.Text}";
            CurrentStatusLbl.ForeColor = Color.Green;
        }

        private async void BlockUserBtn_Click(object sender, EventArgs e)
        {
            foreach (Match m in Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
            {
                CurrentStatusLbl.Text = $"Blocking {FrndTxt.Text}";
                CurrentStatusLbl.ForeColor = Color.Yellow;
                await Task.Run(() => TokenSettings.BlockFriend(FrndTxt.Text, m.Value)).ConfigureAwait(false);
            }
            CurrentStatusLbl.Text = $"Finished Blocking {FrndTxt.Text}";
            CurrentStatusLbl.ForeColor = Color.Green;
        }
        #endregion
    }
}
