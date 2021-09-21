namespace webTRON_Management_Software.Views.Doctor
{
    partial class TreatmentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentWindow));
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.lblMinus2 = new System.Windows.Forms.Label();
            this.lblMinus1 = new System.Windows.Forms.Label();
            this.yearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRegistrationId = new System.Windows.Forms.Label();
            this.patientSerialNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPtn = new System.Windows.Forms.Label();
            this.prescriptionPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.prescriptionDisplayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.oldPrescriptionPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblprescriptionDateOutput = new System.Windows.Forms.Label();
            this.prescriptionHistory1TextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrescribedBy = new System.Windows.Forms.Label();
            this.lblPrescriptionTitleOutput = new System.Windows.Forms.Label();
            this.lblPrescribedDoctorNameOutput = new System.Windows.Forms.Label();
            this.todaysPrescriptionPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTodayPrescribedDoctorNameOutput = new System.Windows.Forms.Label();
            this.lblTodayPrescribedBy = new System.Windows.Forms.Label();
            this.lblTodaysPrescriptionTitleOutput = new System.Windows.Forms.Label();
            this.lblTodaysDateOutput = new System.Windows.Forms.Label();
            this.newPrescriptionTextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.newTopic1TextField = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddTopic = new Guna.UI2.WinForms.Guna2Button();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblReferredTo = new System.Windows.Forms.Label();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnTests = new Guna.UI2.WinForms.Guna2Button();
            this.btnOthers = new Guna.UI2.WinForms.Guna2Button();
            this.registrationDateOutput = new System.Windows.Forms.Label();
            this.lblFirstNameOutput = new System.Windows.Forms.Label();
            this.lblAddressOutput = new System.Windows.Forms.Label();
            this.lblContactOutput = new System.Windows.Forms.Label();
            this.lblAgeOutput = new System.Windows.Forms.Label();
            this.lblReferredToOutput = new System.Windows.Forms.Label();
            this.lblGenderOutput = new System.Windows.Forms.Label();
            this.lblLastNameOutput = new System.Windows.Forms.Label();
            this.dragOnTreatmentPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewHistory = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            this.prescriptionPanel.SuspendLayout();
            this.prescriptionDisplayPanel.SuspendLayout();
            this.oldPrescriptionPanel.SuspendLayout();
            this.todaysPrescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(911, 27);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 26;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(960, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 25;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.activeForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.activePanel.Location = new System.Drawing.Point(-1, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 28;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(64, 40);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(88, 20);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Dashboard";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(0, 15);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(49, 45);
            this.activeUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.activeUserPicture.TabIndex = 0;
            this.activeUserPicture.TabStop = false;
            // 
            // activeUserName
            // 
            this.activeUserName.AutoSize = true;
            this.activeUserName.BackColor = System.Drawing.Color.Transparent;
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(64, 9);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // lblMinus2
            // 
            this.lblMinus2.AutoSize = true;
            this.lblMinus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus2.Location = new System.Drawing.Point(530, 19);
            this.lblMinus2.Name = "lblMinus2";
            this.lblMinus2.Size = new System.Drawing.Size(19, 26);
            this.lblMinus2.TabIndex = 71;
            this.lblMinus2.Text = "-";
            // 
            // lblMinus1
            // 
            this.lblMinus1.AutoSize = true;
            this.lblMinus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus1.Location = new System.Drawing.Point(401, 19);
            this.lblMinus1.Name = "lblMinus1";
            this.lblMinus1.Size = new System.Drawing.Size(19, 26);
            this.lblMinus1.TabIndex = 70;
            this.lblMinus1.Text = "-";
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.Transparent;
            this.yearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.yearComboBox.FocusedState.Parent = this.yearComboBox;
            this.yearComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.HoverState.Parent = this.yearComboBox;
            this.yearComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.yearComboBox.ItemHeight = 30;
            this.yearComboBox.Items.AddRange(new object[] {
            "21",
            "20",
            "19",
            "18",
            "17",
            "16",
            "15",
            "14",
            "13",
            "12"});
            this.yearComboBox.ItemsAppearance.Parent = this.yearComboBox;
            this.yearComboBox.Location = new System.Drawing.Point(439, 15);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.ShadowDecoration.Parent = this.yearComboBox;
            this.yearComboBox.Size = new System.Drawing.Size(60, 36);
            this.yearComboBox.TabIndex = 69;
            this.yearComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRegistrationId
            // 
            this.lblRegistrationId.AutoSize = true;
            this.lblRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationId.Location = new System.Drawing.Point(235, 28);
            this.lblRegistrationId.Name = "lblRegistrationId";
            this.lblRegistrationId.Size = new System.Drawing.Size(105, 17);
            this.lblRegistrationId.TabIndex = 68;
            this.lblRegistrationId.Text = "Registration ID:";
            // 
            // patientSerialNumberTextBox
            // 
            this.patientSerialNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientSerialNumberTextBox.DefaultText = "";
            this.patientSerialNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patientSerialNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patientSerialNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patientSerialNumberTextBox.DisabledState.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patientSerialNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientSerialNumberTextBox.FocusedState.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.patientSerialNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patientSerialNumberTextBox.HoverState.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Location = new System.Drawing.Point(581, 15);
            this.patientSerialNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientSerialNumberTextBox.Name = "patientSerialNumberTextBox";
            this.patientSerialNumberTextBox.PasswordChar = '\0';
            this.patientSerialNumberTextBox.PlaceholderText = "";
            this.patientSerialNumberTextBox.SelectedText = "";
            this.patientSerialNumberTextBox.ShadowDecoration.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Size = new System.Drawing.Size(94, 30);
            this.patientSerialNumberTextBox.TabIndex = 66;
            this.patientSerialNumberTextBox.TextChanged += new System.EventHandler(this.PatientSerialNumberTextBox_TextChanged);
            // 
            // lblPtn
            // 
            this.lblPtn.AutoSize = true;
            this.lblPtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtn.Location = new System.Drawing.Point(345, 25);
            this.lblPtn.Name = "lblPtn";
            this.lblPtn.Size = new System.Drawing.Size(39, 20);
            this.lblPtn.TabIndex = 72;
            this.lblPtn.Text = "PTN";
            // 
            // prescriptionPanel
            // 
            this.prescriptionPanel.AutoScroll = true;
            this.prescriptionPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prescriptionPanel.Controls.Add(this.btnNext);
            this.prescriptionPanel.Controls.Add(this.prescriptionDisplayPanel);
            this.prescriptionPanel.Controls.Add(this.newTopic1TextField);
            this.prescriptionPanel.Controls.Add(this.btnAddTopic);
            this.prescriptionPanel.Location = new System.Drawing.Point(-1, 160);
            this.prescriptionPanel.Name = "prescriptionPanel";
            this.prescriptionPanel.ShadowDecoration.Parent = this.prescriptionPanel;
            this.prescriptionPanel.Size = new System.Drawing.Size(1002, 453);
            this.prescriptionPanel.TabIndex = 73;
            this.prescriptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PrescriptionPanel_Paint);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(870, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(116, 42);
            this.btnNext.TabIndex = 91;
            this.btnNext.Text = "NEXT";
            // 
            // prescriptionDisplayPanel
            // 
            this.prescriptionDisplayPanel.AllowDrop = true;
            this.prescriptionDisplayPanel.AutoScroll = true;
            this.prescriptionDisplayPanel.Controls.Add(this.oldPrescriptionPanel);
            this.prescriptionDisplayPanel.Controls.Add(this.todaysPrescriptionPanel);
            this.prescriptionDisplayPanel.Location = new System.Drawing.Point(168, 8);
            this.prescriptionDisplayPanel.Name = "prescriptionDisplayPanel";
            this.prescriptionDisplayPanel.ShadowDecoration.Parent = this.prescriptionDisplayPanel;
            this.prescriptionDisplayPanel.Size = new System.Drawing.Size(831, 394);
            this.prescriptionDisplayPanel.TabIndex = 92;
            // 
            // oldPrescriptionPanel
            // 
            this.oldPrescriptionPanel.BackColor = System.Drawing.Color.DimGray;
            this.oldPrescriptionPanel.Controls.Add(this.lblprescriptionDateOutput);
            this.oldPrescriptionPanel.Controls.Add(this.prescriptionHistory1TextField);
            this.oldPrescriptionPanel.Controls.Add(this.lblPrescribedBy);
            this.oldPrescriptionPanel.Controls.Add(this.lblPrescriptionTitleOutput);
            this.oldPrescriptionPanel.Controls.Add(this.lblPrescribedDoctorNameOutput);
            this.oldPrescriptionPanel.Location = new System.Drawing.Point(0, 195);
            this.oldPrescriptionPanel.Name = "oldPrescriptionPanel";
            this.oldPrescriptionPanel.ShadowDecoration.Parent = this.oldPrescriptionPanel;
            this.oldPrescriptionPanel.Size = new System.Drawing.Size(804, 194);
            this.oldPrescriptionPanel.TabIndex = 6;
            this.oldPrescriptionPanel.Visible = false;
            // 
            // lblprescriptionDateOutput
            // 
            this.lblprescriptionDateOutput.AutoSize = true;
            this.lblprescriptionDateOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblprescriptionDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprescriptionDateOutput.Location = new System.Drawing.Point(10, 2);
            this.lblprescriptionDateOutput.Name = "lblprescriptionDateOutput";
            this.lblprescriptionDateOutput.Size = new System.Drawing.Size(97, 15);
            this.lblprescriptionDateOutput.TabIndex = 6;
            this.lblprescriptionDateOutput.Text = "prescriptionDate";
            // 
            // prescriptionHistory1TextField
            // 
            this.prescriptionHistory1TextField.AutoSize = true;
            this.prescriptionHistory1TextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prescriptionHistory1TextField.BorderColor = System.Drawing.Color.Maroon;
            this.prescriptionHistory1TextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prescriptionHistory1TextField.DefaultText = "";
            this.prescriptionHistory1TextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prescriptionHistory1TextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prescriptionHistory1TextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prescriptionHistory1TextField.DisabledState.Parent = this.prescriptionHistory1TextField;
            this.prescriptionHistory1TextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prescriptionHistory1TextField.FillColor = System.Drawing.Color.DarkRed;
            this.prescriptionHistory1TextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prescriptionHistory1TextField.FocusedState.Parent = this.prescriptionHistory1TextField;
            this.prescriptionHistory1TextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prescriptionHistory1TextField.HoverState.Parent = this.prescriptionHistory1TextField;
            this.prescriptionHistory1TextField.Location = new System.Drawing.Point(12, 20);
            this.prescriptionHistory1TextField.Multiline = true;
            this.prescriptionHistory1TextField.Name = "prescriptionHistory1TextField";
            this.prescriptionHistory1TextField.PasswordChar = '\0';
            this.prescriptionHistory1TextField.PlaceholderText = "";
            this.prescriptionHistory1TextField.ReadOnly = true;
            this.prescriptionHistory1TextField.SelectedText = "";
            this.prescriptionHistory1TextField.ShadowDecoration.Parent = this.prescriptionHistory1TextField;
            this.prescriptionHistory1TextField.Size = new System.Drawing.Size(789, 153);
            this.prescriptionHistory1TextField.TabIndex = 1;
            // 
            // lblPrescribedBy
            // 
            this.lblPrescribedBy.AutoSize = true;
            this.lblPrescribedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescribedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescribedBy.Location = new System.Drawing.Point(556, 173);
            this.lblPrescribedBy.Name = "lblPrescribedBy";
            this.lblPrescribedBy.Size = new System.Drawing.Size(84, 15);
            this.lblPrescribedBy.TabIndex = 4;
            this.lblPrescribedBy.Text = "prescribed By:";
            // 
            // lblPrescriptionTitleOutput
            // 
            this.lblPrescriptionTitleOutput.AutoSize = true;
            this.lblPrescriptionTitleOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescriptionTitleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionTitleOutput.Location = new System.Drawing.Point(119, 2);
            this.lblPrescriptionTitleOutput.Name = "lblPrescriptionTitleOutput";
            this.lblPrescriptionTitleOutput.Size = new System.Drawing.Size(94, 15);
            this.lblPrescriptionTitleOutput.TabIndex = 3;
            this.lblPrescriptionTitleOutput.Text = "prescriptionTitle";
            // 
            // lblPrescribedDoctorNameOutput
            // 
            this.lblPrescribedDoctorNameOutput.AutoSize = true;
            this.lblPrescribedDoctorNameOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescribedDoctorNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescribedDoctorNameOutput.Location = new System.Drawing.Point(651, 173);
            this.lblPrescribedDoctorNameOutput.Name = "lblPrescribedDoctorNameOutput";
            this.lblPrescribedDoctorNameOutput.Size = new System.Drawing.Size(135, 15);
            this.lblPrescribedDoctorNameOutput.TabIndex = 5;
            this.lblPrescribedDoctorNameOutput.Text = "prescribedDoctorName";
            // 
            // todaysPrescriptionPanel
            // 
            this.todaysPrescriptionPanel.Controls.Add(this.lblTodayPrescribedDoctorNameOutput);
            this.todaysPrescriptionPanel.Controls.Add(this.lblTodayPrescribedBy);
            this.todaysPrescriptionPanel.Controls.Add(this.lblTodaysPrescriptionTitleOutput);
            this.todaysPrescriptionPanel.Controls.Add(this.lblTodaysDateOutput);
            this.todaysPrescriptionPanel.Controls.Add(this.newPrescriptionTextField);
            this.todaysPrescriptionPanel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.todaysPrescriptionPanel.Location = new System.Drawing.Point(0, 0);
            this.todaysPrescriptionPanel.Name = "todaysPrescriptionPanel";
            this.todaysPrescriptionPanel.ShadowDecoration.Parent = this.todaysPrescriptionPanel;
            this.todaysPrescriptionPanel.Size = new System.Drawing.Size(804, 194);
            this.todaysPrescriptionPanel.TabIndex = 7;
            // 
            // lblTodayPrescribedDoctorNameOutput
            // 
            this.lblTodayPrescribedDoctorNameOutput.AutoSize = true;
            this.lblTodayPrescribedDoctorNameOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayPrescribedDoctorNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPrescribedDoctorNameOutput.Location = new System.Drawing.Point(652, 169);
            this.lblTodayPrescribedDoctorNameOutput.Name = "lblTodayPrescribedDoctorNameOutput";
            this.lblTodayPrescribedDoctorNameOutput.Size = new System.Drawing.Size(135, 15);
            this.lblTodayPrescribedDoctorNameOutput.TabIndex = 7;
            this.lblTodayPrescribedDoctorNameOutput.Text = "prescribedDoctorName";
            // 
            // lblTodayPrescribedBy
            // 
            this.lblTodayPrescribedBy.AutoSize = true;
            this.lblTodayPrescribedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayPrescribedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPrescribedBy.Location = new System.Drawing.Point(553, 169);
            this.lblTodayPrescribedBy.Name = "lblTodayPrescribedBy";
            this.lblTodayPrescribedBy.Size = new System.Drawing.Size(84, 15);
            this.lblTodayPrescribedBy.TabIndex = 7;
            this.lblTodayPrescribedBy.Text = "prescribed By:";
            // 
            // lblTodaysPrescriptionTitleOutput
            // 
            this.lblTodaysPrescriptionTitleOutput.AutoSize = true;
            this.lblTodaysPrescriptionTitleOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTodaysPrescriptionTitleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysPrescriptionTitleOutput.Location = new System.Drawing.Point(75, 0);
            this.lblTodaysPrescriptionTitleOutput.Name = "lblTodaysPrescriptionTitleOutput";
            this.lblTodaysPrescriptionTitleOutput.Size = new System.Drawing.Size(48, 17);
            this.lblTodaysPrescriptionTitleOutput.TabIndex = 8;
            this.lblTodaysPrescriptionTitleOutput.Text = ": ____";
            // 
            // lblTodaysDateOutput
            // 
            this.lblTodaysDateOutput.AutoSize = true;
            this.lblTodaysDateOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTodaysDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDateOutput.Location = new System.Drawing.Point(9, 2);
            this.lblTodaysDateOutput.Name = "lblTodaysDateOutput";
            this.lblTodaysDateOutput.Size = new System.Drawing.Size(71, 15);
            this.lblTodaysDateOutput.TabIndex = 7;
            this.lblTodaysDateOutput.Text = "yyyy-mm-dd";
            // 
            // newPrescriptionTextField
            // 
            this.newPrescriptionTextField.BackColor = System.Drawing.Color.White;
            this.newPrescriptionTextField.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.newPrescriptionTextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPrescriptionTextField.DefaultText = "";
            this.newPrescriptionTextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPrescriptionTextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPrescriptionTextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPrescriptionTextField.DisabledState.Parent = this.newPrescriptionTextField;
            this.newPrescriptionTextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPrescriptionTextField.FillColor = System.Drawing.Color.WhiteSmoke;
            this.newPrescriptionTextField.FocusedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.newPrescriptionTextField.FocusedState.Parent = this.newPrescriptionTextField;
            this.newPrescriptionTextField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.newPrescriptionTextField.HoverState.BorderColor = System.Drawing.Color.White;
            this.newPrescriptionTextField.HoverState.Parent = this.newPrescriptionTextField;
            this.newPrescriptionTextField.Location = new System.Drawing.Point(3, 18);
            this.newPrescriptionTextField.Multiline = true;
            this.newPrescriptionTextField.Name = "newPrescriptionTextField";
            this.newPrescriptionTextField.PasswordChar = '\0';
            this.newPrescriptionTextField.PlaceholderText = "";
            this.newPrescriptionTextField.SelectedText = "";
            this.newPrescriptionTextField.ShadowDecoration.Parent = this.newPrescriptionTextField;
            this.newPrescriptionTextField.Size = new System.Drawing.Size(798, 150);
            this.newPrescriptionTextField.TabIndex = 0;
            // 
            // newTopic1TextField
            // 
            this.newTopic1TextField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newTopic1TextField.DefaultText = "";
            this.newTopic1TextField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newTopic1TextField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newTopic1TextField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newTopic1TextField.DisabledState.Parent = this.newTopic1TextField;
            this.newTopic1TextField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newTopic1TextField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newTopic1TextField.FocusedState.Parent = this.newTopic1TextField;
            this.newTopic1TextField.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.newTopic1TextField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newTopic1TextField.HoverState.Parent = this.newTopic1TextField;
            this.newTopic1TextField.Location = new System.Drawing.Point(4, 37);
            this.newTopic1TextField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newTopic1TextField.Name = "newTopic1TextField";
            this.newTopic1TextField.PasswordChar = '\0';
            this.newTopic1TextField.PlaceholderText = "New Topic";
            this.newTopic1TextField.SelectedText = "";
            this.newTopic1TextField.ShadowDecoration.Parent = this.newTopic1TextField;
            this.newTopic1TextField.Size = new System.Drawing.Size(149, 29);
            this.newTopic1TextField.TabIndex = 1;
            this.newTopic1TextField.TextChanged += new System.EventHandler(this.NewTopic1TextField_TextChanged);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.CheckedState.Parent = this.btnAddTopic;
            this.btnAddTopic.CustomImages.Parent = this.btnAddTopic;
            this.btnAddTopic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnAddTopic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddTopic.ForeColor = System.Drawing.Color.White;
            this.btnAddTopic.HoverState.Parent = this.btnAddTopic;
            this.btnAddTopic.Image = global::webTRON_Management_Software.Properties.Resources.PlusSign;
            this.btnAddTopic.Location = new System.Drawing.Point(4, 82);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.ShadowDecoration.Parent = this.btnAddTopic;
            this.btnAddTopic.Size = new System.Drawing.Size(149, 33);
            this.btnAddTopic.TabIndex = 0;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.Click += new System.EventHandler(this.BtnAddTopic_Click);
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(165, 76);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(115, 17);
            this.lblRegistrationDate.TabIndex = 74;
            this.lblRegistrationDate.Text = "Registered Date:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(234, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(466, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 76;
            this.lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(470, 102);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 17);
            this.lblContact.TabIndex = 77;
            this.lblContact.Text = "Contact:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(740, 74);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 78;
            this.lblAge.Text = "Age:";
            // 
            // lblReferredTo
            // 
            this.lblReferredTo.AutoSize = true;
            this.lblReferredTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferredTo.Location = new System.Drawing.Point(688, 102);
            this.lblReferredTo.Name = "lblReferredTo";
            this.lblReferredTo.Size = new System.Drawing.Size(89, 17);
            this.lblReferredTo.TabIndex = 79;
            this.lblReferredTo.Text = "Referred To:";
            // 
            // btnHistory
            // 
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.Location = new System.Drawing.Point(623, 136);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(86, 18);
            this.btnHistory.TabIndex = 80;
            this.btnHistory.Text = "History";
            // 
            // btnTests
            // 
            this.btnTests.CheckedState.Parent = this.btnTests;
            this.btnTests.CustomImages.Parent = this.btnTests;
            this.btnTests.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnTests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTests.ForeColor = System.Drawing.Color.White;
            this.btnTests.HoverState.Parent = this.btnTests;
            this.btnTests.Location = new System.Drawing.Point(807, 136);
            this.btnTests.Name = "btnTests";
            this.btnTests.ShadowDecoration.Parent = this.btnTests;
            this.btnTests.Size = new System.Drawing.Size(86, 18);
            this.btnTests.TabIndex = 81;
            this.btnTests.Text = "Tests";
            // 
            // btnOthers
            // 
            this.btnOthers.CheckedState.Parent = this.btnOthers;
            this.btnOthers.CustomImages.Parent = this.btnOthers;
            this.btnOthers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOthers.ForeColor = System.Drawing.Color.White;
            this.btnOthers.HoverState.Parent = this.btnOthers;
            this.btnOthers.Location = new System.Drawing.Point(899, 136);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.ShadowDecoration.Parent = this.btnOthers;
            this.btnOthers.Size = new System.Drawing.Size(86, 18);
            this.btnOthers.TabIndex = 82;
            this.btnOthers.Text = "Others";
            // 
            // registrationDateOutput
            // 
            this.registrationDateOutput.AutoSize = true;
            this.registrationDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDateOutput.Location = new System.Drawing.Point(290, 76);
            this.registrationDateOutput.Name = "registrationDateOutput";
            this.registrationDateOutput.Size = new System.Drawing.Size(109, 17);
            this.registrationDateOutput.TabIndex = 83;
            this.registrationDateOutput.Text = "registrationDate";
            // 
            // lblFirstNameOutput
            // 
            this.lblFirstNameOutput.AutoSize = true;
            this.lblFirstNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameOutput.Location = new System.Drawing.Point(289, 106);
            this.lblFirstNameOutput.Name = "lblFirstNameOutput";
            this.lblFirstNameOutput.Size = new System.Drawing.Size(70, 17);
            this.lblFirstNameOutput.TabIndex = 84;
            this.lblFirstNameOutput.Text = "Firstname";
            // 
            // lblAddressOutput
            // 
            this.lblAddressOutput.AutoSize = true;
            this.lblAddressOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressOutput.Location = new System.Drawing.Point(537, 74);
            this.lblAddressOutput.Name = "lblAddressOutput";
            this.lblAddressOutput.Size = new System.Drawing.Size(102, 17);
            this.lblAddressOutput.TabIndex = 85;
            this.lblAddressOutput.Text = "addressOutput";
            // 
            // lblContactOutput
            // 
            this.lblContactOutput.AutoSize = true;
            this.lblContactOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactOutput.Location = new System.Drawing.Point(539, 102);
            this.lblContactOutput.Name = "lblContactOutput";
            this.lblContactOutput.Size = new System.Drawing.Size(97, 17);
            this.lblContactOutput.TabIndex = 86;
            this.lblContactOutput.Text = "contactOutput";
            // 
            // lblAgeOutput
            // 
            this.lblAgeOutput.AutoSize = true;
            this.lblAgeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeOutput.Location = new System.Drawing.Point(784, 74);
            this.lblAgeOutput.Name = "lblAgeOutput";
            this.lblAgeOutput.Size = new System.Drawing.Size(75, 17);
            this.lblAgeOutput.TabIndex = 87;
            this.lblAgeOutput.Text = "ageOutput";
            // 
            // lblReferredToOutput
            // 
            this.lblReferredToOutput.AutoSize = true;
            this.lblReferredToOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferredToOutput.Location = new System.Drawing.Point(787, 102);
            this.lblReferredToOutput.Name = "lblReferredToOutput";
            this.lblReferredToOutput.Size = new System.Drawing.Size(119, 17);
            this.lblReferredToOutput.TabIndex = 88;
            this.lblReferredToOutput.Text = "referredToOutput";
            // 
            // lblGenderOutput
            // 
            this.lblGenderOutput.AutoSize = true;
            this.lblGenderOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderOutput.Location = new System.Drawing.Point(875, 74);
            this.lblGenderOutput.Name = "lblGenderOutput";
            this.lblGenderOutput.Size = new System.Drawing.Size(96, 17);
            this.lblGenderOutput.TabIndex = 89;
            this.lblGenderOutput.Text = "genderOutput";
            // 
            // lblLastNameOutput
            // 
            this.lblLastNameOutput.AutoSize = true;
            this.lblLastNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameOutput.Location = new System.Drawing.Point(382, 104);
            this.lblLastNameOutput.Name = "lblLastNameOutput";
            this.lblLastNameOutput.Size = new System.Drawing.Size(70, 17);
            this.lblLastNameOutput.TabIndex = 90;
            this.lblLastNameOutput.Text = "Lastname";
            // 
            // dragOnTreatmentPanel
            // 
            this.dragOnTreatmentPanel.TargetControl = this;
            // 
            // btnMedicine
            // 
            this.btnMedicine.CheckedState.Parent = this.btnMedicine;
            this.btnMedicine.CustomImages.Parent = this.btnMedicine;
            this.btnMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnMedicine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.HoverState.Parent = this.btnMedicine;
            this.btnMedicine.Location = new System.Drawing.Point(715, 136);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.ShadowDecoration.Parent = this.btnMedicine;
            this.btnMedicine.Size = new System.Drawing.Size(86, 18);
            this.btnMedicine.TabIndex = 92;
            this.btnMedicine.Text = "Medicine";
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.CheckedState.Parent = this.btnViewHistory;
            this.btnViewHistory.CustomImages.Parent = this.btnViewHistory;
            this.btnViewHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnViewHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnViewHistory.ForeColor = System.Drawing.Color.White;
            this.btnViewHistory.HoverState.Parent = this.btnViewHistory;
            this.btnViewHistory.Location = new System.Drawing.Point(715, 15);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.ShadowDecoration.Parent = this.btnViewHistory;
            this.btnViewHistory.Size = new System.Drawing.Size(144, 30);
            this.btnViewHistory.TabIndex = 93;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.Click += new System.EventHandler(this.BtnViewHistory_Click);
            // 
            // TreatmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.lblLastNameOutput);
            this.Controls.Add(this.lblGenderOutput);
            this.Controls.Add(this.lblReferredToOutput);
            this.Controls.Add(this.lblAgeOutput);
            this.Controls.Add(this.lblContactOutput);
            this.Controls.Add(this.lblAddressOutput);
            this.Controls.Add(this.lblFirstNameOutput);
            this.Controls.Add(this.registrationDateOutput);
            this.Controls.Add(this.btnOthers);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblReferredTo);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.prescriptionPanel);
            this.Controls.Add(this.lblPtn);
            this.Controls.Add(this.lblMinus2);
            this.Controls.Add(this.lblMinus1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.lblRegistrationId);
            this.Controls.Add(this.patientSerialNumberTextBox);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TreatmentWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            this.prescriptionPanel.ResumeLayout(false);
            this.prescriptionDisplayPanel.ResumeLayout(false);
            this.oldPrescriptionPanel.ResumeLayout(false);
            this.oldPrescriptionPanel.PerformLayout();
            this.todaysPrescriptionPanel.ResumeLayout(false);
            this.todaysPrescriptionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private System.Windows.Forms.Label lblMinus2;
        private System.Windows.Forms.Label lblMinus1;
        private Guna.UI2.WinForms.Guna2ComboBox yearComboBox;
        private System.Windows.Forms.Label lblRegistrationId;
        private Guna.UI2.WinForms.Guna2TextBox patientSerialNumberTextBox;
        private System.Windows.Forms.Label lblPtn;
        private Guna.UI2.WinForms.Guna2Panel prescriptionPanel;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblReferredTo;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnTests;
        private Guna.UI2.WinForms.Guna2Button btnOthers;
        private System.Windows.Forms.Label registrationDateOutput;
        private System.Windows.Forms.Label lblFirstNameOutput;
        private System.Windows.Forms.Label lblAddressOutput;
        private System.Windows.Forms.Label lblContactOutput;
        private System.Windows.Forms.Label lblAgeOutput;
        private System.Windows.Forms.Label lblReferredToOutput;
        private System.Windows.Forms.Label lblGenderOutput;
        private System.Windows.Forms.Label lblLastNameOutput;
        private Guna.UI2.WinForms.Guna2TextBox newTopic1TextField;
        private Guna.UI2.WinForms.Guna2Button btnAddTopic;
        private Guna.UI2.WinForms.Guna2DragControl dragOnTreatmentPanel;
        private Guna.UI2.WinForms.Guna2Button btnMedicine;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2TextBox newPrescriptionTextField;
        private Guna.UI2.WinForms.Guna2Panel prescriptionDisplayPanel;
        private System.Windows.Forms.Label lblPrescribedDoctorNameOutput;
        private System.Windows.Forms.Label lblPrescribedBy;
        private System.Windows.Forms.Label lblPrescriptionTitleOutput;
        private Guna.UI2.WinForms.Guna2TextBox prescriptionHistory1TextField;
        private Guna.UI2.WinForms.Guna2Panel todaysPrescriptionPanel;
        private Guna.UI2.WinForms.Guna2Panel oldPrescriptionPanel;
        private System.Windows.Forms.Label lblprescriptionDateOutput;
        private System.Windows.Forms.Label lblTodayPrescribedDoctorNameOutput;
        private System.Windows.Forms.Label lblTodayPrescribedBy;
        private System.Windows.Forms.Label lblTodaysPrescriptionTitleOutput;
        private System.Windows.Forms.Label lblTodaysDateOutput;
        private Guna.UI2.WinForms.Guna2Button btnViewHistory;
    }
}