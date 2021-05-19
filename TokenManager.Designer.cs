
namespace Itroublve_Joiner_v3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenSettingsFrm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBoxPnl = new System.Windows.Forms.Panel();
            this.RainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.HeadLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.RainbowPnlUp = new System.Windows.Forms.Panel();
            this.RainbowPnlDown = new System.Windows.Forms.Panel();
            this.EmailPnl = new System.Windows.Forms.Panel();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LgnTknTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.TokenLgnBtn = new RoundBtn();
            this.ApplyToTokenBtn = new RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.PictureBoxPnl.SuspendLayout();
            this.EmailPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(161, 129);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // PictureBoxPnl
            // 
            this.PictureBoxPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxPnl.Controls.Add(this.PictureBox);
            this.PictureBoxPnl.Location = new System.Drawing.Point(382, 60);
            this.PictureBoxPnl.Name = "PictureBoxPnl";
            this.PictureBoxPnl.Size = new System.Drawing.Size(167, 135);
            this.PictureBoxPnl.TabIndex = 1;
            // 
            // RainbowTimer
            // 
            this.RainbowTimer.Tick += new System.EventHandler(this.RainbowTimer_Tick);
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
            // RainbowPnlUp
            // 
            this.RainbowPnlUp.Location = new System.Drawing.Point(-73, 24);
            this.RainbowPnlUp.Name = "RainbowPnlUp";
            this.RainbowPnlUp.Size = new System.Drawing.Size(682, 2);
            this.RainbowPnlUp.TabIndex = 6334;
            // 
            // RainbowPnlDown
            // 
            this.RainbowPnlDown.Location = new System.Drawing.Point(-66, 354);
            this.RainbowPnlDown.Name = "RainbowPnlDown";
            this.RainbowPnlDown.Size = new System.Drawing.Size(711, 3);
            this.RainbowPnlDown.TabIndex = 6337;
            // 
            // EmailPnl
            // 
            this.EmailPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.EmailPnl.Controls.Add(this.EmailTxtBox);
            this.EmailPnl.Location = new System.Drawing.Point(12, 60);
            this.EmailPnl.Name = "EmailPnl";
            this.EmailPnl.Size = new System.Drawing.Size(299, 41);
            this.EmailPnl.TabIndex = 6338;
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.EmailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTxtBox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.EmailTxtBox.ForeColor = System.Drawing.Color.DarkGray;
            this.EmailTxtBox.Location = new System.Drawing.Point(5, 12);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(291, 18);
            this.EmailTxtBox.TabIndex = 6327;
            this.EmailTxtBox.Text = "Enter Email";
            this.EmailTxtBox.Enter += new System.EventHandler(this.EmailTxtBox_Enter);
            this.EmailTxtBox.Leave += new System.EventHandler(this.EmailTxtBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.PasswordTxt);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 41);
            this.panel1.TabIndex = 6339;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.PasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.PasswordTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTxt.Location = new System.Drawing.Point(5, 12);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(291, 18);
            this.PasswordTxt.TabIndex = 6327;
            this.PasswordTxt.Text = "Enter Password";
            this.PasswordTxt.Enter += new System.EventHandler(this.textBox1_Enter);
            this.PasswordTxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.LgnTknTxt);
            this.panel2.Location = new System.Drawing.Point(12, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 41);
            this.panel2.TabIndex = 6341;
            // 
            // LgnTknTxt
            // 
            this.LgnTknTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.LgnTknTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LgnTknTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.LgnTknTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.LgnTknTxt.Location = new System.Drawing.Point(5, 12);
            this.LgnTknTxt.Name = "LgnTknTxt";
            this.LgnTknTxt.Size = new System.Drawing.Size(335, 18);
            this.LgnTknTxt.TabIndex = 6327;
            this.LgnTknTxt.Text = "Token";
            this.LgnTknTxt.Enter += new System.EventHandler(this.LgnTknTxt_Enter);
            this.LgnTknTxt.Leave += new System.EventHandler(this.LgnTknTxt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.UsernameTxt);
            this.panel3.Location = new System.Drawing.Point(12, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 41);
            this.panel3.TabIndex = 6340;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.UsernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.UsernameTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.UsernameTxt.Location = new System.Drawing.Point(5, 12);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(291, 18);
            this.UsernameTxt.TabIndex = 6327;
            this.UsernameTxt.Text = "Enter New Username";
            this.UsernameTxt.Enter += new System.EventHandler(this.textBox3_Enter);
            this.UsernameTxt.Leave += new System.EventHandler(this.UsernameTxt_Leave);
            // 
            // TokenLgnBtn
            // 
            this.TokenLgnBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TokenLgnBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TokenLgnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TokenLgnBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.TokenLgnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TokenLgnBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TokenLgnBtn.Location = new System.Drawing.Point(382, 308);
            this.TokenLgnBtn.Name = "TokenLgnBtn";
            this.TokenLgnBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.TokenLgnBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.TokenLgnBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TokenLgnBtn.Size = new System.Drawing.Size(167, 29);
            this.TokenLgnBtn.TabIndex = 6343;
            this.TokenLgnBtn.Text = "Login Into Token";
            this.TokenLgnBtn.TextColor = System.Drawing.Color.White;
            this.TokenLgnBtn.UseVisualStyleBackColor = true;
            this.TokenLgnBtn.Click += new System.EventHandler(this.TokenLgnBtn_Click);
            // 
            // ApplyToTokenBtn
            // 
            this.ApplyToTokenBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ApplyToTokenBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ApplyToTokenBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ApplyToTokenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ApplyToTokenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ApplyToTokenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyToTokenBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.ApplyToTokenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ApplyToTokenBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ApplyToTokenBtn.Location = new System.Drawing.Point(382, 273);
            this.ApplyToTokenBtn.Name = "ApplyToTokenBtn";
            this.ApplyToTokenBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.ApplyToTokenBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.ApplyToTokenBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ApplyToTokenBtn.Size = new System.Drawing.Size(167, 29);
            this.ApplyToTokenBtn.TabIndex = 6342;
            this.ApplyToTokenBtn.Text = "Apply To Token";
            this.ApplyToTokenBtn.TextColor = System.Drawing.Color.White;
            this.ApplyToTokenBtn.UseVisualStyleBackColor = true;
            this.ApplyToTokenBtn.Click += new System.EventHandler(this.ApplyToTokenBtn_Click);
            // 
            // TokenSettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(579, 369);
            this.Controls.Add(this.TokenLgnBtn);
            this.Controls.Add(this.ApplyToTokenBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EmailPnl);
            this.Controls.Add(this.RainbowPnlDown);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RainbowPnlUp);
            this.Controls.Add(this.PictureBoxPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TokenSettingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Settings";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.PictureBoxPnl.ResumeLayout(false);
            this.EmailPnl.ResumeLayout(false);
            this.EmailPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel PictureBoxPnl;
        private System.Windows.Forms.Timer RainbowTimer;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel RainbowPnlUp;
        private System.Windows.Forms.Panel RainbowPnlDown;
        private System.Windows.Forms.Panel EmailPnl;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LgnTknTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox UsernameTxt;
        private RoundBtn ApplyToTokenBtn;
        private RoundBtn TokenLgnBtn;
    }
}