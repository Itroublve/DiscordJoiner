using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itroublve_Joiner_v3
{
    public partial class TokenSettingsFrm : Form
    {
        #region idk what these shall be called
        public static string _Token;
        public ChromeDriver driver;
        public OpenFileDialog filedialog = new OpenFileDialog();
        #endregion
        #region GUI
        public TokenSettingsFrm(string Token)
        {
            InitializeComponent();
            HeadLbl.Left = (ClientSize.Width - HeadLbl.Width) / 2;
            RainbowTimer.Start();
            _Token = Token;
        }

        private void RainbowTimer_Tick(object sender, EventArgs e)
        {
            Rainbow.RainbowEffect();
            PictureBoxPnl.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
            RainbowPnlUp.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
            RainbowPnlDown.BackColor = Color.FromArgb(Rainbow.A, Rainbow.R, Rainbow.G);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion
        #region TextBox Placeholder
        #region TextBox Enter
        private void EmailTxtBox_Enter(object sender, EventArgs e)
        {
            if (EmailTxtBox.Text == "Enter Email") EmailTxtBox.Text = string.Empty;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Enter Password") PasswordTxt.Text = string.Empty;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "Enter New Username") UsernameTxt.Text = string.Empty;
        }
        private void LgnTknTxt_Enter(object sender, EventArgs e)
        {
            if (LgnTknTxt.Text == "Token") LgnTknTxt.Text = string.Empty;
        }
        #endregion
        #region TextBox Leave
        private void EmailTxtBox_Leave(object sender, EventArgs e)
        {
            if (EmailTxtBox.Text == string.Empty) EmailTxtBox.Text = "Enter Email";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == string.Empty) PasswordTxt.Text = "Enter Password";
        }

        private void UsernameTxt_Leave(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == string.Empty) UsernameTxt.Text = "Enter New Username";
        }

        private void LgnTknTxt_Leave(object sender, EventArgs e)
        {
            if (LgnTknTxt.Text == string.Empty) LgnTknTxt.Text = "Token";
        }
        #endregion

        #endregion
        #region Functions
        private void PictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                filedialog.Title = "Itroublve Token Manager | Mass Profile Picture Changer";
                filedialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg";
                filedialog.ShowDialog();
                PictureBox.Image = Image.FromFile(filedialog.FileName);
            }
            catch { }
        }
        private void TokenLgnBtn_Click(object sender, EventArgs e)
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-crash-reporter");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--disable-in-process-stack-traces");
            options.AddArgument("--disable-logging");
            options.AddArgument("--ignore-certificate-errors");
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            service.EnableVerboseLogging = true;
            driver = new ChromeDriver(service, options);
            driver.Navigate().GoToUrl("https://discord.com/login");
            driver.ExecuteScript("(function() { window.gay = \"" + LgnTknTxt.Text + "\"; window.localStorage = document.body.appendChild(document.createElement `iframe`).contentWindow.localStorage;window.setInterval(() => window.localStorage.token = `\"${window.gay}\"`);window.location.reload();})();");
        }
        private async void ApplyToTokenBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to set this as profile picture for all tokens?", "Token Manager", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (Match match in Regex.Matches(_Token, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                {
                    await Task.Run(() => TokenSettings.ChangePfp(filedialog.FileName, match.Value));
                }
            }
            else
            {
                foreach (Match match in Regex.Matches(LgnTknTxt.Text, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}|mfa\.[\w-]{84}"))
                {
                    await Task.Run(() => TokenSettings.ChangePfp(filedialog.FileName, match.Value));
                }
            }
        }
        #endregion
    }
}
