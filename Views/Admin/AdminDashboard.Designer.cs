
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblOnline = new System.Windows.Forms.Label();
            this.onlineUser = new System.Windows.Forms.Label();
            this.offlineUser = new System.Windows.Forms.Label();
            this.lblOffline = new System.Windows.Forms.Label();
            this.activeUserSidebar = new System.Windows.Forms.Label();
            this.activeUserPictureSidebar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.arrowRed = new Guna.UI2.WinForms.Guna2PictureBox();
            this.arrowGreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.onlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.offlineStatusPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sideBarTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).BeginInit();
            this.guna2Panel2.SuspendLayout();
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
            // activeUserSidebar
            // 
            this.activeUserSidebar.AutoSize = true;
            this.activeUserSidebar.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUserSidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserSidebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserSidebar.ForeColor = System.Drawing.Color.White;
            this.activeUserSidebar.Location = new System.Drawing.Point(64, 12);
            this.activeUserSidebar.Name = "activeUserSidebar";
            this.activeUserSidebar.Size = new System.Drawing.Size(52, 24);
            this.activeUserSidebar.TabIndex = 1;
            this.activeUserSidebar.Text = "John";
            // 
            // activeUserPictureSidebar
            // 
            this.activeUserPictureSidebar.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.activeUserPictureSidebar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPictureSidebar.Location = new System.Drawing.Point(11, 15);
            this.activeUserPictureSidebar.Name = "activeUserPictureSidebar";
            this.activeUserPictureSidebar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPictureSidebar.ShadowDecoration.Parent = this.activeUserPictureSidebar;
            this.activeUserPictureSidebar.Size = new System.Drawing.Size(49, 45);
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
            this.btnSignOut.Location = new System.Drawing.Point(112, 391);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ShadowDecoration.Parent = this.btnSignOut;
            this.btnSignOut.Size = new System.Drawing.Size(180, 45);
            this.btnSignOut.TabIndex = 7;
            this.btnSignOut.Text = "Sign Out";
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
            this.offlineStatusPicture.Location = new System.Drawing.Point(621, 59);
            this.offlineStatusPicture.Name = "offlineStatusPicture";
            this.offlineStatusPicture.ShadowDecoration.Parent = this.offlineStatusPicture;
            this.offlineStatusPicture.Size = new System.Drawing.Size(30, 30);
            this.offlineStatusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offlineStatusPicture.TabIndex = 2;
            this.offlineStatusPicture.TabStop = false;
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.sideBarTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.sideBarTransition.DefaultAnimation = animation2;
            // 
            // guna2Panel1
            // 
            this.sideBarTransition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(68, 532);
            this.guna2Panel1.TabIndex = 19;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.activeUserPictureSidebar);
            this.guna2Panel2.Controls.Add(this.activeUserSidebar);
            this.sideBarTransition.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(63, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(164, 76);
            this.guna2Panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.arrowRed);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.arrowGreen);
            this.Controls.Add(this.offlineUser);
            this.Controls.Add(this.onlineUser);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.onlineStatusPicture);
            this.Controls.Add(this.offlineStatusPicture);
            this.Controls.Add(this.lblOffline);
            this.sideBarTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineStatusPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlineStatusPicture)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private System.Windows.Forms.Label activeUserSidebar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPictureSidebar;
        private Guna.UI2.WinForms.Guna2PictureBox arrowGreen;
        private Guna.UI2.WinForms.Guna2PictureBox arrowRed;
        private Guna.UI2.WinForms.Guna2Transition sideBarTransition;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
    }
}