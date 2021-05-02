
namespace Itroublve_Joiner_v3
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
            this.TokensRichTxt = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProxiesRichTxt = new System.Windows.Forms.RichTextBox();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.TokensLbl = new System.Windows.Forms.Label();
            this.ProxiesLbl = new System.Windows.Forms.Label();
            this.RainbowPnlUp = new System.Windows.Forms.Panel();
            this.RainbowTimer = new System.Windows.Forms.Timer(this.components);
            this.RainbowPnlDown = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.InvitePnl = new System.Windows.Forms.Panel();
            this.InviteTxtbox = new System.Windows.Forms.TextBox();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.CurrentStatusLbl = new System.Windows.Forms.Label();
            this.CountToken = new System.Windows.Forms.Timer(this.components);
            this.DelayBar = new System.Windows.Forms.TrackBar();
            this.TrackBarPnl = new System.Windows.Forms.Panel();
            this.TknSettingsBtn = new RoundBtn();
            this.ChkTknPrxBtn = new RoundBtn();
            this.JoinBtn = new RoundBtn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InvitePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).BeginInit();
            this.TrackBarPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TokensRichTxt);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 311);
            this.panel1.TabIndex = 0;
            // 
            // TokensRichTxt
            // 
            this.TokensRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TokensRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokensRichTxt.DetectUrls = false;
            this.TokensRichTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TokensRichTxt.ForeColor = System.Drawing.Color.White;
            this.TokensRichTxt.Location = new System.Drawing.Point(0, 0);
            this.TokensRichTxt.Name = "TokensRichTxt";
            this.TokensRichTxt.Size = new System.Drawing.Size(299, 311);
            this.TokensRichTxt.TabIndex = 0;
            this.TokensRichTxt.Text = "";
            this.TokensRichTxt.TextChanged += new System.EventHandler(this.TokensRichTxt_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.Silver;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(555, 478);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(11, 10);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProxiesRichTxt);
            this.panel2.Location = new System.Drawing.Point(317, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 311);
            this.panel2.TabIndex = 1;
            // 
            // ProxiesRichTxt
            // 
            this.ProxiesRichTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ProxiesRichTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProxiesRichTxt.DetectUrls = false;
            this.ProxiesRichTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ProxiesRichTxt.ForeColor = System.Drawing.Color.White;
            this.ProxiesRichTxt.Location = new System.Drawing.Point(0, 0);
            this.ProxiesRichTxt.Name = "ProxiesRichTxt";
            this.ProxiesRichTxt.Size = new System.Drawing.Size(299, 311);
            this.ProxiesRichTxt.TabIndex = 1;
            this.ProxiesRichTxt.Text = "";
            // 
            // DelayLbl
            // 
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.DelayLbl.ForeColor = System.Drawing.Color.White;
            this.DelayLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelayLbl.Location = new System.Drawing.Point(260, 12);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(20, 17);
            this.DelayLbl.TabIndex = 6340;
            this.DelayLbl.Text = "1s";
            // 
            // TokensLbl
            // 
            this.TokensLbl.AutoSize = true;
            this.TokensLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.TokensLbl.ForeColor = System.Drawing.Color.White;
            this.TokensLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TokensLbl.Location = new System.Drawing.Point(9, 37);
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
            this.ProxiesLbl.Location = new System.Drawing.Point(314, 37);
            this.ProxiesLbl.Name = "ProxiesLbl";
            this.ProxiesLbl.Size = new System.Drawing.Size(60, 17);
            this.ProxiesLbl.TabIndex = 6329;
            this.ProxiesLbl.Text = "Proxies:";
            // 
            // RainbowPnlUp
            // 
            this.RainbowPnlUp.Location = new System.Drawing.Point(-27, 22);
            this.RainbowPnlUp.Name = "RainbowPnlUp";
            this.RainbowPnlUp.Size = new System.Drawing.Size(682, 2);
            this.RainbowPnlUp.TabIndex = 6330;
            // 
            // RainbowTimer
            // 
            this.RainbowTimer.Interval = 1;
            this.RainbowTimer.Tick += new System.EventHandler(this.RainbowTimer_Tick);
            // 
            // RainbowPnlDown
            // 
            this.RainbowPnlDown.Location = new System.Drawing.Point(-26, 523);
            this.RainbowPnlDown.Name = "RainbowPnlDown";
            this.RainbowPnlDown.Size = new System.Drawing.Size(711, 3);
            this.RainbowPnlDown.TabIndex = 6331;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(600, -3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 23);
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
            this.HeadLbl.Location = new System.Drawing.Point(204, 3);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(237, 21);
            this.HeadLbl.TabIndex = 6333;
            this.HeadLbl.Text = "Itroublve Token Management";
            this.HeadLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadLbl_MouseMove);
            // 
            // InvitePnl
            // 
            this.InvitePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.InvitePnl.Controls.Add(this.InviteTxtbox);
            this.InvitePnl.Location = new System.Drawing.Point(12, 374);
            this.InvitePnl.Name = "InvitePnl";
            this.InvitePnl.Size = new System.Drawing.Size(299, 41);
            this.InvitePnl.TabIndex = 6334;
            // 
            // InviteTxtbox
            // 
            this.InviteTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.InviteTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InviteTxtbox.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.InviteTxtbox.ForeColor = System.Drawing.Color.DarkGray;
            this.InviteTxtbox.Location = new System.Drawing.Point(5, 12);
            this.InviteTxtbox.Name = "InviteTxtbox";
            this.InviteTxtbox.Size = new System.Drawing.Size(291, 18);
            this.InviteTxtbox.TabIndex = 6327;
            this.InviteTxtbox.Text = "Enter Invite";
            this.InviteTxtbox.Enter += new System.EventHandler(this.InviteTxtbox_Enter);
            this.InviteTxtbox.Leave += new System.EventHandler(this.InviteTxtbox_Leave);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusLbl.Location = new System.Drawing.Point(12, 427);
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
            this.CurrentStatusLbl.Location = new System.Drawing.Point(59, 427);
            this.CurrentStatusLbl.Name = "CurrentStatusLbl";
            this.CurrentStatusLbl.Size = new System.Drawing.Size(45, 17);
            this.CurrentStatusLbl.TabIndex = 6337;
            this.CurrentStatusLbl.Text = "Idling";
            // 
            // CountToken
            // 
            this.CountToken.Tick += new System.EventHandler(this.CountToken_Tick);
            // 
            // DelayBar
            // 
            this.DelayBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelayBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelayBar.LargeChange = 1;
            this.DelayBar.Location = new System.Drawing.Point(5, 12);
            this.DelayBar.Minimum = 1;
            this.DelayBar.Name = "DelayBar";
            this.DelayBar.Size = new System.Drawing.Size(246, 45);
            this.DelayBar.TabIndex = 6340;
            this.DelayBar.Value = 1;
            this.DelayBar.Scroll += new System.EventHandler(this.DelayBar_Scroll);
            // 
            // TrackBarPnl
            // 
            this.TrackBarPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TrackBarPnl.Controls.Add(this.DelayLbl);
            this.TrackBarPnl.Controls.Add(this.DelayBar);
            this.TrackBarPnl.Location = new System.Drawing.Point(317, 374);
            this.TrackBarPnl.Name = "TrackBarPnl";
            this.TrackBarPnl.Size = new System.Drawing.Size(296, 41);
            this.TrackBarPnl.TabIndex = 6335;
            // 
            // TknSettingsBtn
            // 
            this.TknSettingsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TknSettingsBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.TknSettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TknSettingsBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.TknSettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.TknSettingsBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TknSettingsBtn.Location = new System.Drawing.Point(430, 472);
            this.TknSettingsBtn.Name = "TknSettingsBtn";
            this.TknSettingsBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.TknSettingsBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.TknSettingsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.TknSettingsBtn.Size = new System.Drawing.Size(167, 29);
            this.TknSettingsBtn.TabIndex = 6339;
            this.TknSettingsBtn.Text = "Token Settings";
            this.TknSettingsBtn.TextColor = System.Drawing.Color.White;
            this.TknSettingsBtn.UseVisualStyleBackColor = true;
            this.TknSettingsBtn.Click += new System.EventHandler(this.TknSettingsBtn_Click);
            // 
            // ChkTknPrxBtn
            // 
            this.ChkTknPrxBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChkTknPrxBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChkTknPrxBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkTknPrxBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.ChkTknPrxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ChkTknPrxBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChkTknPrxBtn.Location = new System.Drawing.Point(229, 472);
            this.ChkTknPrxBtn.Name = "ChkTknPrxBtn";
            this.ChkTknPrxBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.ChkTknPrxBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.ChkTknPrxBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ChkTknPrxBtn.Size = new System.Drawing.Size(167, 29);
            this.ChkTknPrxBtn.TabIndex = 6338;
            this.ChkTknPrxBtn.Text = "Check";
            this.ChkTknPrxBtn.TextColor = System.Drawing.Color.White;
            this.ChkTknPrxBtn.UseVisualStyleBackColor = true;
            this.ChkTknPrxBtn.Click += new System.EventHandler(this.ChkTknPrx_Click);
            // 
            // JoinBtn
            // 
            this.JoinBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.JoinBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.JoinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.JoinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.JoinBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.JoinBtn.Location = new System.Drawing.Point(30, 472);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.JoinBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.JoinBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.JoinBtn.Size = new System.Drawing.Size(167, 29);
            this.JoinBtn.TabIndex = 6326;
            this.JoinBtn.Text = "Join";
            this.JoinBtn.TextColor = System.Drawing.Color.White;
            this.JoinBtn.UseVisualStyleBackColor = true;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // TokenManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(626, 539);
            this.Controls.Add(this.TknSettingsBtn);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.ChkTknPrxBtn);
            this.Controls.Add(this.CurrentStatusLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.InvitePnl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RainbowPnlDown);
            this.Controls.Add(this.RainbowPnlUp);
            this.Controls.Add(this.ProxiesLbl);
            this.Controls.Add(this.TokensLbl);
            this.Controls.Add(this.JoinBtn);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TrackBarPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TokenManager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItroublveJoiner";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.InvitePnl.ResumeLayout(false);
            this.InvitePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelayBar)).EndInit();
            this.TrackBarPnl.ResumeLayout(false);
            this.TrackBarPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TokensRichTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox ProxiesRichTxt;
        private RoundBtn JoinBtn;
        private System.Windows.Forms.Label TokensLbl;
        private System.Windows.Forms.Label ProxiesLbl;
        private System.Windows.Forms.Panel RainbowPnlUp;
        private System.Windows.Forms.Timer RainbowTimer;
        private System.Windows.Forms.Panel RainbowPnlDown;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Panel InvitePnl;
        private System.Windows.Forms.TextBox InviteTxtbox;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label CurrentStatusLbl;
        private RoundBtn ChkTknPrxBtn;
        private System.Windows.Forms.Timer CountToken;
        private RoundBtn TknSettingsBtn;
        private System.Windows.Forms.TrackBar DelayBar;
        private System.Windows.Forms.Panel TrackBarPnl;
        private System.Windows.Forms.Label DelayLbl;
    }
}

