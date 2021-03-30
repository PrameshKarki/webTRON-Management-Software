
namespace webTRON_Management_Software
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.activeUserPanel = new System.Windows.Forms.Panel();
            this.currentUser = new System.Windows.Forms.Label();
            this.currentUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSex = new System.Windows.Forms.Label();
            this.isMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.isFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.isOthers = new Guna.UI2.WinForms.Guna2RadioButton();
            this.contactNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.roleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.sideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.activeUserRole = new System.Windows.Forms.Label();
            this.activeUserSidebar = new System.Windows.Forms.Label();
            this.activeUserPictureSidebar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sideBarTransition = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.activeUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentUserPicture)).BeginInit();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.sideBarTransition.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::webTRON_Management_Software.Properties.Resources.webTRONLogoWithSlogan;
            this.guna2PictureBox1.Location = new System.Drawing.Point(37, 493);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(173, 69);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_medium;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Controls.Add(this.label7);
            this.sideBarTransition.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 44);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(278, 51);
            this.guna2Panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Create Account";
            // 
            // activeUserPanel
            // 
            this.activeUserPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_small;
            this.activeUserPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activeUserPanel.Controls.Add(this.currentUser);
            this.activeUserPanel.Controls.Add(this.currentUserPicture);
            this.sideBarTransition.SetDecoration(this.activeUserPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserPanel.Location = new System.Drawing.Point(862, 45);
            this.activeUserPanel.Name = "activeUserPanel";
            this.activeUserPanel.Size = new System.Drawing.Size(124, 52);
            this.activeUserPanel.TabIndex = 15;
            // 
            // currentUser
            // 
            this.currentUser.AutoSize = true;
            this.currentUser.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.currentUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.currentUser.ForeColor = System.Drawing.Color.White;
            this.currentUser.Location = new System.Drawing.Point(59, 10);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(59, 25);
            this.currentUser.TabIndex = 10;
            this.currentUser.Text = "John";
            // 
            // currentUserPicture
            // 
            this.currentUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.currentUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.currentUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.man_picture;
            this.currentUserPicture.Location = new System.Drawing.Point(21, 10);
            this.currentUserPicture.Name = "currentUserPicture";
            this.currentUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.currentUserPicture.ShadowDecoration.Parent = this.currentUserPicture;
            this.currentUserPicture.Size = new System.Drawing.Size(30, 30);
            this.currentUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentUserPicture.TabIndex = 11;
            this.currentUserPicture.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(356, 159);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 24);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name*:";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Animated = true;
            this.firstNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sideBarTransition.SetDecoration(this.firstNameTxtBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.firstNameTxtBox.DefaultText = "";
            this.firstNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.DisabledState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxtBox.FocusedState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTxtBox.HoverState.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Location = new System.Drawing.Point(445, 155);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.PasswordChar = '\0';
            this.firstNameTxtBox.PlaceholderText = "First Name";
            this.firstNameTxtBox.SelectedText = "";
            this.firstNameTxtBox.ShadowDecoration.Parent = this.firstNameTxtBox;
            this.firstNameTxtBox.Size = new System.Drawing.Size(226, 32);
            this.firstNameTxtBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Animated = true;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sideBarTransition.SetDecoration(this.lastNameTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.FocusedState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.HoverState.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Location = new System.Drawing.Point(694, 155);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PlaceholderText = "Last Name";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.ShadowDecoration.Parent = this.lastNameTextBox;
            this.lastNameTextBox.Size = new System.Drawing.Size(219, 32);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblEmailAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmailAddress.Location = new System.Drawing.Point(355, 208);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(144, 24);
            this.lblEmailAddress.TabIndex = 21;
            this.lblEmailAddress.Text = "Email Address*:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sideBarTransition.SetDecoration(this.emailTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(506, 205);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email Address";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(407, 32);
            this.emailTextBox.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblDateOfBirth, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(355, 309);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(122, 24);
            this.lblDateOfBirth.TabIndex = 23;
            this.lblDateOfBirth.Text = "Date of Birth*:";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthPicker.CheckedState.Parent = this.dateOfBirthPicker;
            this.sideBarTransition.SetDecoration(this.dateOfBirthPicker, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dateOfBirthPicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateOfBirthPicker.ForeColor = System.Drawing.Color.White;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.HoverState.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(486, 305);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.ShadowDecoration.Parent = this.dateOfBirthPicker;
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 36);
            this.dateOfBirthPicker.TabIndex = 5;
            this.dateOfBirthPicker.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblSex, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSex.Location = new System.Drawing.Point(355, 358);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(55, 24);
            this.lblSex.TabIndex = 25;
            this.lblSex.Text = "Sex*:";
            // 
            // isMale
            // 
            this.isMale.Animated = true;
            this.isMale.AutoSize = true;
            this.isMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isMale.CheckedState.BorderThickness = 0;
            this.isMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isMale.CheckedState.InnerOffset = -4;
            this.sideBarTransition.SetDecoration(this.isMale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.isMale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isMale.Location = new System.Drawing.Point(414, 359);
            this.isMale.Name = "isMale";
            this.isMale.Size = new System.Drawing.Size(62, 25);
            this.isMale.TabIndex = 6;
            this.isMale.TabStop = true;
            this.isMale.Text = "Male";
            this.isMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isMale.UncheckedState.BorderThickness = 2;
            this.isMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isMale.UseVisualStyleBackColor = true;
            // 
            // isFemale
            // 
            this.isFemale.Animated = true;
            this.isFemale.AutoSize = true;
            this.isFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isFemale.CheckedState.BorderThickness = 0;
            this.isFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isFemale.CheckedState.InnerOffset = -4;
            this.sideBarTransition.SetDecoration(this.isFemale, Guna.UI2.AnimatorNS.DecorationType.None);
            this.isFemale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isFemale.Location = new System.Drawing.Point(496, 358);
            this.isFemale.Name = "isFemale";
            this.isFemale.Size = new System.Drawing.Size(78, 25);
            this.isFemale.TabIndex = 7;
            this.isFemale.TabStop = true;
            this.isFemale.Text = "Female";
            this.isFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isFemale.UncheckedState.BorderThickness = 2;
            this.isFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isFemale.UseVisualStyleBackColor = true;
            // 
            // isOthers
            // 
            this.isOthers.Animated = true;
            this.isOthers.AutoSize = true;
            this.isOthers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isOthers.CheckedState.BorderThickness = 0;
            this.isOthers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.isOthers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isOthers.CheckedState.InnerOffset = -4;
            this.sideBarTransition.SetDecoration(this.isOthers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.isOthers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.isOthers.Location = new System.Drawing.Point(590, 356);
            this.isOthers.Name = "isOthers";
            this.isOthers.Size = new System.Drawing.Size(75, 25);
            this.isOthers.TabIndex = 8;
            this.isOthers.TabStop = true;
            this.isOthers.Text = "Others";
            this.isOthers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.isOthers.UncheckedState.BorderThickness = 2;
            this.isOthers.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isOthers.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isOthers.UseVisualStyleBackColor = true;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Animated = true;
            this.contactNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sideBarTransition.SetDecoration(this.contactNumberTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.contactNumberTextBox.DefaultText = "";
            this.contactNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumberTextBox.DisabledState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumberTextBox.FocusedState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contactNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.contactNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactNumberTextBox.HoverState.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Location = new System.Drawing.Point(518, 398);
            this.contactNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.PasswordChar = '\0';
            this.contactNumberTextBox.PlaceholderText = "Contact Number";
            this.contactNumberTextBox.SelectedText = "";
            this.contactNumberTextBox.ShadowDecoration.Parent = this.contactNumberTextBox;
            this.contactNumberTextBox.Size = new System.Drawing.Size(174, 32);
            this.contactNumberTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(355, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Contact Number*:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Animated = true;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sideBarTransition.SetDecoration(this.addressTextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addressTextBox.DefaultText = "";
            this.addressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.DisabledState.Parent = this.addressTextBox;
            this.addressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.FocusedState.Parent = this.addressTextBox;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressTextBox.HoverState.Parent = this.addressTextBox;
            this.addressTextBox.Location = new System.Drawing.Point(457, 257);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PlaceholderText = "Address";
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.ShadowDecoration.Parent = this.addressTextBox;
            this.addressTextBox.Size = new System.Drawing.Size(239, 32);
            this.addressTextBox.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(356, 257);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(92, 24);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address*:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.lblRole, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblRole.Location = new System.Drawing.Point(355, 110);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(61, 24);
            this.lblRole.TabIndex = 33;
            this.lblRole.Text = "Role*:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sideBarTransition.SetDecoration(this.roleComboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.roleComboBox.FocusedState.Parent = this.roleComboBox;
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.HoverState.Parent = this.roleComboBox;
            this.roleComboBox.ItemHeight = 30;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Employee",
            "Accountant",
            "Administration",
            "Others"});
            this.roleComboBox.ItemsAppearance.Parent = this.roleComboBox;
            this.roleComboBox.Location = new System.Drawing.Point(430, 103);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.ShadowDecoration.Parent = this.roleComboBox;
            this.roleComboBox.Size = new System.Drawing.Size(140, 36);
            this.roleComboBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.sideBarTransition.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Enter employee information to create new account ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.sideBarTransition.SetDecoration(this.btnSubmit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(733, 505);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(180, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.sideBar.Location = new System.Drawing.Point(0, -1);
            this.sideBar.Name = "sideBar";
            this.sideBar.ShadowDecoration.Parent = this.sideBar;
            this.sideBar.Size = new System.Drawing.Size(349, 625);
            this.sideBar.TabIndex = 36;
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
            // button1
            // 
            this.sideBarTransition.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(862, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.contactNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isOthers);
            this.Controls.Add(this.isFemale);
            this.Controls.Add(this.isMale);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.activeUserPanel);
            this.sideBarTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.activeUserPanel.ResumeLayout(false);
            this.activeUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentUserPicture)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPictureSidebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel activeUserPanel;
        private System.Windows.Forms.Label currentUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox currentUserPicture;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label lblEmailAddress;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label lblDateOfBirth;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label lblSex;
        private Guna.UI2.WinForms.Guna2RadioButton isMale;
        private Guna.UI2.WinForms.Guna2RadioButton isFemale;
        private Guna.UI2.WinForms.Guna2RadioButton isOthers;
        private Guna.UI2.WinForms.Guna2TextBox contactNumberTextBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox addressTextBox;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2ComboBox roleComboBox;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Panel sideBar;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private System.Windows.Forms.Label activeUserRole;
        private System.Windows.Forms.Label activeUserSidebar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPictureSidebar;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Transition sideBarTransition;
    }
}