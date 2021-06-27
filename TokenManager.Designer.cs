
namespace Tokens.rip_Token_Manager
{
    partial class TokenSettingsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenSettingsFrm));
            this.PictureBoxPnl = new System.Windows.Forms.Panel();
            this.PictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LgnTknTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RainbowPnlUp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RandomizeUsernameBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RandomUsernameLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RandomizePfpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RandomPfpLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DefaultBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DefaultLbl = new System.Windows.Forms.Label();
            this.btnPnl = new Guna.UI2.WinForms.Guna2Panel();
            this.SendOnlineBtn = new RoundBtn();
            this.TokenLgnBtn = new RoundBtn();
            this.ChangeUserName = new RoundBtn();
            this.PictureBoxPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.txtboxPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.btnPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxPnl
            // 
            this.PictureBoxPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxPnl.Controls.Add(this.PictureBox);
            this.PictureBoxPnl.Location = new System.Drawing.Point(15, 3);
            this.PictureBoxPnl.Name = "PictureBoxPnl";
            this.PictureBoxPnl.Size = new System.Drawing.Size(167, 137);
            this.PictureBoxPnl.TabIndex = 1;
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.PictureBox.Image = global::Tokens.rip_Token_Manager.Properties.Resources.image0;
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(0, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBox.ShadowDecoration.Parent = this.PictureBox;
            this.PictureBox.Size = new System.Drawing.Size(167, 134);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 6352;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.HeadLbl.ForeColor = System.Drawing.Color.White;
            this.HeadLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HeadLbl.Location = new System.Drawing.Point(244, 3);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(123, 21);
            this.HeadLbl.TabIndex = 6336;
            this.HeadLbl.Text = "Token Settings";
            this.HeadLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadLbl_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(544, -1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(38, 25);
            this.CloseBtn.TabIndex = 6335;
            this.CloseBtn.Text = "r";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LgnTknTxt
            // 
            this.LgnTknTxt.AutoRoundedCorners = true;
            this.LgnTknTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.LgnTknTxt.BorderRadius = 14;
            this.LgnTknTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LgnTknTxt.DefaultText = "";
            this.LgnTknTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LgnTknTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LgnTknTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LgnTknTxt.DisabledState.Parent = this.LgnTknTxt;
            this.LgnTknTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LgnTknTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.LgnTknTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.LgnTknTxt.FocusedState.Parent = this.LgnTknTxt;
            this.LgnTknTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgnTknTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.LgnTknTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.LgnTknTxt.HoverState.Parent = this.LgnTknTxt;
            this.LgnTknTxt.Location = new System.Drawing.Point(18, 230);
            this.LgnTknTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LgnTknTxt.MaxLength = 2147483647;
            this.LgnTknTxt.Name = "LgnTknTxt";
            this.LgnTknTxt.PasswordChar = '\0';
            this.LgnTknTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.LgnTknTxt.PlaceholderText = "Enter Token";
            this.LgnTknTxt.SelectedText = "";
            this.LgnTknTxt.ShadowDecoration.Parent = this.LgnTknTxt;
            this.LgnTknTxt.Size = new System.Drawing.Size(299, 30);
            this.LgnTknTxt.TabIndex = 6351;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.AutoRoundedCorners = true;
            this.UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.UsernameTxt.BorderRadius = 14;
            this.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxt.DefaultText = "";
            this.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.DisabledState.Parent = this.UsernameTxt;
            this.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.UsernameTxt.FocusedState.Parent = this.UsernameTxt;
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.UsernameTxt.HoverState.Parent = this.UsernameTxt;
            this.UsernameTxt.Location = new System.Drawing.Point(18, 30);
            this.UsernameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsernameTxt.MaxLength = 2147483647;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PasswordChar = '\0';
            this.UsernameTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTxt.PlaceholderText = "Enter New Username";
            this.UsernameTxt.SelectedText = "";
            this.UsernameTxt.ShadowDecoration.Parent = this.UsernameTxt;
            this.UsernameTxt.Size = new System.Drawing.Size(299, 30);
            this.UsernameTxt.TabIndex = 6352;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoRoundedCorners = true;
            this.PasswordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.PasswordTxt.BorderRadius = 14;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.Parent = this.PasswordTxt;
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.PasswordTxt.FocusedState.Parent = this.PasswordTxt;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.PasswordTxt.HoverState.Parent = this.PasswordTxt;
            this.PasswordTxt.Location = new System.Drawing.Point(18, 76);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordTxt.MaxLength = 2147483647;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '\0';
            this.PasswordTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTxt.PlaceholderText = "Enter Password";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.ShadowDecoration.Parent = this.PasswordTxt;
            this.PasswordTxt.Size = new System.Drawing.Size(299, 30);
            this.PasswordTxt.TabIndex = 6353;
            // 
            // RainbowPnlUp
            // 
            this.RainbowPnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.RainbowPnlUp.Enabled = false;
            this.RainbowPnlUp.Location = new System.Drawing.Point(221, 22);
            this.RainbowPnlUp.Name = "RainbowPnlUp";
            this.RainbowPnlUp.Size = new System.Drawing.Size(170, 2);
            this.RainbowPnlUp.TabIndex = 6355;
            this.RainbowPnlUp.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 25);
            this.panel1.TabIndex = 6356;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // txtboxPnl
            // 
            this.txtboxPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.txtboxPnl.BorderRadius = 20;
            this.txtboxPnl.BorderThickness = 2;
            this.txtboxPnl.Controls.Add(this.panel3);
            this.txtboxPnl.Controls.Add(this.panel2);
            this.txtboxPnl.Controls.Add(this.panel4);
            this.txtboxPnl.Controls.Add(this.LgnTknTxt);
            this.txtboxPnl.Controls.Add(this.PasswordTxt);
            this.txtboxPnl.Controls.Add(this.UsernameTxt);
            this.txtboxPnl.Location = new System.Drawing.Point(12, 42);
            this.txtboxPnl.Name = "txtboxPnl";
            this.txtboxPnl.ShadowDecoration.Parent = this.txtboxPnl;
            this.txtboxPnl.Size = new System.Drawing.Size(336, 275);
            this.txtboxPnl.TabIndex = 6357;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RandomizeUsernameBtn);
            this.panel3.Controls.Add(this.RandomUsernameLbl);
            this.panel3.Location = new System.Drawing.Point(19, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 30);
            this.panel3.TabIndex = 6356;
            // 
            // RandomizeUsernameBtn
            // 
            this.RandomizeUsernameBtn.Animated = true;
            this.RandomizeUsernameBtn.AutoRoundedCorners = true;
            this.RandomizeUsernameBtn.BorderRadius = 9;
            this.RandomizeUsernameBtn.CheckedState.Parent = this.RandomizeUsernameBtn;
            this.RandomizeUsernameBtn.CustomImages.Parent = this.RandomizeUsernameBtn;
            this.RandomizeUsernameBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RandomizeUsernameBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RandomizeUsernameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RandomizeUsernameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RandomizeUsernameBtn.DisabledState.Parent = this.RandomizeUsernameBtn;
            this.RandomizeUsernameBtn.FillColor = System.Drawing.Color.White;
            this.RandomizeUsernameBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RandomizeUsernameBtn.ForeColor = System.Drawing.Color.White;
            this.RandomizeUsernameBtn.HoverState.Parent = this.RandomizeUsernameBtn;
            this.RandomizeUsernameBtn.Location = new System.Drawing.Point(3, 5);
            this.RandomizeUsernameBtn.Name = "RandomizeUsernameBtn";
            this.RandomizeUsernameBtn.ShadowDecoration.Parent = this.RandomizeUsernameBtn;
            this.RandomizeUsernameBtn.Size = new System.Drawing.Size(20, 20);
            this.RandomizeUsernameBtn.TabIndex = 6349;
            this.RandomizeUsernameBtn.Click += new System.EventHandler(this.RandomizeUsernameBtn_Click);
            // 
            // RandomUsernameLbl
            // 
            this.RandomUsernameLbl.AutoSize = true;
            this.RandomUsernameLbl.ForeColor = System.Drawing.Color.White;
            this.RandomUsernameLbl.Location = new System.Drawing.Point(28, 9);
            this.RandomUsernameLbl.Name = "RandomUsernameLbl";
            this.RandomUsernameLbl.Size = new System.Drawing.Size(111, 13);
            this.RandomUsernameLbl.TabIndex = 6345;
            this.RandomUsernameLbl.Text = "Randomize Username";
            this.RandomUsernameLbl.Click += new System.EventHandler(this.RandomUsernameLbl_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RandomizePfpBtn);
            this.panel2.Controls.Add(this.RandomPfpLbl);
            this.panel2.Location = new System.Drawing.Point(19, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 30);
            this.panel2.TabIndex = 6355;
            // 
            // RandomizePfpBtn
            // 
            this.RandomizePfpBtn.Animated = true;
            this.RandomizePfpBtn.AutoRoundedCorners = true;
            this.RandomizePfpBtn.BorderRadius = 9;
            this.RandomizePfpBtn.CheckedState.Parent = this.RandomizePfpBtn;
            this.RandomizePfpBtn.CustomImages.Parent = this.RandomizePfpBtn;
            this.RandomizePfpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RandomizePfpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RandomizePfpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RandomizePfpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RandomizePfpBtn.DisabledState.Parent = this.RandomizePfpBtn;
            this.RandomizePfpBtn.FillColor = System.Drawing.Color.White;
            this.RandomizePfpBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RandomizePfpBtn.ForeColor = System.Drawing.Color.White;
            this.RandomizePfpBtn.HoverState.Parent = this.RandomizePfpBtn;
            this.RandomizePfpBtn.Location = new System.Drawing.Point(3, 5);
            this.RandomizePfpBtn.Name = "RandomizePfpBtn";
            this.RandomizePfpBtn.ShadowDecoration.Parent = this.RandomizePfpBtn;
            this.RandomizePfpBtn.Size = new System.Drawing.Size(20, 20);
            this.RandomizePfpBtn.TabIndex = 6349;
            this.RandomizePfpBtn.Click += new System.EventHandler(this.RandomizePfpBtn_Click);
            // 
            // RandomPfpLbl
            // 
            this.RandomPfpLbl.AutoSize = true;
            this.RandomPfpLbl.ForeColor = System.Drawing.Color.White;
            this.RandomPfpLbl.Location = new System.Drawing.Point(28, 9);
            this.RandomPfpLbl.Name = "RandomPfpLbl";
            this.RandomPfpLbl.Size = new System.Drawing.Size(128, 13);
            this.RandomPfpLbl.TabIndex = 6345;
            this.RandomPfpLbl.Text = "Randomize Profile Picture";
            this.RandomPfpLbl.Click += new System.EventHandler(this.RandomPfpLbl_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DefaultBtn);
            this.panel4.Controls.Add(this.DefaultLbl);
            this.panel4.Location = new System.Drawing.Point(19, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 30);
            this.panel4.TabIndex = 6354;
            // 
            // DefaultBtn
            // 
            this.DefaultBtn.Animated = true;
            this.DefaultBtn.AutoRoundedCorners = true;
            this.DefaultBtn.BorderRadius = 9;
            this.DefaultBtn.CheckedState.Parent = this.DefaultBtn;
            this.DefaultBtn.CustomImages.Parent = this.DefaultBtn;
            this.DefaultBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DefaultBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DefaultBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DefaultBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DefaultBtn.DisabledState.Parent = this.DefaultBtn;
            this.DefaultBtn.FillColor = System.Drawing.Color.White;
            this.DefaultBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DefaultBtn.ForeColor = System.Drawing.Color.White;
            this.DefaultBtn.HoverState.Parent = this.DefaultBtn;
            this.DefaultBtn.Location = new System.Drawing.Point(3, 5);
            this.DefaultBtn.Name = "DefaultBtn";
            this.DefaultBtn.ShadowDecoration.Parent = this.DefaultBtn;
            this.DefaultBtn.Size = new System.Drawing.Size(20, 20);
            this.DefaultBtn.TabIndex = 6349;
            // 
            // DefaultLbl
            // 
            this.DefaultLbl.AutoSize = true;
            this.DefaultLbl.ForeColor = System.Drawing.Color.White;
            this.DefaultLbl.Location = new System.Drawing.Point(28, 9);
            this.DefaultLbl.Name = "DefaultLbl";
            this.DefaultLbl.Size = new System.Drawing.Size(148, 13);
            this.DefaultLbl.TabIndex = 6345;
            this.DefaultLbl.Text = "Default Preloaded Usernames";
            // 
            // btnPnl
            // 
            this.btnPnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.btnPnl.BorderRadius = 20;
            this.btnPnl.BorderThickness = 2;
            this.btnPnl.Controls.Add(this.SendOnlineBtn);
            this.btnPnl.Controls.Add(this.TokenLgnBtn);
            this.btnPnl.Controls.Add(this.ChangeUserName);
            this.btnPnl.Controls.Add(this.PictureBoxPnl);
            this.btnPnl.Location = new System.Drawing.Point(367, 42);
            this.btnPnl.Name = "btnPnl";
            this.btnPnl.ShadowDecoration.Parent = this.btnPnl;
            this.btnPnl.Size = new System.Drawing.Size(200, 275);
            this.btnPnl.TabIndex = 6358;
            // 
            // SendOnlineBtn
            // 
            this.SendOnlineBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.SendOnlineBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.SendOnlineBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SendOnlineBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SendOnlineBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SendOnlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendOnlineBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.SendOnlineBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.SendOnlineBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SendOnlineBtn.Location = new System.Drawing.Point(15, 161);
            this.SendOnlineBtn.Name = "SendOnlineBtn";
            this.SendOnlineBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.SendOnlineBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.SendOnlineBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SendOnlineBtn.Size = new System.Drawing.Size(167, 29);
            this.SendOnlineBtn.TabIndex = 6344;
            this.SendOnlineBtn.Text = "Send All Online";
            this.SendOnlineBtn.TextColor = System.Drawing.Color.White;
            this.SendOnlineBtn.UseVisualStyleBackColor = true;
            this.SendOnlineBtn.Click += new System.EventHandler(this.SendOnlineBtn_click);
            // 
            // TokenLgnBtn
            // 
            this.TokenLgnBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TokenLgnBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokenLgnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TokenLgnBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.TokenLgnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TokenLgnBtn.Location = new System.Drawing.Point(15, 231);
            this.TokenLgnBtn.Name = "TokenLgnBtn";
            this.TokenLgnBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.TokenLgnBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokenLgnBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TokenLgnBtn.Size = new System.Drawing.Size(167, 29);
            this.TokenLgnBtn.TabIndex = 6343;
            this.TokenLgnBtn.Text = "Login Into Token";
            this.TokenLgnBtn.TextColor = System.Drawing.Color.White;
            this.TokenLgnBtn.UseVisualStyleBackColor = true;
            this.TokenLgnBtn.Click += new System.EventHandler(this.TokenLgnBtn_Click);
            // 
            // ChangeUserName
            // 
            this.ChangeUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChangeUserName.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ChangeUserName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChangeUserName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChangeUserName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChangeUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeUserName.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.ChangeUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChangeUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChangeUserName.Location = new System.Drawing.Point(15, 196);
            this.ChangeUserName.Name = "ChangeUserName";
            this.ChangeUserName.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.ChangeUserName.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ChangeUserName.OnHoverTextColor = System.Drawing.Color.White;
            this.ChangeUserName.Size = new System.Drawing.Size(167, 29);
            this.ChangeUserName.TabIndex = 6342;
            this.ChangeUserName.Text = "Change Username";
            this.ChangeUserName.TextColor = System.Drawing.Color.White;
            this.ChangeUserName.UseVisualStyleBackColor = true;
            this.ChangeUserName.Click += new System.EventHandler(this.ChangeUserName_Click);
            // 
            // TokenSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(579, 337);
            this.Controls.Add(this.RainbowPnlUp);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxPnl);
            this.Controls.Add(this.btnPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TokenSettingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Settings";
            this.PictureBoxPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.txtboxPnl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.btnPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PictureBoxPnl;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Button CloseBtn;
        private RoundBtn ChangeUserName;
        private RoundBtn TokenLgnBtn;
        private RoundBtn SendOnlineBtn;
        private Guna.UI2.WinForms.Guna2TextBox LgnTknTxt;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBox;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private System.Windows.Forms.Panel RainbowPnlUp;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel txtboxPnl;
        private Guna.UI2.WinForms.Guna2Panel btnPnl;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button RandomizeUsernameBtn;
        private System.Windows.Forms.Label RandomUsernameLbl;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button RandomizePfpBtn;
        private System.Windows.Forms.Label RandomPfpLbl;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button DefaultBtn;
        private System.Windows.Forms.Label DefaultLbl;
    }
}