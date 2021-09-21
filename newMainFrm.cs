using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tokens.rip_Token_Manager
{
    public partial class newMainFrm : Form
    {
        public newMainFrm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(TokenSettings.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
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
        private void EnvironmentExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartSpammer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This is an unfinished release, and therefore is subject to change and be improved.\nAre you sure you want to see it :c", "Tokens.rip - Main", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            var frmSpammer = new frmSpammer();
            frmSpammer.Location = Location;
            frmSpammer.Show();
            this.Hide();
        }

        private void StartManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            var TokenMngr = new TokenManager();
            TokenMngr.Location = this.Location;
            TokenMngr.Show();
            this.Hide();
        }

        private void StartStealer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently this feature isn't available to non-developers.");
        }
    }
}
