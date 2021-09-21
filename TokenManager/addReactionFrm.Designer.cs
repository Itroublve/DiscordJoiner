
namespace Tokens.rip_Token_Manager
{
    partial class addReactionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReactionFrm));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HeadLbl = new System.Windows.Forms.Label();
            this.HeadPnl = new System.Windows.Forms.Panel();
            this.RainbowPnlUp = new System.Windows.Forms.Panel();
            this.ChannelIdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.FriendNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.MsgIdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmojiTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddReactionBtn = new RoundBtn();
            this.NoTokenPnl = new System.Windows.Forms.Panel();
            this.NoTokenTxt = new System.Windows.Forms.Label();
            this.HeadPnl.SuspendLayout();
            this.NoTokenPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(288, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(47, 27);
            this.CloseBtn.TabIndex = 6357;
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
            this.HeadLbl.Location = new System.Drawing.Point(111, 3);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(112, 21);
            this.HeadLbl.TabIndex = 6358;
            this.HeadLbl.Text = "Add Reaction";
            // 
            // HeadPnl
            // 
            this.HeadPnl.Controls.Add(this.NoTokenPnl);
            this.HeadPnl.Controls.Add(this.HeadLbl);
            this.HeadPnl.Controls.Add(this.RainbowPnlUp);
            this.HeadPnl.Location = new System.Drawing.Point(2, 1);
            this.HeadPnl.Name = "HeadPnl";
            this.HeadPnl.Size = new System.Drawing.Size(280, 29);
            this.HeadPnl.TabIndex = 6368;
            // 
            // RainbowPnlUp
            // 
            this.RainbowPnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.RainbowPnlUp.Location = new System.Drawing.Point(85, 25);
            this.RainbowPnlUp.Name = "RainbowPnlUp";
            this.RainbowPnlUp.Size = new System.Drawing.Size(150, 2);
            this.RainbowPnlUp.TabIndex = 6366;
            // 
            // ChannelIdTxt
            // 
            this.ChannelIdTxt.AutoRoundedCorners = true;
            this.ChannelIdTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChannelIdTxt.BorderRadius = 14;
            this.ChannelIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChannelIdTxt.DefaultText = "";
            this.ChannelIdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ChannelIdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ChannelIdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChannelIdTxt.DisabledState.Parent = this.ChannelIdTxt;
            this.ChannelIdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChannelIdTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ChannelIdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChannelIdTxt.FocusedState.Parent = this.ChannelIdTxt;
            this.ChannelIdTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChannelIdTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.ChannelIdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.ChannelIdTxt.HoverState.Parent = this.ChannelIdTxt;
            this.ChannelIdTxt.Location = new System.Drawing.Point(32, 50);
            this.ChannelIdTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChannelIdTxt.MaxLength = 2147483647;
            this.ChannelIdTxt.Name = "ChannelIdTxt";
            this.ChannelIdTxt.PasswordChar = '\0';
            this.ChannelIdTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ChannelIdTxt.PlaceholderText = "Channel ID";
            this.ChannelIdTxt.SelectedText = "";
            this.ChannelIdTxt.ShadowDecoration.Parent = this.ChannelIdTxt;
            this.ChannelIdTxt.Size = new System.Drawing.Size(269, 31);
            this.ChannelIdTxt.TabIndex = 6365;
            // 
            // FriendNotification
            // 
            this.FriendNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("FriendNotification.Icon")));
            this.FriendNotification.Text = "FriendNotifcation";
            this.FriendNotification.Visible = true;
            // 
            // MsgIdTxt
            // 
            this.MsgIdTxt.AutoRoundedCorners = true;
            this.MsgIdTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.MsgIdTxt.BorderRadius = 14;
            this.MsgIdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MsgIdTxt.DefaultText = "";
            this.MsgIdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MsgIdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MsgIdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MsgIdTxt.DisabledState.Parent = this.MsgIdTxt;
            this.MsgIdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MsgIdTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.MsgIdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.MsgIdTxt.FocusedState.Parent = this.MsgIdTxt;
            this.MsgIdTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgIdTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.MsgIdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.MsgIdTxt.HoverState.Parent = this.MsgIdTxt;
            this.MsgIdTxt.Location = new System.Drawing.Point(32, 86);
            this.MsgIdTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MsgIdTxt.MaxLength = 2147483647;
            this.MsgIdTxt.Name = "MsgIdTxt";
            this.MsgIdTxt.PasswordChar = '\0';
            this.MsgIdTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.MsgIdTxt.PlaceholderText = "Message ID";
            this.MsgIdTxt.SelectedText = "";
            this.MsgIdTxt.ShadowDecoration.Parent = this.MsgIdTxt;
            this.MsgIdTxt.Size = new System.Drawing.Size(269, 31);
            this.MsgIdTxt.TabIndex = 6369;
            // 
            // EmojiTxt
            // 
            this.EmojiTxt.AutoRoundedCorners = true;
            this.EmojiTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.EmojiTxt.BorderRadius = 14;
            this.EmojiTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmojiTxt.DefaultText = "";
            this.EmojiTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmojiTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmojiTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmojiTxt.DisabledState.Parent = this.EmojiTxt;
            this.EmojiTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmojiTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.EmojiTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.EmojiTxt.FocusedState.Parent = this.EmojiTxt;
            this.EmojiTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmojiTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.EmojiTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.EmojiTxt.HoverState.Parent = this.EmojiTxt;
            this.EmojiTxt.Location = new System.Drawing.Point(32, 122);
            this.EmojiTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmojiTxt.MaxLength = 2147483647;
            this.EmojiTxt.Name = "EmojiTxt";
            this.EmojiTxt.PasswordChar = '\0';
            this.EmojiTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.EmojiTxt.PlaceholderText = "Emoji (EmojiName:EmojiId)";
            this.EmojiTxt.SelectedText = "";
            this.EmojiTxt.ShadowDecoration.Parent = this.EmojiTxt;
            this.EmojiTxt.Size = new System.Drawing.Size(269, 31);
            this.EmojiTxt.TabIndex = 6370;
            // 
            // AddReactionBtn
            // 
            this.AddReactionBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.AddReactionBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.AddReactionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddReactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddReactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddReactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReactionBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddReactionBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddReactionBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddReactionBtn.Location = new System.Drawing.Point(87, 163);
            this.AddReactionBtn.Name = "AddReactionBtn";
            this.AddReactionBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.AddReactionBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.AddReactionBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddReactionBtn.Size = new System.Drawing.Size(138, 30);
            this.AddReactionBtn.TabIndex = 6371;
            this.AddReactionBtn.Text = "Add Reaction";
            this.AddReactionBtn.TextColor = System.Drawing.Color.White;
            this.AddReactionBtn.UseVisualStyleBackColor = true;
            this.AddReactionBtn.Click += new System.EventHandler(this.AddReactionBtn_Click);
            // 
            // NoTokenPnl
            // 
            this.NoTokenPnl.Controls.Add(this.NoTokenTxt);
            this.NoTokenPnl.Location = new System.Drawing.Point(0, 27);
            this.NoTokenPnl.Name = "NoTokenPnl";
            this.NoTokenPnl.Size = new System.Drawing.Size(333, 176);
            this.NoTokenPnl.TabIndex = 6372;
            this.NoTokenPnl.Visible = false;
            // 
            // NoTokenTxt
            // 
            this.NoTokenTxt.AutoSize = true;
            this.NoTokenTxt.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTokenTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.NoTokenTxt.Location = new System.Drawing.Point(74, 57);
            this.NoTokenTxt.Name = "NoTokenTxt";
            this.NoTokenTxt.Size = new System.Drawing.Size(225, 47);
            this.NoTokenTxt.TabIndex = 0;
            this.NoTokenTxt.Text = "NO TOKENS";
            // 
            // addReactionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(333, 205);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.HeadPnl);
            this.Controls.Add(this.AddReactionBtn);
            this.Controls.Add(this.EmojiTxt);
            this.Controls.Add(this.MsgIdTxt);
            this.Controls.Add(this.ChannelIdTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addReactionFrm";
            this.Text = "addReactionFrm";
            this.HeadPnl.ResumeLayout(false);
            this.HeadPnl.PerformLayout();
            this.NoTokenPnl.ResumeLayout(false);
            this.NoTokenPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Panel HeadPnl;
        private System.Windows.Forms.Panel RainbowPnlUp;
        private Guna.UI2.WinForms.Guna2TextBox ChannelIdTxt;
        private System.Windows.Forms.NotifyIcon FriendNotification;
        private Guna.UI2.WinForms.Guna2TextBox MsgIdTxt;
        private Guna.UI2.WinForms.Guna2TextBox EmojiTxt;
        private RoundBtn AddReactionBtn;
        private System.Windows.Forms.Panel NoTokenPnl;
        private System.Windows.Forms.Label NoTokenTxt;
    }
}