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

        private void tokens_ripLogo_Click(object sender, EventArgs e)
        {
            TokenSettings.Register("P0_eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJwYXNza2V5IjoiZDZIM1NTbm9ra2NmRDc4aC9tTmt6SkJuYzRQa1pLRXVGa2llMk84TWhHVXNIQVVjMUtoSzFhN09kaGRLSWJEQUdKYnBLUEt2QXNUK3grVXRqNmVDQVdzM2Q2YTBOcDRUZ3AzNUlqQkpZR0hYMThoWkZoRUljMW16cTUxcFlzWXhMeklyb0taTDIwUC94ekJ4bkhyZy9nR000RStIVmxjL2Fmenc5K2ZnYy92KzdxVm1vWkpkTnJHa2FpV1dEMGZwaUtoNzJWaXpCb3JDbDJGa2ljdlRNUFZuUGxvdDlzUkFtM1J2RHBPNUh4REFXT21Ja3J0aldKNi9mK2V3aU5CaW9qUDVHNmh1RUVIeGlnNXU5c0J0NllnSG1XWEI2enZMQ3JZamhSSElvck1mNkROa0VmN0U5bDVUVU8wUGphMlAyMENKNHY4SmVmTEhicXE4dUJjRVZRTFY1WXMrOWx6dElzUnJGQmIrdUtOU0l3am10bmptc0gyMDRQMC9WZjBkYk9HV3pyOE8vYW03dE9ZS0pIYkRKdzRvVVdBSHNGa3YvZmVtN3NYS2VlRzdpajVzeGhFLzVYSllCNWxGNHhSeUVQc29TcVNjT3lkZjZZWks3R093VTBhSkljM1ZHcTZVNFFTSlNXZEYySGxLMUZEVEMyZHpTbEE2Rmxrd3RFblRFOWYvdERCR053MFhjbFErTUZGL3hISS9LK3pRaEpZckVITk81bmZpVWxoQzRWM01QVU9nemhhUW91SmVBZ3Q2dUdlU2VLT0VUL0lLQWhIdXBJeXhCZytpeVpRTmtEc2lxN3VJZnpKS1B2Q0YzOVhCRjhHOVQ0cjQwb2FUWGVveDUybERONVlvVGh1ZlNVUk1NdXZhbHN0NmdyQ2M0NWU0bkhncUg1VmwvOUdNOTVWMmpqQUlSTUdCWnRzbDEvdUxMOWQybW9TUm9oaVFpK1Q4d3dTVUN0NGhpekJhT3NNRlVWUkVraGdtU0gxTXRhd2ZWL3QwOXYrNjJ1SnB4Znd6VHhhYm1kTEpKUGlUcnNlQmIvWThWV2kxcnNUUzY4VmpQVWRwZ2dtMXp2c3Irc0djUGZNblpBZnFpdnJhSGRmaEtqdGdiVXJVSXJZa1dCOVJMN1lGUUJScEtBNHJJRWViT004YzFlRFh5V0FxeS9XUkt0bzAzV1JMb2NOaDJ6S1lFNkx6aGhPbExqQXVhNWM3cjIyZVF6dm5HTS9ZQTJ1WFVWZVVnT2VoMU92WEViUTJyWi8zT2pkNkNVeFh2K05rVWVDQVJaSTdvMWNYZlMwTHMxYytIS2xWME4vakc2Uk5XMmdqZGEwQXdCZ2ZRVVlJeG5kRCtxK0Z1citER1VNcnY5Y0JZU0UyRlVISUVZaHJ0aTJ5a2tqdzg5RVRuS29Vc25LdWE2K240SEdPU1pLYU5NMkNHclZkcnc4WTdqZ2tWUTE0QXk1cy80S2tURWI0UWRrMEkvZThqSkVCTGY5SCtSdm0zbnVBT3VRSjlOQlptNVBmWVV5aGRoQThJeEUydkQzY2p3OHZpU0ZVVHVUdFMydzd3K3lLZndDYXdIR3p5d1dmZE93MHBWVHhjQld5WjFTU3RHZi9MN3o1ZWZYbFhob1dmclBPMmlZUjlZWStseUM0WjNJcDVxWnpDMVVBMmxJaWNWck1CdFdCdFlSLzRDR01sRCtJR0FMdkFEam5JRy9EeHZnaGhWV21NRDZNQUlaSWJ3TnhDVE5YdEk2Q004NkZPRGZlNU80a0trdU5mSTNpcUZ5WFJ1V2dPcGlIRllOemtKdnlGcHNtYnd1VXZ2UUlPYjB3c3BkazVXOVQxV2JqMTR3dUxhVEdKWmJxdVlIRFlXOEhOR1dpQWZFRTU0SE9uUmxtZCtTazYvSjJtYi9WVXl1bUhlRXNvWktxUlpRUE1VZEhIUjAyNHhIRnpFT0o5SllGQ3UwcjV1YWdyQWdsbWl5elc4Vk5zdHZHazFkaUwrUWdERzhERDE0VzlqQ0dISDI3Z1RGQkZyeXgvRll6Sk5hMzlMd2liSFl0RWkwdU5zWWY5Ni9DR1lKWFJ1N1ErcjhHb3RpWkQ4UWhCVHlPcDE3aHlKVUdmcStGVWhkeWFXdFZmOGY4QjgveVVITkhjWk9abGw5UXcrc2tnRlN2U3VZPWlRNmk2YStJV0VjZ21VOXAiLCJleHAiOjE2MzMxOTI4MTEsInNoYXJkX2lkIjo4MjA3ODYwODYsInBkIjowfQ.EDV4h1Bpii0CU9SjxSofxWR05aZVWDT6F3KvrmyXaC0");
            //TokenSettings.SendOnline("f");
        }
    }
}
