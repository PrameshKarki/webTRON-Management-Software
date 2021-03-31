namespace webTRON_Management_Software
{
    partial class ForgetPassword
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblYouCanReset = new System.Windows.Forms.Label();
            this.passwordIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblEnterRegisteredEmail = new System.Windows.Forms.Label();
            this.recoveryEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSendVerificationCode = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sendVerificationCodePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.verificationCodeTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationCodeTextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.lblEnterVerificationCode = new System.Windows.Forms.Label();
            this.verificationCodeTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.verificationPanelTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.resetPasswordPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEnterNewPassword = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.resetPasswordPanelTransition = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.sendVerificationCodePanel.SuspendLayout();
            this.resetPasswordPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPasswordPanelTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = global::webTRON_Management_Software.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(909, 24);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(20, 5);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPasswordPanelTransition.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.Image = global::webTRON_Management_Software.Properties.Resources.close_window;
            this.btnClose.Location = new System.Drawing.Point(960, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(27, 27);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblYouCanReset
            // 
            this.lblYouCanReset.AutoSize = true;
            this.lblYouCanReset.BackColor = System.Drawing.Color.Transparent;
            this.verificationPanelTransition.SetDecoration(this.lblYouCanReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanelTransition.SetDecoration(this.lblYouCanReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblYouCanReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouCanReset.ForeColor = System.Drawing.Color.White;
            this.lblYouCanReset.Location = new System.Drawing.Point(7, 133);
            this.lblYouCanReset.Name = "lblYouCanReset";
            this.lblYouCanReset.Size = new System.Drawing.Size(320, 24);
            this.lblYouCanReset.TabIndex = 4;
            this.lblYouCanReset.Text = "You Can Reset Your Password Here.";
            // 
            // passwordIcon
            // 
            this.passwordIcon.BackColor = System.Drawing.Color.Transparent;
            this.resetPasswordPanelTransition.SetDecoration(this.passwordIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.passwordIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.passwordIcon.Image = global::webTRON_Management_Software.Properties.Resources.lock_password;
            this.passwordIcon.Location = new System.Drawing.Point(111, 14);
            this.passwordIcon.Name = "passwordIcon";
            this.passwordIcon.ShadowDecoration.Parent = this.passwordIcon;
            this.passwordIcon.Size = new System.Drawing.Size(76, 69);
            this.passwordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordIcon.TabIndex = 5;
            this.passwordIcon.TabStop = false;
            // 
            // lblEnterRegisteredEmail
            // 
            this.lblEnterRegisteredEmail.AutoSize = true;
            this.verificationPanelTransition.SetDecoration(this.lblEnterRegisteredEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanelTransition.SetDecoration(this.lblEnterRegisteredEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEnterRegisteredEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterRegisteredEmail.Location = new System.Drawing.Point(510, 174);
            this.lblEnterRegisteredEmail.Name = "lblEnterRegisteredEmail";
            this.lblEnterRegisteredEmail.Size = new System.Drawing.Size(261, 25);
            this.lblEnterRegisteredEmail.TabIndex = 6;
            this.lblEnterRegisteredEmail.Text = "Enter Your Registered Email:";
            // 
            // recoveryEmailTextBox
            // 
            this.recoveryEmailTextBox.Animated = true;
            this.recoveryEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.recoveryEmailTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.recoveryEmailTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.recoveryEmailTextBox.DefaultText = "";
            this.recoveryEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.recoveryEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.recoveryEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recoveryEmailTextBox.DisabledState.Parent = this.recoveryEmailTextBox;
            this.recoveryEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.recoveryEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recoveryEmailTextBox.FocusedState.Parent = this.recoveryEmailTextBox;
            this.recoveryEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recoveryEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recoveryEmailTextBox.HoverState.Parent = this.recoveryEmailTextBox;
            this.recoveryEmailTextBox.Location = new System.Drawing.Point(516, 219);
            this.recoveryEmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recoveryEmailTextBox.Name = "recoveryEmailTextBox";
            this.recoveryEmailTextBox.PasswordChar = '\0';
            this.recoveryEmailTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recoveryEmailTextBox.PlaceholderText = "Recovery Email";
            this.recoveryEmailTextBox.SelectedText = "";
            this.recoveryEmailTextBox.ShadowDecoration.Parent = this.recoveryEmailTextBox;
            this.recoveryEmailTextBox.Size = new System.Drawing.Size(338, 38);
            this.recoveryEmailTextBox.TabIndex = 7;
            // 
            // btnSendVerificationCode
            // 
            this.btnSendVerificationCode.CheckedState.Parent = this.btnSendVerificationCode;
            this.btnSendVerificationCode.CustomImages.Parent = this.btnSendVerificationCode;
            this.resetPasswordPanelTransition.SetDecoration(this.btnSendVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.btnSendVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSendVerificationCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSendVerificationCode.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSendVerificationCode.ForeColor = System.Drawing.Color.White;
            this.btnSendVerificationCode.HoverState.Parent = this.btnSendVerificationCode;
            this.btnSendVerificationCode.Location = new System.Drawing.Point(552, 313);
            this.btnSendVerificationCode.Name = "btnSendVerificationCode";
            this.btnSendVerificationCode.ShadowDecoration.Parent = this.btnSendVerificationCode;
            this.btnSendVerificationCode.Size = new System.Drawing.Size(258, 53);
            this.btnSendVerificationCode.TabIndex = 8;
            this.btnSendVerificationCode.Text = "Send Verification Code";
            this.btnSendVerificationCode.Click += new System.EventHandler(this.btnSendVerificationCode_Click);
            // 
            // guna2PictureBox5
            // 
            this.resetPasswordPanelTransition.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.guna2PictureBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox5.Image = global::webTRON_Management_Software.Properties.Resources.webTRONLogoWithSlogan;
            this.guna2PictureBox5.Location = new System.Drawing.Point(12, 535);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.ShadowDecoration.Parent = this.guna2PictureBox5;
            this.guna2PictureBox5.Size = new System.Drawing.Size(187, 72);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox5.TabIndex = 12;
            this.guna2PictureBox5.TabStop = false;
            // 
            // sendVerificationCodePanel
            // 
            this.sendVerificationCodePanel.Controls.Add(this.verificationCodeTextBox2);
            this.sendVerificationCodePanel.Controls.Add(this.verificationCodeTextBox3);
            this.sendVerificationCodePanel.Controls.Add(this.verificationCodeTextBox4);
            this.sendVerificationCodePanel.Controls.Add(this.verificationCodeTextBox5);
            this.sendVerificationCodePanel.Controls.Add(this.btnVerify);
            this.sendVerificationCodePanel.Controls.Add(this.lblEnterVerificationCode);
            this.sendVerificationCodePanel.Controls.Add(this.verificationCodeTextBox1);
            this.resetPasswordPanelTransition.SetDecoration(this.sendVerificationCodePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.sendVerificationCodePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sendVerificationCodePanel.Location = new System.Drawing.Point(421, 47);
            this.sendVerificationCodePanel.Name = "sendVerificationCodePanel";
            this.sendVerificationCodePanel.ShadowDecoration.Parent = this.sendVerificationCodePanel;
            this.sendVerificationCodePanel.Size = new System.Drawing.Size(561, 480);
            this.sendVerificationCodePanel.TabIndex = 13;
            this.sendVerificationCodePanel.Visible = false;
            // 
            // verificationCodeTextBox2
            // 
            this.verificationCodeTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.verificationCodeTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.verificationCodeTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox2.DefaultText = "";
            this.verificationCodeTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.DisabledState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.FocusedState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox2.HoverState.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Location = new System.Drawing.Point(220, 189);
            this.verificationCodeTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox2.Name = "verificationCodeTextBox2";
            this.verificationCodeTextBox2.PasswordChar = '\0';
            this.verificationCodeTextBox2.PlaceholderText = "";
            this.verificationCodeTextBox2.SelectedText = "";
            this.verificationCodeTextBox2.ShadowDecoration.Parent = this.verificationCodeTextBox2;
            this.verificationCodeTextBox2.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox2.TabIndex = 1;
            // 
            // verificationCodeTextBox3
            // 
            this.verificationCodeTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.verificationCodeTextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.verificationCodeTextBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox3.DefaultText = "";
            this.verificationCodeTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.DisabledState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.FocusedState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox3.HoverState.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Location = new System.Drawing.Point(278, 189);
            this.verificationCodeTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox3.Name = "verificationCodeTextBox3";
            this.verificationCodeTextBox3.PasswordChar = '\0';
            this.verificationCodeTextBox3.PlaceholderText = "";
            this.verificationCodeTextBox3.SelectedText = "";
            this.verificationCodeTextBox3.ShadowDecoration.Parent = this.verificationCodeTextBox3;
            this.verificationCodeTextBox3.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox3.TabIndex = 2;
            // 
            // verificationCodeTextBox4
            // 
            this.verificationCodeTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.verificationCodeTextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.verificationCodeTextBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox4.DefaultText = "";
            this.verificationCodeTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.DisabledState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.FocusedState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox4.HoverState.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Location = new System.Drawing.Point(329, 189);
            this.verificationCodeTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox4.Name = "verificationCodeTextBox4";
            this.verificationCodeTextBox4.PasswordChar = '\0';
            this.verificationCodeTextBox4.PlaceholderText = "";
            this.verificationCodeTextBox4.SelectedText = "";
            this.verificationCodeTextBox4.ShadowDecoration.Parent = this.verificationCodeTextBox4;
            this.verificationCodeTextBox4.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox4.TabIndex = 3;
            // 
            // verificationCodeTextBox5
            // 
            this.verificationCodeTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.verificationCodeTextBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.verificationCodeTextBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox5.DefaultText = "";
            this.verificationCodeTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox5.DisabledState.Parent = this.verificationCodeTextBox5;
            this.verificationCodeTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox5.FocusedState.Parent = this.verificationCodeTextBox5;
            this.verificationCodeTextBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox5.HoverState.Parent = this.verificationCodeTextBox5;
            this.verificationCodeTextBox5.Location = new System.Drawing.Point(387, 189);
            this.verificationCodeTextBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox5.Name = "verificationCodeTextBox5";
            this.verificationCodeTextBox5.PasswordChar = '\0';
            this.verificationCodeTextBox5.PlaceholderText = "";
            this.verificationCodeTextBox5.SelectedText = "";
            this.verificationCodeTextBox5.ShadowDecoration.Parent = this.verificationCodeTextBox5;
            this.verificationCodeTextBox5.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox5.TabIndex = 4;
            // 
            // btnVerify
            // 
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.resetPasswordPanelTransition.SetDecoration(this.btnVerify, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.btnVerify, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnVerify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(208, 289);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(175, 53);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblEnterVerificationCode
            // 
            this.lblEnterVerificationCode.AutoSize = true;
            this.verificationPanelTransition.SetDecoration(this.lblEnterVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanelTransition.SetDecoration(this.lblEnterVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEnterVerificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnterVerificationCode.Location = new System.Drawing.Point(160, 145);
            this.lblEnterVerificationCode.Name = "lblEnterVerificationCode";
            this.lblEnterVerificationCode.Size = new System.Drawing.Size(208, 24);
            this.lblEnterVerificationCode.TabIndex = 13;
            this.lblEnterVerificationCode.Text = "Enter Verification Code:";
            // 
            // verificationCodeTextBox1
            // 
            this.verificationCodeTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.verificationCodeTextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.verificationCodeTextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationCodeTextBox1.DefaultText = "";
            this.verificationCodeTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verificationCodeTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verificationCodeTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.DisabledState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verificationCodeTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.FocusedState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.verificationCodeTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verificationCodeTextBox1.HoverState.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Location = new System.Drawing.Point(165, 189);
            this.verificationCodeTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verificationCodeTextBox1.Name = "verificationCodeTextBox1";
            this.verificationCodeTextBox1.PasswordChar = '\0';
            this.verificationCodeTextBox1.PlaceholderText = "";
            this.verificationCodeTextBox1.SelectedText = "";
            this.verificationCodeTextBox1.ShadowDecoration.Parent = this.verificationCodeTextBox1;
            this.verificationCodeTextBox1.Size = new System.Drawing.Size(38, 38);
            this.verificationCodeTextBox1.TabIndex = 0;
            // 
            // verificationPanelTransition
            // 
            this.verificationPanelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.verificationPanelTransition.Cursor = null;
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
            this.verificationPanelTransition.DefaultAnimation = animation2;
            // 
            // resetPasswordPanel
            // 
            this.resetPasswordPanel.Controls.Add(this.lblConfirmPassword);
            this.resetPasswordPanel.Controls.Add(this.confirmPasswordTextBox);
            this.resetPasswordPanel.Controls.Add(this.newPasswordTextBox);
            this.resetPasswordPanel.Controls.Add(this.lblEnterNewPassword);
            this.resetPasswordPanel.Controls.Add(this.btnReset);
            this.resetPasswordPanelTransition.SetDecoration(this.resetPasswordPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.resetPasswordPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanel.Location = new System.Drawing.Point(12, 303);
            this.resetPasswordPanel.Name = "resetPasswordPanel";
            this.resetPasswordPanel.ShadowDecoration.Parent = this.resetPasswordPanel;
            this.resetPasswordPanel.Size = new System.Drawing.Size(561, 480);
            this.resetPasswordPanel.TabIndex = 15;
            this.resetPasswordPanel.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.verificationPanelTransition.SetDecoration(this.lblConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanelTransition.SetDecoration(this.lblConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(141, 200);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.lblConfirmPassword.TabIndex = 17;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Animated = true;
            this.confirmPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.confirmPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.confirmPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.confirmPasswordTextBox.DefaultText = "";
            this.confirmPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.DisabledState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.FocusedState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.HoverState.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(146, 238);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '\0';
            this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.ShadowDecoration.Parent = this.confirmPasswordTextBox;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.confirmPasswordTextBox.TabIndex = 16;
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Animated = true;
            this.newPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPasswordPanelTransition.SetDecoration(this.newPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.newPasswordTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.newPasswordTextBox.DefaultText = "";
            this.newPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.DisabledState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.FocusedState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTextBox.HoverState.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Location = new System.Drawing.Point(144, 146);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '\0';
            this.newPasswordTextBox.PlaceholderText = "New Password";
            this.newPasswordTextBox.SelectedText = "";
            this.newPasswordTextBox.ShadowDecoration.Parent = this.newPasswordTextBox;
            this.newPasswordTextBox.Size = new System.Drawing.Size(258, 36);
            this.newPasswordTextBox.TabIndex = 15;
            // 
            // lblEnterNewPassword
            // 
            this.lblEnterNewPassword.AutoSize = true;
            this.verificationPanelTransition.SetDecoration(this.lblEnterNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanelTransition.SetDecoration(this.lblEnterNewPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEnterNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEnterNewPassword.Location = new System.Drawing.Point(141, 105);
            this.lblEnterNewPassword.Name = "lblEnterNewPassword";
            this.lblEnterNewPassword.Size = new System.Drawing.Size(191, 24);
            this.lblEnterNewPassword.TabIndex = 15;
            this.lblEnterNewPassword.Text = "Enter New Password:";
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.resetPasswordPanelTransition.SetDecoration(this.btnReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.btnReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(192, 313);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(175, 53);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.verificationPanelTransition.SetDecoration(this.lblForgotPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resetPasswordPanelTransition.SetDecoration(this.lblForgotPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblForgotPassword.Location = new System.Drawing.Point(45, 91);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(235, 31);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.Text = "Forget Password?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.guna2Panel1.Controls.Add(this.passwordIcon);
            this.guna2Panel1.Controls.Add(this.lblForgotPassword);
            this.guna2Panel1.Controls.Add(this.lblYouCanReset);
            this.resetPasswordPanelTransition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, 24);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(362, 202);
            this.guna2Panel1.TabIndex = 17;
            // 
            // resetPasswordPanelTransition
            // 
            this.resetPasswordPanelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlideAndRotate;
            this.resetPasswordPanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 0.3F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.resetPasswordPanelTransition.DefaultAnimation = animation1;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.resetPasswordPanel);
            this.Controls.Add(this.sendVerificationCodePanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.btnSendVerificationCode);
            this.Controls.Add(this.recoveryEmailTextBox);
            this.Controls.Add(this.lblEnterRegisteredEmail);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resetPasswordPanelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.verificationPanelTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.sendVerificationCodePanel.ResumeLayout(false);
            this.sendVerificationCodePanel.PerformLayout();
            this.resetPasswordPanel.ResumeLayout(false);
            this.resetPasswordPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private System.Windows.Forms.Label lblYouCanReset;
        private Guna.UI2.WinForms.Guna2PictureBox passwordIcon;
        private Guna.UI2.WinForms.Guna2TextBox recoveryEmailTextBox;
        private System.Windows.Forms.Label lblEnterRegisteredEmail;
        private Guna.UI2.WinForms.Guna2Button btnSendVerificationCode;
        public Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel sendVerificationCodePanel;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private System.Windows.Forms.Label lblEnterVerificationCode;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox1;
        private Guna.UI2.WinForms.Guna2Transition verificationPanelTransition;
        private Guna.UI2.WinForms.Guna2Panel resetPasswordPanel;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox newPasswordTextBox;
        private System.Windows.Forms.Label lblEnterNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Transition resetPasswordPanelTransition;
        private System.Windows.Forms.Label lblForgotPassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox4;
        private Guna.UI2.WinForms.Guna2TextBox verificationCodeTextBox5;
    }
}