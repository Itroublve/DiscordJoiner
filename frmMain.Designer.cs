
namespace Tokens.rip_Token_Manager
{
    partial class TokenManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TokensRichTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.TokensLbl = new System.Windows.Forms.Label();
            this.ProxiesLbl = new System.Windows.Forms.Label();
            this.RainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.CurrentStatusLbl = new System.Windows.Forms.Label();
            this.CountToken = new System.Windows.Forms.Timer(this.components);
            this.DelayBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.BypassServerVerifyLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ServerVerificationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.InviteTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProxiesRichTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CaptchaBot = new Guna.UI2.WinForms.Guna2Button();
            this.BypassServerVerifyBotLbl = new System.Windows.Forms.Label();
            this.RainbowPnlUp = new System.Windows.Forms.Panel();
            this.MovePnl = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TknSettingsBtn = new RoundBtn();
            this.frndBtn = new RoundBtn();
            this.JoinBtn = new RoundBtn();
            this.LeaveBtn = new RoundBtn();
            this.ChkTknPrxBtn = new RoundBtn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TokensRichTxt);
            this.panel1.Location = new System.Drawing.Point(21, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 310);
            this.panel1.TabIndex = 0;
            // 
            // TokensRichTxt
            // 
            this.TokensRichTxt.AllowDrop = true;
            this.TokensRichTxt.Animated = true;
            this.TokensRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokensRichTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TokensRichTxt.BorderRadius = 22;
            this.TokensRichTxt.BorderThickness = 2;
            this.TokensRichTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TokensRichTxt.DefaultText = "";
            this.TokensRichTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TokensRichTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TokensRichTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TokensRichTxt.DisabledState.Parent = this.TokensRichTxt;
            this.TokensRichTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TokensRichTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokensRichTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TokensRichTxt.FocusedState.Parent = this.TokensRichTxt;
            this.TokensRichTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TokensRichTxt.ForeColor = System.Drawing.Color.White;
            this.TokensRichTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TokensRichTxt.HoverState.Parent = this.TokensRichTxt;
            this.TokensRichTxt.Location = new System.Drawing.Point(0, 0);
            this.TokensRichTxt.MaxLength = 2147483647;
            this.TokensRichTxt.Multiline = true;
            this.TokensRichTxt.Name = "TokensRichTxt";
            this.TokensRichTxt.PasswordChar = '\0';
            this.TokensRichTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.TokensRichTxt.PlaceholderText = "";
            this.TokensRichTxt.SelectedText = "";
            this.TokensRichTxt.ShadowDecoration.Parent = this.TokensRichTxt;
            this.TokensRichTxt.Size = new System.Drawing.Size(337, 310);
            this.TokensRichTxt.TabIndex = 1;
            this.TokensRichTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.TokensRichTxt_DragDrop);
            this.TokensRichTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.TokensRichTxt_DragEnter);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.Silver;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(531, 490);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(11, 11);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // DelayLbl
            // 
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.DelayLbl.ForeColor = System.Drawing.Color.White;
            this.DelayLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelayLbl.Location = new System.Drawing.Point(705, 388);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(25, 20);
            this.DelayLbl.TabIndex = 6340;
            this.DelayLbl.Text = "0s";
            // 
            // TokensLbl
            // 
            this.TokensLbl.AutoSize = true;
            this.TokensLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.TokensLbl.ForeColor = System.Drawing.Color.White;
            this.TokensLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TokensLbl.Location = new System.Drawing.Point(18, 37);
            this.TokensLbl.Name = "TokensLbl";
            this.TokensLbl.Size = new System.Drawing.Size(57, 17);
            this.TokensLbl.TabIndex = 1;
            this.TokensLbl.Text = "Tokens:";
            // 
            // ProxiesLbl
            // 
            this.ProxiesLbl.AutoSize = true;
            this.ProxiesLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.ProxiesLbl.ForeColor = System.Drawing.Color.White;
            this.ProxiesLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProxiesLbl.Location = new System.Drawing.Point(389, 37);
            this.ProxiesLbl.Name = "ProxiesLbl";
            this.ProxiesLbl.Size = new System.Drawing.Size(60, 17);
            this.ProxiesLbl.TabIndex = 6329;
            this.ProxiesLbl.Text = "Proxies:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(709, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(42, 25);
            this.CloseBtn.TabIndex = 6332;
            this.CloseBtn.Text = "r";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.HeadLbl.ForeColor = System.Drawing.Color.White;
            this.HeadLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HeadLbl.Location = new System.Drawing.Point(283, 3);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(212, 21);
            this.HeadLbl.TabIndex = 6333;
            this.HeadLbl.Text = "Tokens.rip Token Manager";
            this.HeadLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadLbl_MouseMove);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusLbl.Location = new System.Drawing.Point(28, 460);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(50, 17);
            this.StatusLbl.TabIndex = 6335;
            this.StatusLbl.Text = "Status:";
            // 
            // CurrentStatusLbl
            // 
            this.CurrentStatusLbl.AutoSize = true;
            this.CurrentStatusLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.CurrentStatusLbl.ForeColor = System.Drawing.Color.White;
            this.CurrentStatusLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentStatusLbl.Location = new System.Drawing.Point(75, 460);
            this.CurrentStatusLbl.Name = "CurrentStatusLbl";
            this.CurrentStatusLbl.Size = new System.Drawing.Size(45, 17);
            this.CurrentStatusLbl.TabIndex = 6337;
            this.CurrentStatusLbl.Text = "Idling";
            // 
            // DelayBar
            // 
            this.DelayBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.DelayBar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.DelayBar.HoverState.Parent = this.DelayBar;
            this.DelayBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.DelayBar.Location = new System.Drawing.Point(392, 381);
            this.DelayBar.Maximum = 120;
            this.DelayBar.Name = "DelayBar";
            this.DelayBar.Size = new System.Drawing.Size(307, 37);
            this.DelayBar.TabIndex = 6347;
            this.DelayBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.DelayBar.Value = 0;
            this.DelayBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DelayBar_Scroll);
            // 
            // BypassServerVerifyLbl
            // 
            this.BypassServerVerifyLbl.AutoSize = true;
            this.BypassServerVerifyLbl.ForeColor = System.Drawing.Color.White;
            this.BypassServerVerifyLbl.Location = new System.Drawing.Point(28, 9);
            this.BypassServerVerifyLbl.Name = "BypassServerVerifyLbl";
            this.BypassServerVerifyLbl.Size = new System.Drawing.Size(130, 13);
            this.BypassServerVerifyLbl.TabIndex = 6345;
            this.BypassServerVerifyLbl.Text = "Bypass Server Verification";
            this.BypassServerVerifyLbl.Click += new System.EventHandler(this.BypassServerVerifyLbl_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ServerVerificationBtn);
            this.panel3.Controls.Add(this.BypassServerVerifyLbl);
            this.panel3.Location = new System.Drawing.Point(26, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 30);
            this.panel3.TabIndex = 6341;
            // 
            // ServerVerificationBtn
            // 
            this.ServerVerificationBtn.Animated = true;
            this.ServerVerificationBtn.AutoRoundedCorners = true;
            this.ServerVerificationBtn.BorderRadius = 9;
            this.ServerVerificationBtn.CheckedState.Parent = this.ServerVerificationBtn;
            this.ServerVerificationBtn.CustomImages.Parent = this.ServerVerificationBtn;
            this.ServerVerificationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ServerVerificationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ServerVerificationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ServerVerificationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ServerVerificationBtn.DisabledState.Parent = this.ServerVerificationBtn;
            this.ServerVerificationBtn.FillColor = System.Drawing.Color.White;
            this.ServerVerificationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerVerificationBtn.ForeColor = System.Drawing.Color.White;
            this.ServerVerificationBtn.HoverState.Parent = this.ServerVerificationBtn;
            this.ServerVerificationBtn.Location = new System.Drawing.Point(3, 5);
            this.ServerVerificationBtn.Name = "ServerVerificationBtn";
            this.ServerVerificationBtn.ShadowDecoration.Parent = this.ServerVerificationBtn;
            this.ServerVerificationBtn.Size = new System.Drawing.Size(20, 20);
            this.ServerVerificationBtn.TabIndex = 6348;
            this.ServerVerificationBtn.Click += new System.EventHandler(this.ServerVerificationBtn_Click);
            // 
            // InviteTxtbox
            // 
            this.InviteTxtbox.AutoRoundedCorners = true;
            this.InviteTxtbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.InviteTxtbox.BorderRadius = 14;
            this.InviteTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InviteTxtbox.DefaultText = "";
            this.InviteTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InviteTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InviteTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InviteTxtbox.DisabledState.Parent = this.InviteTxtbox;
            this.InviteTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InviteTxtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.InviteTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.InviteTxtbox.FocusedState.Parent = this.InviteTxtbox;
            this.InviteTxtbox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InviteTxtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.InviteTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.InviteTxtbox.HoverState.Parent = this.InviteTxtbox;
            this.InviteTxtbox.Location = new System.Drawing.Point(21, 381);
            this.InviteTxtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InviteTxtbox.MaxLength = 2147483647;
            this.InviteTxtbox.Name = "InviteTxtbox";
            this.InviteTxtbox.PasswordChar = '\0';
            this.InviteTxtbox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.InviteTxtbox.PlaceholderText = "Enter Invite";
            this.InviteTxtbox.SelectedText = "";
            this.InviteTxtbox.ShadowDecoration.Parent = this.InviteTxtbox;
            this.InviteTxtbox.Size = new System.Drawing.Size(337, 30);
            this.InviteTxtbox.TabIndex = 6350;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProxiesRichTxt);
            this.panel2.Location = new System.Drawing.Point(392, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 310);
            this.panel2.TabIndex = 1;
            // 
            // ProxiesRichTxt
            // 
            this.ProxiesRichTxt.AllowDrop = true;
            this.ProxiesRichTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ProxiesRichTxt.BorderRadius = 22;
            this.ProxiesRichTxt.BorderThickness = 2;
            this.ProxiesRichTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProxiesRichTxt.DefaultText = "";
            this.ProxiesRichTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProxiesRichTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProxiesRichTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProxiesRichTxt.DisabledState.Parent = this.ProxiesRichTxt;
            this.ProxiesRichTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProxiesRichTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ProxiesRichTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ProxiesRichTxt.FocusedState.Parent = this.ProxiesRichTxt;
            this.ProxiesRichTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ProxiesRichTxt.ForeColor = System.Drawing.Color.White;
            this.ProxiesRichTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ProxiesRichTxt.HoverState.Parent = this.ProxiesRichTxt;
            this.ProxiesRichTxt.Location = new System.Drawing.Point(0, 0);
            this.ProxiesRichTxt.MaxLength = 2147483647;
            this.ProxiesRichTxt.Multiline = true;
            this.ProxiesRichTxt.Name = "ProxiesRichTxt";
            this.ProxiesRichTxt.PasswordChar = '\0';
            this.ProxiesRichTxt.PlaceholderForeColor = System.Drawing.Color.White;
            this.ProxiesRichTxt.PlaceholderText = "";
            this.ProxiesRichTxt.SelectedText = "";
            this.ProxiesRichTxt.ShadowDecoration.Depth = 0;
            this.ProxiesRichTxt.ShadowDecoration.Parent = this.ProxiesRichTxt;
            this.ProxiesRichTxt.Size = new System.Drawing.Size(338, 310);
            this.ProxiesRichTxt.TabIndex = 0;
            this.ProxiesRichTxt.DragDrop += new System.Windows.Forms.DragEventHandler(this.ProxiesRichTxt_DragDrop);
            this.ProxiesRichTxt.DragEnter += new System.Windows.Forms.DragEventHandler(this.ProxiesRichTxt_DragEnter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CaptchaBot);
            this.panel4.Controls.Add(this.BypassServerVerifyBotLbl);
            this.panel4.Location = new System.Drawing.Point(193, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 30);
            this.panel4.TabIndex = 6351;
            // 
            // CaptchaBot
            // 
            this.CaptchaBot.Animated = true;
            this.CaptchaBot.AutoRoundedCorners = true;
            this.CaptchaBot.BorderRadius = 9;
            this.CaptchaBot.CheckedState.Parent = this.CaptchaBot;
            this.CaptchaBot.CustomImages.Parent = this.CaptchaBot;
            this.CaptchaBot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CaptchaBot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CaptchaBot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CaptchaBot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CaptchaBot.DisabledState.Parent = this.CaptchaBot;
            this.CaptchaBot.FillColor = System.Drawing.Color.White;
            this.CaptchaBot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CaptchaBot.ForeColor = System.Drawing.Color.White;
            this.CaptchaBot.HoverState.Parent = this.CaptchaBot;
            this.CaptchaBot.Location = new System.Drawing.Point(3, 5);
            this.CaptchaBot.Name = "CaptchaBot";
            this.CaptchaBot.ShadowDecoration.Parent = this.CaptchaBot;
            this.CaptchaBot.Size = new System.Drawing.Size(20, 20);
            this.CaptchaBot.TabIndex = 6349;
            this.CaptchaBot.Click += new System.EventHandler(this.CaptchaBot_Click);
            // 
            // BypassServerVerifyBotLbl
            // 
            this.BypassServerVerifyBotLbl.AutoSize = true;
            this.BypassServerVerifyBotLbl.ForeColor = System.Drawing.Color.White;
            this.BypassServerVerifyBotLbl.Location = new System.Drawing.Point(28, 9);
            this.BypassServerVerifyBotLbl.Name = "BypassServerVerifyBotLbl";
            this.BypassServerVerifyBotLbl.Size = new System.Drawing.Size(137, 13);
            this.BypassServerVerifyBotLbl.TabIndex = 6345;
            this.BypassServerVerifyBotLbl.Text = "Bypass Server Captcha Bot";
            this.BypassServerVerifyBotLbl.Click += new System.EventHandler(this.BypassServerVerifyBotLbl_Click);
            // 
            // RainbowPnlUp
            // 
            this.RainbowPnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.RainbowPnlUp.Location = new System.Drawing.Point(259, 23);
            this.RainbowPnlUp.Name = "RainbowPnlUp";
            this.RainbowPnlUp.Size = new System.Drawing.Size(250, 2);
            this.RainbowPnlUp.TabIndex = 6352;
            // 
            // MovePnl
            // 
            this.MovePnl.BackColor = System.Drawing.Color.Transparent;
            this.MovePnl.FillColor = System.Drawing.Color.Transparent;
            this.MovePnl.Location = new System.Drawing.Point(0, 0);
            this.MovePnl.Name = "MovePnl";
            this.MovePnl.ShadowColor = System.Drawing.Color.Black;
            this.MovePnl.ShadowDepth = 0;
            this.MovePnl.ShadowShift = 0;
            this.MovePnl.Size = new System.Drawing.Size(714, 24);
            this.MovePnl.TabIndex = 6353;
            this.MovePnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovePnl_MouseMove);
            // 
            // TknSettingsBtn
            // 
            this.TknSettingsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TknSettingsBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TknSettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TknSettingsBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.TknSettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TknSettingsBtn.Location = new System.Drawing.Point(585, 490);
            this.TknSettingsBtn.Name = "TknSettingsBtn";
            this.TknSettingsBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.TknSettingsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TknSettingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TknSettingsBtn.Size = new System.Drawing.Size(138, 30);
            this.TknSettingsBtn.TabIndex = 6339;
            this.TknSettingsBtn.Text = "Token Settings";
            this.TknSettingsBtn.TextColor = System.Drawing.Color.White;
            this.TknSettingsBtn.UseVisualStyleBackColor = true;
            this.TknSettingsBtn.Click += new System.EventHandler(this.TknSettingsBtn_Click);
            // 
            // frndBtn
            // 
            this.frndBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.frndBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.frndBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.frndBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.frndBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.frndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frndBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.frndBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.frndBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.frndBtn.Location = new System.Drawing.Point(447, 490);
            this.frndBtn.Name = "frndBtn";
            this.frndBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.frndBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.frndBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.frndBtn.Size = new System.Drawing.Size(132, 30);
            this.frndBtn.TabIndex = 6342;
            this.frndBtn.Text = "Friend Options";
            this.frndBtn.TextColor = System.Drawing.Color.White;
            this.frndBtn.UseVisualStyleBackColor = true;
            this.frndBtn.Click += new System.EventHandler(this.frndBtn_Click);
            // 
            // JoinBtn
            // 
            this.JoinBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.JoinBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.JoinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.JoinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.JoinBtn.Location = new System.Drawing.Point(25, 490);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.JoinBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.JoinBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.JoinBtn.Size = new System.Drawing.Size(131, 30);
            this.JoinBtn.TabIndex = 6326;
            this.JoinBtn.Text = "Join";
            this.JoinBtn.TextColor = System.Drawing.Color.White;
            this.JoinBtn.UseVisualStyleBackColor = true;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.LeaveBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.LeaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.LeaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.LeaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.LeaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.LeaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.LeaveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LeaveBtn.Location = new System.Drawing.Point(162, 490);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.LeaveBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LeaveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.LeaveBtn.Size = new System.Drawing.Size(131, 30);
            this.LeaveBtn.TabIndex = 6343;
            this.LeaveBtn.Text = "Leave";
            this.LeaveBtn.TextColor = System.Drawing.Color.White;
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // ChkTknPrxBtn
            // 
            this.ChkTknPrxBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChkTknPrxBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ChkTknPrxBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkTknPrxBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.ChkTknPrxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkTknPrxBtn.Location = new System.Drawing.Point(299, 490);
            this.ChkTknPrxBtn.Name = "ChkTknPrxBtn";
            this.ChkTknPrxBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.ChkTknPrxBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ChkTknPrxBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ChkTknPrxBtn.Size = new System.Drawing.Size(142, 30);
            this.ChkTknPrxBtn.TabIndex = 6338;
            this.ChkTknPrxBtn.Text = "Check";
            this.ChkTknPrxBtn.TextColor = System.Drawing.Color.White;
            this.ChkTknPrxBtn.UseVisualStyleBackColor = true;
            this.ChkTknPrxBtn.Click += new System.EventHandler(this.ChkTknPrx_Click);
            // 
            // TokenManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 543);
            this.Controls.Add(this.RainbowPnlUp);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DelayLbl);
            this.Controls.Add(this.DelayBar);
            this.Controls.Add(this.InviteTxtbox);
            this.Controls.Add(this.TknSettingsBtn);
            this.Controls.Add(this.frndBtn);
            this.Controls.Add(this.JoinBtn);
            this.Controls.Add(this.LeaveBtn);
            this.Controls.Add(this.ChkTknPrxBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.CurrentStatusLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ProxiesLbl);
            this.Controls.Add(this.TokensLbl);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MovePnl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TokenManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tokens.rip Token Manager";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private RoundBtn JoinBtn;
        private System.Windows.Forms.Label TokensLbl;
        private System.Windows.Forms.Label ProxiesLbl;
        private System.Windows.Forms.Timer RainbowTimer;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label CurrentStatusLbl;
        private RoundBtn ChkTknPrxBtn;
        private System.Windows.Forms.Timer CountToken;
        private RoundBtn TknSettingsBtn;
        private System.Windows.Forms.Label DelayLbl;
        private RoundBtn frndBtn;
        private RoundBtn LeaveBtn;
        private System.Windows.Forms.Label BypassServerVerifyLbl;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TrackBar DelayBar;
        private Guna.UI2.WinForms.Guna2TextBox InviteTxtbox;
        private Guna.UI2.WinForms.Guna2Button ServerVerificationBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox TokensRichTxt;
        private Guna.UI2.WinForms.Guna2TextBox ProxiesRichTxt;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button CaptchaBot;
        private System.Windows.Forms.Label BypassServerVerifyBotLbl;
        private System.Windows.Forms.Panel RainbowPnlUp;
        private Guna.UI2.WinForms.Guna2ShadowPanel MovePnl;
    }
}

