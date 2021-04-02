
namespace webTRON_Management_Software.Views.Admin
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblOnline = new System.Windows.Forms.Label();
            this.onlineUser = new System.Windows.Forms.Label();
            this.offlineUser = new System.Windows.Forms.Label();
            this.lblOffline = new System.Windows.Forms.Label();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSIgnOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.DragableAdminDashboard = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragableUsersPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.activeUserPictureSidebar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserSidebar = new System.Windows.Forms.Label();
            this.arrowRed = new Guna.UI2.WinForms.Guna2PictureBox();
            this.arrowGreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.onlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.offlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblOnline.ForeColor = System.Drawing.Color.Green;
            this.lblOnline.Location = new System.Drawing.Point(432, 36);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(66, 24);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "Online";
            // 
            // onlineUser
            // 
            this.onlineUser.AutoSize = true;
            this.onlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineUser.ForeColor = System.Drawing.Color.Green;
            this.onlineUser.Location = new System.Drawing.Point(432, 69);
            this.onlineUser.Name = "onlineUser";
            this.onlineUser.Size = new System.Drawing.Size(24, 25);
            this.onlineUser.TabIndex = 5;
            this.onlineUser.Text = "0";
            // 
            // offlineUser
            // 
            this.offlineUser.AutoSize = true;
            this.offlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineUser.ForeColor = System.Drawing.Color.Red;
            this.offlineUser.Location = new System.Drawing.Point(620, 69);
            this.offlineUser.Name = "offlineUser";
            this.offlineUser.Size = new System.Drawing.Size(24, 25);
            this.offlineUser.TabIndex = 7;
            this.offlineUser.Text = "0";
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.lblOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblOffline.ForeColor = System.Drawing.Color.Red;
            this.lblOffline.Location = new System.Drawing.Point(611, 36);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(63, 24);
            this.lblOffline.TabIndex = 6;
            this.lblOffline.Text = "Offline";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.btnSIgnOut);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnUsers);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, -1);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(68, 532);
            this.sidebarPanel.TabIndex = 19;
            // 
            // btnSIgnOut
            // 
            this.btnSIgnOut.Animated = true;
            this.btnSIgnOut.CheckedState.Parent = this.btnSIgnOut;
            this.btnSIgnOut.CustomImages.Parent = this.btnSIgnOut;
            this.btnSIgnOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSIgnOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIgnOut.ForeColor = System.Drawing.Color.White;
            this.btnSIgnOut.HoverState.Parent = this.btnSIgnOut;
            this.btnSIgnOut.Image = global::webTRON_Management_Software.Properties.Resources.exit_icon;
            this.btnSIgnOut.ImageOffset = new System.Drawing.Point(10, -10);
            this.btnSIgnOut.Location = new System.Drawing.Point(0, 468);
            this.btnSIgnOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnSIgnOut.Name = "btnSIgnOut";
            this.btnSIgnOut.ShadowDecoration.Parent = this.btnSIgnOut;
            this.btnSIgnOut.Size = new System.Drawing.Size(68, 48);
            this.btnSIgnOut.TabIndex = 24;
            this.btnSIgnOut.Text = "Sign Out";
            this.btnSIgnOut.TextOffset = new System.Drawing.Point(-8, 10);
            // 
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::webTRON_Management_Software.Properties.Resources.settings_icon;
            this.btnSettings.ImageOffset = new System.Drawing.Point(10, -12);
            this.btnSettings.Location = new System.Drawing.Point(0, 272);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(68, 48);
            this.btnSettings.TabIndex = 23;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::webTRON_Management_Software.Properties.Resources.user_icon;
            this.btnUsers.ImageOffset = new System.Drawing.Point(6, -12);
            this.btnUsers.Location = new System.Drawing.Point(0, 195);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(68, 48);
            this.btnUsers.TabIndex = 22;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextOffset = new System.Drawing.Point(-8, 10);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Black;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::webTRON_Management_Software.Properties.Resources.dashboard_icon;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, -12);
            this.btnDashboard.Location = new System.Drawing.Point(0, 115);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(68, 48);
            this.btnDashboard.TabIndex = 21;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextOffset = new System.Drawing.Point(-6, 10);
            // 
            // DragableAdminDashboard
            // 
            this.DragableAdminDashboard.TargetControl = this;
            // 
            // DragableUsersPanel
            // 
            this.DragableUsersPanel.TargetControl = null;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(911, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(960, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 21;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.label1);
            this.activePanel.Controls.Add(this.activeUserPictureSidebar);
            this.activePanel.Controls.Add(this.activeUserSidebar);
            this.activePanel.Location = new System.Drawing.Point(63, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dashboard";
            // 
            // activeUserPictureSidebar
            // 
            this.activeUserPictureSidebar.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPictureSidebar.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.activeUserPictureSidebar.Location = new System.Drawing.Point(7, 13);
            this.activeUserPictureSidebar.Name = "activeUserPictureSidebar";
            this.activeUserPictureSidebar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPictureSidebar.ShadowDecoration.Parent = this.activeUserPictureSidebar;
            this.activeUserPictureSidebar.Size = new System.Drawing.Size(49, 45);
            this.activeUserPictureSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPictureSidebar.TabIndex = 0;
            this.activeUserPictureSidebar.TabStop = false;
            // 
            // activeUserSidebar
            // 
            this.activeUserSidebar.AutoSize = true;
            this.activeUserSidebar.BackColor = System.Drawing.Color.Transparent;
            this.activeUserSidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserSidebar.ForeColor = System.Drawing.Color.White;
            this.activeUserSidebar.Location = new System.Drawing.Point(64, 9);
            this.activeUserSidebar.Name = "activeUserSidebar";
            this.activeUserSidebar.Size = new System.Drawing.Size(52, 24);
            this.activeUserSidebar.TabIndex = 1;
            this.activeUserSidebar.Text = "John";
            // 
            // arrowRed
            // 
            this.arrowRed.Image = ((System.Drawing.Image)(resources.GetObject("arrowRed.Image")));
            this.arrowRed.Location = new System.Drawing.Point(585, 101);
            this.arrowRed.Name = "arrowRed";
            this.arrowRed.ShadowDecoration.Parent = this.arrowRed;
            this.arrowRed.Size = new System.Drawing.Size(20, 20);
            this.arrowRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowRed.TabIndex = 17;
            this.arrowRed.TabStop = false;
            // 
            // arrowGreen
            // 
            this.arrowGreen.Image = ((System.Drawing.Image)(resources.GetObject("arrowGreen.Image")));
            this.arrowGreen.Location = new System.Drawing.Point(421, 101);
            this.arrowGreen.Name = "arrowGreen";
            this.arrowGreen.ShadowDecoration.Parent = this.arrowGreen;
            this.arrowGreen.Size = new System.Drawing.Size(20, 20);
            this.arrowGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowGreen.TabIndex = 16;
            this.arrowGreen.TabStop = false;
            // 
            // onlineStatusPicture
            // 
            this.onlineStatusPicture.Image = global::webTRON_Management_Software.Properties.Resources.circle_green;
            this.onlineStatusPicture.Location = new System.Drawing.Point(396, 50);
            this.onlineStatusPicture.Name = "onlineStatusPicture";
            this.onlineStatusPicture.ShadowDecoration.Parent = this.onlineStatusPicture;
            this.onlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.onlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onlineStatusPicture.TabIndex = 1;
            this.onlineStatusPicture.TabStop = false;
            // 
            // offlineStatusPicture
            // 
            this.offlineStatusPicture.Image = global::webTRON_Management_Software.Properties.Resources.circle_red;
            this.offlineStatusPicture.Location = new System.Drawing.Point(565, 50);
            this.offlineStatusPicture.Name = "offlineStatusPicture";
            this.offlineStatusPicture.ShadowDecoration.Parent = this.offlineStatusPicture;
            this.offlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.offlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offlineStatusPicture.TabIndex = 2;
            this.offlineStatusPicture.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.arrowRed);
            this.Controls.Add(this.arrowGreen);
            this.Controls.Add(this.offlineUser);
            this.Controls.Add(this.onlineUser);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.onlineStatusPicture);
            this.Controls.Add(this.offlineStatusPicture);
            this.Controls.Add(this.lblOffline);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.activePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox onlineStatusPicture;
        private Guna.UI2.WinForms.Guna2PictureBox offlineStatusPicture;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label onlineUser;
        private System.Windows.Forms.Label offlineUser;
        private System.Windows.Forms.Label lblOffline;
        private System.Windows.Forms.Label activeUserSidebar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPictureSidebar;
        private Guna.UI2.WinForms.Guna2PictureBox arrowGreen;
        private Guna.UI2.WinForms.Guna2PictureBox arrowRed;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnSIgnOut;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2DragControl DragableAdminDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2DragControl DragableUsersPanel;
    }
}