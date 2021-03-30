
namespace webTRON_Management_Software
{
    partial class AdminDashboard
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblOnline = new System.Windows.Forms.Label();
            this.onlineUser = new System.Windows.Forms.Label();
            this.offlineUser = new System.Windows.Forms.Label();
            this.lblOffline = new System.Windows.Forms.Label();
            this.sideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.activeUserRole = new System.Windows.Forms.Label();
            this.activeUserSidebar = new System.Windows.Forms.Label();
            this.activeUserPictureSidebar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblActivePanelName = new System.Windows.Forms.Label();
            this.arrowRed = new Guna.UI2.WinForms.Guna2PictureBox();
            this.arrowGreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.onlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.offlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.activeUserPanel = new System.Windows.Forms.Panel();
            this.activeUser = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.sideBarTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.button1 = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).BeginInit();
            this.activeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblOnline, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblOnline.ForeColor = System.Drawing.Color.Green;
            this.lblOnline.Location = new System.Drawing.Point(488, 45);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(66, 24);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "Online";
            // 
            // onlineUser
            // 
            this.onlineUser.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.onlineUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.onlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineUser.ForeColor = System.Drawing.Color.Green;
            this.onlineUser.Location = new System.Drawing.Point(488, 78);
            this.onlineUser.Name = "onlineUser";
            this.onlineUser.Size = new System.Drawing.Size(24, 25);
            this.onlineUser.TabIndex = 5;
            this.onlineUser.Text = "0";
            // 
            // offlineUser
            // 
            this.offlineUser.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.offlineUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.offlineUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineUser.ForeColor = System.Drawing.Color.Red;
            this.offlineUser.Location = new System.Drawing.Point(676, 78);
            this.offlineUser.Name = "offlineUser";
            this.offlineUser.Size = new System.Drawing.Size(24, 25);
            this.offlineUser.TabIndex = 7;
            this.offlineUser.Text = "0";
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblOffline, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblOffline.ForeColor = System.Drawing.Color.Red;
            this.lblOffline.Location = new System.Drawing.Point(667, 45);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(63, 24);
            this.lblOffline.TabIndex = 6;
            this.lblOffline.Text = "Offline";
            // 
            // sideBar
            // 
            this.sideBar.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved;
            this.sideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideBar.Controls.Add(this.btnUsers);
            this.sideBar.Controls.Add(this.btnSettings);
            this.sideBar.Controls.Add(this.btnDashboard);
            this.sideBar.Controls.Add(this.activeUserRole);
            this.sideBar.Controls.Add(this.activeUserSidebar);
            this.sideBar.Controls.Add(this.activeUserPictureSidebar);
            this.sideBar.Controls.Add(this.btnSignOut);
            this.sideBarTransition.SetDecoration(this.sideBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.ShadowDecoration.Parent = this.sideBar;
            this.sideBar.Size = new System.Drawing.Size(349, 625);
            this.sideBar.TabIndex = 13;
            this.sideBar.Visible = false;
            // 
            // btnUsers
            // 
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.sideBarTransition.SetDecoration(this.btnUsers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::webTRON_Management_Software.Properties.Resources.user_icon;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnUsers.Location = new System.Drawing.Point(9, 344);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(319, 45);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            // 
            // btnSettings
            // 
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.sideBarTransition.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::webTRON_Management_Software.Properties.Resources.settings_icon;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnSettings.Location = new System.Drawing.Point(9, 395);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(319, 45);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            // 
            // btnDashboard
            // 
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.sideBarTransition.SetDecoration(this.btnDashboard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::webTRON_Management_Software.Properties.Resources.dashboard_icon;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDashboard.Location = new System.Drawing.Point(9, 293);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(319, 45);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            // 
            // activeUserRole
            // 
            this.activeUserRole.AutoSize = true;
            this.activeUserRole.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUserRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserRole.ForeColor = System.Drawing.Color.White;
            this.activeUserRole.Location = new System.Drawing.Point(125, 255);
            this.activeUserRole.Name = "activeUserRole";
            this.activeUserRole.Size = new System.Drawing.Size(70, 24);
            this.activeUserRole.TabIndex = 2;
            this.activeUserRole.Text = "Admin";
            // 
            // activeUserSidebar
            // 
            this.activeUserSidebar.AutoSize = true;
            this.activeUserSidebar.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUserSidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserSidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserSidebar.ForeColor = System.Drawing.Color.White;
            this.activeUserSidebar.Location = new System.Drawing.Point(107, 216);
            this.activeUserSidebar.Name = "activeUserSidebar";
            this.activeUserSidebar.Size = new System.Drawing.Size(116, 29);
            this.activeUserSidebar.TabIndex = 1;
            this.activeUserSidebar.Text = "John Doe";
            // 
            // activeUserPictureSidebar
            // 
            this.activeUserPictureSidebar.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUserPictureSidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPictureSidebar.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.activeUserPictureSidebar.Location = new System.Drawing.Point(81, 35);
            this.activeUserPictureSidebar.Name = "activeUserPictureSidebar";
            this.activeUserPictureSidebar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPictureSidebar.ShadowDecoration.Parent = this.activeUserPictureSidebar;
            this.activeUserPictureSidebar.Size = new System.Drawing.Size(163, 152);
            this.activeUserPictureSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPictureSidebar.TabIndex = 0;
            this.activeUserPictureSidebar.TabStop = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.CheckedState.Parent = this.btnSignOut;
            this.btnSignOut.CustomImages.Parent = this.btnSignOut;
            this.sideBarTransition.SetDecoration(this.btnSignOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.HoverState.Parent = this.btnSignOut;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(81, 533);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(180, 45);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign Out";
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_medium;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.lblActivePanelName);
            this.sideBarTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(-3, 45);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(278, 51);
            this.activePanel.TabIndex = 15;
            // 
            // lblActivePanelName
            // 
            this.lblActivePanelName.AutoSize = true;
            this.lblActivePanelName.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.lblActivePanelName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblActivePanelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblActivePanelName.ForeColor = System.Drawing.Color.White;
            this.lblActivePanelName.Location = new System.Drawing.Point(89, 11);
            this.lblActivePanelName.Name = "lblActivePanelName";
            this.lblActivePanelName.Size = new System.Drawing.Size(102, 24);
            this.lblActivePanelName.TabIndex = 0;
            this.lblActivePanelName.Text = "Dashboard";
            // 
            // arrowRed
            // 
            this.sideBarTransition.SetDecoration(this.arrowRed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.arrowRed.Image = ((System.Drawing.Image)(resources.GetObject("arrowRed.Image")));
            this.arrowRed.Location = new System.Drawing.Point(641, 110);
            this.arrowRed.Name = "arrowRed";
            this.arrowRed.ShadowDecoration.Parent = this.arrowRed;
            this.arrowRed.Size = new System.Drawing.Size(20, 20);
            this.arrowRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowRed.TabIndex = 17;
            this.arrowRed.TabStop = false;
            // 
            // arrowGreen
            // 
            this.sideBarTransition.SetDecoration(this.arrowGreen, Guna.UI2.AnimatorNS.DecorationType.None);
            this.arrowGreen.Image = ((System.Drawing.Image)(resources.GetObject("arrowGreen.Image")));
            this.arrowGreen.Location = new System.Drawing.Point(477, 110);
            this.arrowGreen.Name = "arrowGreen";
            this.arrowGreen.ShadowDecoration.Parent = this.arrowGreen;
            this.arrowGreen.Size = new System.Drawing.Size(20, 20);
            this.arrowGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowGreen.TabIndex = 16;
            this.arrowGreen.TabStop = false;
            // 
            // onlineStatusPicture
            // 
            this.sideBarTransition.SetDecoration(this.onlineStatusPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.onlineStatusPicture.Image = global::webTRON_Management_Software.Properties.Resources.circle_green;
            this.onlineStatusPicture.Location = new System.Drawing.Point(452, 59);
            this.onlineStatusPicture.Name = "onlineStatusPicture";
            this.onlineStatusPicture.ShadowDecoration.Parent = this.onlineStatusPicture;
            this.onlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.onlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onlineStatusPicture.TabIndex = 1;
            this.onlineStatusPicture.TabStop = false;
            // 
            // offlineStatusPicture
            // 
            this.sideBarTransition.SetDecoration(this.offlineStatusPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.offlineStatusPicture.Image = global::webTRON_Management_Software.Properties.Resources.circle_red;
            this.offlineStatusPicture.Location = new System.Drawing.Point(621, 59);
            this.offlineStatusPicture.Name = "offlineStatusPicture";
            this.offlineStatusPicture.ShadowDecoration.Parent = this.offlineStatusPicture;
            this.offlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.offlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offlineStatusPicture.TabIndex = 2;
            this.offlineStatusPicture.TabStop = false;
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_small;
            this.activeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeUserPanel.Controls.Add(this.activeUser);
            this.activeUserPanel.Controls.Add(this.activeUserPicture);
            this.sideBarTransition.SetDecoration(this.activeUserPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPanel.Location = new System.Drawing.Point(880, 45);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.Size = new System.Drawing.Size(124, 52);
            this.activeUserPanel.TabIndex = 14;
            // 
            // activeUser
            // 
            this.activeUser.AutoSize = true;
            this.activeUser.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUser.ForeColor = System.Drawing.Color.White;
            this.activeUser.Location = new System.Drawing.Point(57, 10);
            this.activeUser.Name = "activeUser";
            this.activeUser.Size = new System.Drawing.Size(52, 24);
            this.activeUser.TabIndex = 10;
            this.activeUser.Text = "John";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.activeUserPicture.Location = new System.Drawing.Point(21, 10);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(30, 30);
            this.activeUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPicture.TabIndex = 11;
            this.activeUserPicture.TabStop = false;
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.sideBarTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.sideBarTransition.DefaultAnimation = animation1;
            // 
            // button1
            // 
            this.sideBarTransition.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(901, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.arrowRed);
            this.Controls.Add(this.arrowGreen);
            this.Controls.Add(this.offlineUser);
            this.Controls.Add(this.onlineUser);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.onlineStatusPicture);
            this.Controls.Add(this.offlineStatusPicture);
            this.Controls.Add(this.lblOffline);
            this.Controls.Add(this.activeUserPanel);
            this.sideBarTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).EndInit();
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
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
        private System.Windows.Forms.Label activeUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private Guna.UI2.WinForms.Guna2Panel sideBar;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label activeUserRole;
        private System.Windows.Forms.Label activeUserSidebar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPictureSidebar;
        private System.Windows.Forms.Panel activeUserPanel;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label lblActivePanelName;
        private Guna.UI2.WinForms.Guna2PictureBox arrowGreen;
        private Guna.UI2.WinForms.Guna2PictureBox arrowRed;
        private Guna.UI2.WinForms.Guna2Transition sideBarTransition;
        private System.Windows.Forms.Button button1;
    }
}