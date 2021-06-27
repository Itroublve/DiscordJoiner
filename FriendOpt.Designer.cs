
namespace Tokens.rip_Token_Manager
{
    partial class FriendOpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendOpt));
            this.HeadLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.NoTokenPnl = new System.Windows.Forms.Panel();
            this.NoTokenTxt = new System.Windows.Forms.Label();
            this.CurrentStatusLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.FrndTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RainbowPnlUp = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MassGuildBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MassGuildLbl = new System.Windows.Forms.Label();
            this.HeadPnl = new System.Windows.Forms.Panel();
            this.BlockUserBtn = new RoundBtn();
            this.RmvUserBtn = new RoundBtn();
            this.AddUserBtn = new RoundBtn();
            this.NoTokenPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadLbl
            // 
            this.HeadLbl.AutoSize = true;
            this.HeadLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.HeadLbl.ForeColor = System.Drawing.Color.White;
            this.HeadLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HeadLbl.Location = new System.Drawing.Point(149, 4);
            this.HeadLbl.Name = "HeadLbl";
            this.HeadLbl.Size = new System.Drawing.Size(122, 21);
            this.HeadLbl.TabIndex = 6339;
            this.HeadLbl.Text = "Friend Options";
            this.HeadLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadLbl_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 11.25F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(382, -2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(38, 25);
            this.CloseBtn.TabIndex = 6338;
            this.CloseBtn.Text = "r";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NoTokenPnl
            // 
            this.NoTokenPnl.Controls.Add(this.NoTokenTxt);
            this.NoTokenPnl.Location = new System.Drawing.Point(0, 24);
            this.NoTokenPnl.Name = "NoTokenPnl";
            this.NoTokenPnl.Size = new System.Drawing.Size(413, 167);
            this.NoTokenPnl.TabIndex = 6345;
            this.NoTokenPnl.Visible = false;
            // 
            // NoTokenTxt
            // 
            this.NoTokenTxt.AutoSize = true;
            this.NoTokenTxt.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoTokenTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.NoTokenTxt.Location = new System.Drawing.Point(97, 49);
            this.NoTokenTxt.Name = "NoTokenTxt";
            this.NoTokenTxt.Size = new System.Drawing.Size(225, 47);
            this.NoTokenTxt.TabIndex = 0;
            this.NoTokenTxt.Text = "NO TOKENS";
            // 
            // CurrentStatusLbl
            // 
            this.CurrentStatusLbl.AutoSize = true;
            this.CurrentStatusLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.CurrentStatusLbl.ForeColor = System.Drawing.Color.White;
            this.CurrentStatusLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentStatusLbl.Location = new System.Drawing.Point(87, 101);
            this.CurrentStatusLbl.Name = "CurrentStatusLbl";
            this.CurrentStatusLbl.Size = new System.Drawing.Size(45, 17);
            this.CurrentStatusLbl.TabIndex = 6350;
            this.CurrentStatusLbl.Text = "Idling";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StatusLbl.Location = new System.Drawing.Point(40, 101);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(50, 17);
            this.StatusLbl.TabIndex = 6349;
            this.StatusLbl.Text = "Status:";
            // 
            // FrndTxt
            // 
            this.FrndTxt.AutoRoundedCorners = true;
            this.FrndTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.FrndTxt.BorderRadius = 14;
            this.FrndTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FrndTxt.DefaultText = "";
            this.FrndTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FrndTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FrndTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FrndTxt.DisabledState.Parent = this.FrndTxt;
            this.FrndTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FrndTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.FrndTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.FrndTxt.FocusedState.Parent = this.FrndTxt;
            this.FrndTxt.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrndTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.FrndTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.FrndTxt.HoverState.Parent = this.FrndTxt;
            this.FrndTxt.Location = new System.Drawing.Point(44, 50);
            this.FrndTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FrndTxt.MaxLength = 2147483647;
            this.FrndTxt.Name = "FrndTxt";
            this.FrndTxt.PasswordChar = '\0';
            this.FrndTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.FrndTxt.PlaceholderText = "Enter User ID";
            this.FrndTxt.SelectedText = "";
            this.FrndTxt.ShadowDecoration.Parent = this.FrndTxt;
            this.FrndTxt.Size = new System.Drawing.Size(337, 30);
            this.FrndTxt.TabIndex = 6353;
            // 
            // RainbowPnlUp
            // 
            this.RainbowPnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.RainbowPnlUp.Location = new System.Drawing.Point(132, 21);
            this.RainbowPnlUp.Name = "RainbowPnlUp";
            this.RainbowPnlUp.Size = new System.Drawing.Size(150, 2);
            this.RainbowPnlUp.TabIndex = 6354;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MassGuildBtn);
            this.panel3.Controls.Add(this.MassGuildLbl);
            this.panel3.Location = new System.Drawing.Point(287, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 30);
            this.panel3.TabIndex = 6355;
            // 
            // MassGuildBtn
            // 
            this.MassGuildBtn.Animated = true;
            this.MassGuildBtn.AutoRoundedCorners = true;
            this.MassGuildBtn.BorderRadius = 9;
            this.MassGuildBtn.CheckedState.Parent = this.MassGuildBtn;
            this.MassGuildBtn.CustomImages.Parent = this.MassGuildBtn;
            this.MassGuildBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MassGuildBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MassGuildBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MassGuildBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MassGuildBtn.DisabledState.Parent = this.MassGuildBtn;
            this.MassGuildBtn.FillColor = System.Drawing.Color.White;
            this.MassGuildBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MassGuildBtn.ForeColor = System.Drawing.Color.White;
            this.MassGuildBtn.HoverState.Parent = this.MassGuildBtn;
            this.MassGuildBtn.Location = new System.Drawing.Point(3, 5);
            this.MassGuildBtn.Name = "MassGuildBtn";
            this.MassGuildBtn.ShadowDecoration.Parent = this.MassGuildBtn;
            this.MassGuildBtn.Size = new System.Drawing.Size(20, 20);
            this.MassGuildBtn.TabIndex = 6348;
            this.MassGuildBtn.Click += new System.EventHandler(this.MassGuildBtn_Click);
            // 
            // MassGuildLbl
            // 
            this.MassGuildLbl.AutoSize = true;
            this.MassGuildLbl.ForeColor = System.Drawing.Color.White;
            this.MassGuildLbl.Location = new System.Drawing.Point(28, 9);
            this.MassGuildLbl.Name = "MassGuildLbl";
            this.MassGuildLbl.Size = new System.Drawing.Size(59, 13);
            this.MassGuildLbl.TabIndex = 6345;
            this.MassGuildLbl.Text = "Mass Guild";
            this.MassGuildLbl.Click += new System.EventHandler(this.MassGuildLbl_Click);
            // 
            // HeadPnl
            // 
            this.HeadPnl.Location = new System.Drawing.Point(0, -2);
            this.HeadPnl.Name = "HeadPnl";
            this.HeadPnl.Size = new System.Drawing.Size(381, 27);
            this.HeadPnl.TabIndex = 6356;
            this.HeadPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // BlockUserBtn
            // 
            this.BlockUserBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.BlockUserBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BlockUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BlockUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BlockUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BlockUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockUserBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.BlockUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.BlockUserBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BlockUserBtn.Location = new System.Drawing.Point(279, 142);
            this.BlockUserBtn.Name = "BlockUserBtn";
            this.BlockUserBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.BlockUserBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BlockUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BlockUserBtn.Size = new System.Drawing.Size(99, 29);
            this.BlockUserBtn.TabIndex = 6352;
            this.BlockUserBtn.Text = "Block";
            this.BlockUserBtn.TextColor = System.Drawing.Color.White;
            this.BlockUserBtn.UseVisualStyleBackColor = true;
            this.BlockUserBtn.Click += new System.EventHandler(this.BlockUserBtn_Click);
            // 
            // RmvUserBtn
            // 
            this.RmvUserBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.RmvUserBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.RmvUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.RmvUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.RmvUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.RmvUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RmvUserBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.RmvUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.RmvUserBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RmvUserBtn.Location = new System.Drawing.Point(162, 142);
            this.RmvUserBtn.Name = "RmvUserBtn";
            this.RmvUserBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.RmvUserBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.RmvUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.RmvUserBtn.Size = new System.Drawing.Size(100, 29);
            this.RmvUserBtn.TabIndex = 6351;
            this.RmvUserBtn.Text = "Remove";
            this.RmvUserBtn.TextColor = System.Drawing.Color.White;
            this.RmvUserBtn.UseVisualStyleBackColor = true;
            this.RmvUserBtn.Click += new System.EventHandler(this.RmvUserBtn_Click);
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.AddUserBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.AddUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserBtn.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddUserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.AddUserBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddUserBtn.Location = new System.Drawing.Point(44, 142);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(99)))), ((int)(((byte)(180)))));
            this.AddUserBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.AddUserBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddUserBtn.Size = new System.Drawing.Size(100, 29);
            this.AddUserBtn.TabIndex = 6347;
            this.AddUserBtn.Text = "Add";
            this.AddUserBtn.TextColor = System.Drawing.Color.White;
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // FriendOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(418, 190);
            this.Controls.Add(this.RainbowPnlUp);
            this.Controls.Add(this.NoTokenPnl);
            this.Controls.Add(this.CurrentStatusLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.BlockUserBtn);
            this.Controls.Add(this.RmvUserBtn);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.HeadLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.FrndTxt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HeadPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FriendOpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friend Options";
            this.NoTokenPnl.ResumeLayout(false);
            this.NoTokenPnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel NoTokenPnl;
        private System.Windows.Forms.Label NoTokenTxt;
        private System.Windows.Forms.Label CurrentStatusLbl;
        private System.Windows.Forms.Label StatusLbl;
        private RoundBtn BlockUserBtn;
        private RoundBtn RmvUserBtn;
        private RoundBtn AddUserBtn;
        private Guna.UI2.WinForms.Guna2TextBox FrndTxt;
        private System.Windows.Forms.Panel RainbowPnlUp;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button MassGuildBtn;
        private System.Windows.Forms.Label MassGuildLbl;
        private System.Windows.Forms.Panel HeadPnl;
    }
}