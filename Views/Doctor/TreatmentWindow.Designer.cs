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
            this.history_textbox_1 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.btnMinimize.Location = new System.Drawing.Point(1215, 33);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnExit.Location = new System.Drawing.Point(1280, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
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
            this.activePanel.Margin = new System.Windows.Forms.Padding(4);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(220, 98);
            this.activePanel.TabIndex = 28;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.activeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeForm.ForeColor = System.Drawing.Color.White;
            this.activeForm.Location = new System.Drawing.Point(85, 49);
            this.activeForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeForm.Name = "activeForm";
            this.activeForm.Size = new System.Drawing.Size(108, 25);
            this.activeForm.TabIndex = 21;
            this.activeForm.Text = "Dashboard";
            // 
            // activeUserPicture
            // 
            this.activeUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.activeUserPicture.Image = global::webTRON_Management_Software.Properties.Resources.avatar;
            this.activeUserPicture.Location = new System.Drawing.Point(0, 18);
            this.activeUserPicture.Margin = new System.Windows.Forms.Padding(4);
            this.activeUserPicture.Name = "activeUserPicture";
            this.activeUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.activeUserPicture.ShadowDecoration.Parent = this.activeUserPicture;
            this.activeUserPicture.Size = new System.Drawing.Size(65, 55);
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
            this.activeUserName.Location = new System.Drawing.Point(85, 11);
            this.activeUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(65, 29);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // lblMinus2
            // 
            this.lblMinus2.AutoSize = true;
            this.lblMinus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus2.Location = new System.Drawing.Point(707, 23);
            this.lblMinus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinus2.Name = "lblMinus2";
            this.lblMinus2.Size = new System.Drawing.Size(23, 31);
            this.lblMinus2.TabIndex = 71;
            this.lblMinus2.Text = "-";
            // 
            // lblMinus1
            // 
            this.lblMinus1.AutoSize = true;
            this.lblMinus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus1.Location = new System.Drawing.Point(535, 23);
            this.lblMinus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinus1.Name = "lblMinus1";
            this.lblMinus1.Size = new System.Drawing.Size(23, 31);
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
            this.yearComboBox.Location = new System.Drawing.Point(585, 18);
            this.yearComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.ShadowDecoration.Parent = this.yearComboBox;
            this.yearComboBox.Size = new System.Drawing.Size(79, 36);
            this.yearComboBox.TabIndex = 69;
            this.yearComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRegistrationId
            // 
            this.lblRegistrationId.AutoSize = true;
            this.lblRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationId.Location = new System.Drawing.Point(313, 34);
            this.lblRegistrationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationId.Name = "lblRegistrationId";
            this.lblRegistrationId.Size = new System.Drawing.Size(126, 20);
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
            this.patientSerialNumberTextBox.Location = new System.Drawing.Point(775, 18);
            this.patientSerialNumberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.patientSerialNumberTextBox.Name = "patientSerialNumberTextBox";
            this.patientSerialNumberTextBox.PasswordChar = '\0';
            this.patientSerialNumberTextBox.PlaceholderText = "";
            this.patientSerialNumberTextBox.SelectedText = "";
            this.patientSerialNumberTextBox.ShadowDecoration.Parent = this.patientSerialNumberTextBox;
            this.patientSerialNumberTextBox.Size = new System.Drawing.Size(125, 37);
            this.patientSerialNumberTextBox.TabIndex = 66;
            this.patientSerialNumberTextBox.TextChanged += new System.EventHandler(this.PatientSerialNumberTextBox_TextChanged);
            // 
            // lblPtn
            // 
            this.lblPtn.AutoSize = true;
            this.lblPtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtn.Location = new System.Drawing.Point(460, 31);
            this.lblPtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPtn.Name = "lblPtn";
            this.lblPtn.Size = new System.Drawing.Size(52, 25);
            this.lblPtn.TabIndex = 72;
            this.lblPtn.Text = "PTN";
            // 
            // prescriptionPanel
            // 
            this.prescriptionPanel.AutoScroll = true;
            this.prescriptionPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.prescriptionPanel.Controls.Add(this.btnNext);
            this.prescriptionPanel.Controls.Add(this.prescriptionDisplayPanel);
            this.prescriptionPanel.Controls.Add(this.history_textbox_1);
            this.prescriptionPanel.Controls.Add(this.btnAddTopic);
            this.prescriptionPanel.Location = new System.Drawing.Point(-1, 197);
            this.prescriptionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.prescriptionPanel.Name = "prescriptionPanel";
            this.prescriptionPanel.ShadowDecoration.Parent = this.prescriptionPanel;
            this.prescriptionPanel.Size = new System.Drawing.Size(1336, 558);
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
            this.btnNext.Location = new System.Drawing.Point(1160, 502);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(155, 52);
            this.btnNext.TabIndex = 91;
            this.btnNext.Text = "NEXT";
            // 
            // prescriptionDisplayPanel
            // 
            this.prescriptionDisplayPanel.AllowDrop = true;
            this.prescriptionDisplayPanel.AutoScroll = true;
            this.prescriptionDisplayPanel.Controls.Add(this.oldPrescriptionPanel);
            this.prescriptionDisplayPanel.Controls.Add(this.todaysPrescriptionPanel);
            this.prescriptionDisplayPanel.Location = new System.Drawing.Point(224, 10);
            this.prescriptionDisplayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.prescriptionDisplayPanel.Name = "prescriptionDisplayPanel";
            this.prescriptionDisplayPanel.ShadowDecoration.Parent = this.prescriptionDisplayPanel;
            this.prescriptionDisplayPanel.Size = new System.Drawing.Size(1108, 485);
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
            this.oldPrescriptionPanel.Location = new System.Drawing.Point(0, 240);
            this.oldPrescriptionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.oldPrescriptionPanel.Name = "oldPrescriptionPanel";
            this.oldPrescriptionPanel.ShadowDecoration.Parent = this.oldPrescriptionPanel;
            this.oldPrescriptionPanel.Size = new System.Drawing.Size(1072, 239);
            this.oldPrescriptionPanel.TabIndex = 6;
            this.oldPrescriptionPanel.Visible = false;
            // 
            // lblprescriptionDateOutput
            // 
            this.lblprescriptionDateOutput.AutoSize = true;
            this.lblprescriptionDateOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblprescriptionDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprescriptionDateOutput.Location = new System.Drawing.Point(13, 2);
            this.lblprescriptionDateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprescriptionDateOutput.Name = "lblprescriptionDateOutput";
            this.lblprescriptionDateOutput.Size = new System.Drawing.Size(116, 18);
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
            this.prescriptionHistory1TextField.Location = new System.Drawing.Point(16, 25);
            this.prescriptionHistory1TextField.Margin = new System.Windows.Forms.Padding(5);
            this.prescriptionHistory1TextField.Multiline = true;
            this.prescriptionHistory1TextField.Name = "prescriptionHistory1TextField";
            this.prescriptionHistory1TextField.PasswordChar = '\0';
            this.prescriptionHistory1TextField.PlaceholderText = "";
            this.prescriptionHistory1TextField.ReadOnly = true;
            this.prescriptionHistory1TextField.SelectedText = "";
            this.prescriptionHistory1TextField.ShadowDecoration.Parent = this.prescriptionHistory1TextField;
            this.prescriptionHistory1TextField.Size = new System.Drawing.Size(1052, 188);
            this.prescriptionHistory1TextField.TabIndex = 1;
            // 
            // lblPrescribedBy
            // 
            this.lblPrescribedBy.AutoSize = true;
            this.lblPrescribedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescribedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescribedBy.Location = new System.Drawing.Point(741, 213);
            this.lblPrescribedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescribedBy.Name = "lblPrescribedBy";
            this.lblPrescribedBy.Size = new System.Drawing.Size(102, 18);
            this.lblPrescribedBy.TabIndex = 4;
            this.lblPrescribedBy.Text = "prescribed By:";
            // 
            // lblPrescriptionTitleOutput
            // 
            this.lblPrescriptionTitleOutput.AutoSize = true;
            this.lblPrescriptionTitleOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescriptionTitleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionTitleOutput.Location = new System.Drawing.Point(159, 2);
            this.lblPrescriptionTitleOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescriptionTitleOutput.Name = "lblPrescriptionTitleOutput";
            this.lblPrescriptionTitleOutput.Size = new System.Drawing.Size(112, 18);
            this.lblPrescriptionTitleOutput.TabIndex = 3;
            this.lblPrescriptionTitleOutput.Text = "prescriptionTitle";
            // 
            // lblPrescribedDoctorNameOutput
            // 
            this.lblPrescribedDoctorNameOutput.AutoSize = true;
            this.lblPrescribedDoctorNameOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescribedDoctorNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescribedDoctorNameOutput.Location = new System.Drawing.Point(868, 213);
            this.lblPrescribedDoctorNameOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescribedDoctorNameOutput.Name = "lblPrescribedDoctorNameOutput";
            this.lblPrescribedDoctorNameOutput.Size = new System.Drawing.Size(163, 18);
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
            this.todaysPrescriptionPanel.Margin = new System.Windows.Forms.Padding(4);
            this.todaysPrescriptionPanel.Name = "todaysPrescriptionPanel";
            this.todaysPrescriptionPanel.ShadowDecoration.Parent = this.todaysPrescriptionPanel;
            this.todaysPrescriptionPanel.Size = new System.Drawing.Size(1072, 239);
            this.todaysPrescriptionPanel.TabIndex = 7;
            // 
            // lblTodayPrescribedDoctorNameOutput
            // 
            this.lblTodayPrescribedDoctorNameOutput.AutoSize = true;
            this.lblTodayPrescribedDoctorNameOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayPrescribedDoctorNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPrescribedDoctorNameOutput.Location = new System.Drawing.Point(869, 208);
            this.lblTodayPrescribedDoctorNameOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayPrescribedDoctorNameOutput.Name = "lblTodayPrescribedDoctorNameOutput";
            this.lblTodayPrescribedDoctorNameOutput.Size = new System.Drawing.Size(163, 18);
            this.lblTodayPrescribedDoctorNameOutput.TabIndex = 7;
            this.lblTodayPrescribedDoctorNameOutput.Text = "prescribedDoctorName";
            // 
            // lblTodayPrescribedBy
            // 
            this.lblTodayPrescribedBy.AutoSize = true;
            this.lblTodayPrescribedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblTodayPrescribedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayPrescribedBy.Location = new System.Drawing.Point(737, 208);
            this.lblTodayPrescribedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayPrescribedBy.Name = "lblTodayPrescribedBy";
            this.lblTodayPrescribedBy.Size = new System.Drawing.Size(102, 18);
            this.lblTodayPrescribedBy.TabIndex = 7;
            this.lblTodayPrescribedBy.Text = "prescribed By:";
            // 
            // lblTodaysPrescriptionTitleOutput
            // 
            this.lblTodaysPrescriptionTitleOutput.AutoSize = true;
            this.lblTodaysPrescriptionTitleOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTodaysPrescriptionTitleOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysPrescriptionTitleOutput.Location = new System.Drawing.Point(100, 0);
            this.lblTodaysPrescriptionTitleOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodaysPrescriptionTitleOutput.Name = "lblTodaysPrescriptionTitleOutput";
            this.lblTodaysPrescriptionTitleOutput.Size = new System.Drawing.Size(55, 20);
            this.lblTodaysPrescriptionTitleOutput.TabIndex = 8;
            this.lblTodaysPrescriptionTitleOutput.Text = ": ____";
            // 
            // lblTodaysDateOutput
            // 
            this.lblTodaysDateOutput.AutoSize = true;
            this.lblTodaysDateOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblTodaysDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDateOutput.Location = new System.Drawing.Point(12, 2);
            this.lblTodaysDateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodaysDateOutput.Name = "lblTodaysDateOutput";
            this.lblTodaysDateOutput.Size = new System.Drawing.Size(88, 18);
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
            this.newPrescriptionTextField.Location = new System.Drawing.Point(4, 22);
            this.newPrescriptionTextField.Margin = new System.Windows.Forms.Padding(5);
            this.newPrescriptionTextField.Multiline = true;
            this.newPrescriptionTextField.Name = "newPrescriptionTextField";
            this.newPrescriptionTextField.PasswordChar = '\0';
            this.newPrescriptionTextField.PlaceholderText = "";
            this.newPrescriptionTextField.SelectedText = "";
            this.newPrescriptionTextField.ShadowDecoration.Parent = this.newPrescriptionTextField;
            this.newPrescriptionTextField.Size = new System.Drawing.Size(1064, 185);
            this.newPrescriptionTextField.TabIndex = 0;
            this.newPrescriptionTextField.TextChanged += new System.EventHandler(this.newPrescriptionTextField_TextChanged);
            // 
            // history_textbox_1
            // 
            this.history_textbox_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.history_textbox_1.DefaultText = "";
            this.history_textbox_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.history_textbox_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.history_textbox_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.history_textbox_1.DisabledState.Parent = this.history_textbox_1;
            this.history_textbox_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.history_textbox_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.history_textbox_1.FocusedState.Parent = this.history_textbox_1;
            this.history_textbox_1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.history_textbox_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.history_textbox_1.HoverState.Parent = this.history_textbox_1;
            this.history_textbox_1.Location = new System.Drawing.Point(5, 46);
            this.history_textbox_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.history_textbox_1.Name = "history_textbox_1";
            this.history_textbox_1.PasswordChar = '\0';
            this.history_textbox_1.PlaceholderText = "New Topic";
            this.history_textbox_1.SelectedText = "";
            this.history_textbox_1.ShadowDecoration.Parent = this.history_textbox_1;
            this.history_textbox_1.Size = new System.Drawing.Size(199, 36);
            this.history_textbox_1.TabIndex = 1;
            this.history_textbox_1.TextChanged += new System.EventHandler(this.NewTopic1TextField_TextChanged);
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
            this.btnAddTopic.Location = new System.Drawing.Point(5, 101);
            this.btnAddTopic.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.ShadowDecoration.Parent = this.btnAddTopic;
            this.btnAddTopic.Size = new System.Drawing.Size(199, 41);
            this.btnAddTopic.TabIndex = 0;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.Click += new System.EventHandler(this.BtnAddTopic_Click);
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(220, 94);
            this.lblRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(136, 20);
            this.lblRegistrationDate.TabIndex = 74;
            this.lblRegistrationDate.Text = "Registered Date:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(312, 128);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(621, 91);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 76;
            this.lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(627, 126);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(72, 20);
            this.lblContact.TabIndex = 77;
            this.lblContact.Text = "Contact:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(987, 91);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 78;
            this.lblAge.Text = "Age:";
            // 
            // lblReferredTo
            // 
            this.lblReferredTo.AutoSize = true;
            this.lblReferredTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferredTo.Location = new System.Drawing.Point(917, 126);
            this.lblReferredTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferredTo.Name = "lblReferredTo";
            this.lblReferredTo.Size = new System.Drawing.Size(103, 20);
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
            this.btnHistory.Location = new System.Drawing.Point(831, 167);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(115, 22);
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
            this.btnTests.Location = new System.Drawing.Point(1076, 167);
            this.btnTests.Margin = new System.Windows.Forms.Padding(4);
            this.btnTests.Name = "btnTests";
            this.btnTests.ShadowDecoration.Parent = this.btnTests;
            this.btnTests.Size = new System.Drawing.Size(115, 22);
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
            this.btnOthers.Location = new System.Drawing.Point(1199, 167);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(4);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.ShadowDecoration.Parent = this.btnOthers;
            this.btnOthers.Size = new System.Drawing.Size(115, 22);
            this.btnOthers.TabIndex = 82;
            this.btnOthers.Text = "Others";
            // 
            // registrationDateOutput
            // 
            this.registrationDateOutput.AutoSize = true;
            this.registrationDateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDateOutput.Location = new System.Drawing.Point(387, 94);
            this.registrationDateOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationDateOutput.Name = "registrationDateOutput";
            this.registrationDateOutput.Size = new System.Drawing.Size(129, 20);
            this.registrationDateOutput.TabIndex = 83;
            this.registrationDateOutput.Text = "registrationDate";
            // 
            // lblFirstNameOutput
            // 
            this.lblFirstNameOutput.AutoSize = true;
            this.lblFirstNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameOutput.Location = new System.Drawing.Point(385, 130);
            this.lblFirstNameOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNameOutput.Name = "lblFirstNameOutput";
            this.lblFirstNameOutput.Size = new System.Drawing.Size(84, 20);
            this.lblFirstNameOutput.TabIndex = 84;
            this.lblFirstNameOutput.Text = "Firstname";
            // 
            // lblAddressOutput
            // 
            this.lblAddressOutput.AutoSize = true;
            this.lblAddressOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressOutput.Location = new System.Drawing.Point(716, 91);
            this.lblAddressOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressOutput.Name = "lblAddressOutput";
            this.lblAddressOutput.Size = new System.Drawing.Size(119, 20);
            this.lblAddressOutput.TabIndex = 85;
            this.lblAddressOutput.Text = "addressOutput";
            // 
            // lblContactOutput
            // 
            this.lblContactOutput.AutoSize = true;
            this.lblContactOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactOutput.Location = new System.Drawing.Point(719, 126);
            this.lblContactOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactOutput.Name = "lblContactOutput";
            this.lblContactOutput.Size = new System.Drawing.Size(114, 20);
            this.lblContactOutput.TabIndex = 86;
            this.lblContactOutput.Text = "contactOutput";
            // 
            // lblAgeOutput
            // 
            this.lblAgeOutput.AutoSize = true;
            this.lblAgeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeOutput.Location = new System.Drawing.Point(1045, 91);
            this.lblAgeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeOutput.Name = "lblAgeOutput";
            this.lblAgeOutput.Size = new System.Drawing.Size(86, 20);
            this.lblAgeOutput.TabIndex = 87;
            this.lblAgeOutput.Text = "ageOutput";
            // 
            // lblReferredToOutput
            // 
            this.lblReferredToOutput.AutoSize = true;
            this.lblReferredToOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferredToOutput.Location = new System.Drawing.Point(1049, 126);
            this.lblReferredToOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferredToOutput.Name = "lblReferredToOutput";
            this.lblReferredToOutput.Size = new System.Drawing.Size(137, 20);
            this.lblReferredToOutput.TabIndex = 88;
            this.lblReferredToOutput.Text = "referredToOutput";
            // 
            // lblGenderOutput
            // 
            this.lblGenderOutput.AutoSize = true;
            this.lblGenderOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderOutput.Location = new System.Drawing.Point(1167, 91);
            this.lblGenderOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenderOutput.Name = "lblGenderOutput";
            this.lblGenderOutput.Size = new System.Drawing.Size(110, 20);
            this.lblGenderOutput.TabIndex = 89;
            this.lblGenderOutput.Text = "genderOutput";
            // 
            // lblLastNameOutput
            // 
            this.lblLastNameOutput.AutoSize = true;
            this.lblLastNameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameOutput.Location = new System.Drawing.Point(509, 128);
            this.lblLastNameOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastNameOutput.Name = "lblLastNameOutput";
            this.lblLastNameOutput.Size = new System.Drawing.Size(83, 20);
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
            this.btnMedicine.Location = new System.Drawing.Point(953, 167);
            this.btnMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.ShadowDecoration.Parent = this.btnMedicine;
            this.btnMedicine.Size = new System.Drawing.Size(115, 22);
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
            this.btnViewHistory.Location = new System.Drawing.Point(953, 18);
            this.btnViewHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.ShadowDecoration.Parent = this.btnViewHistory;
            this.btnViewHistory.Size = new System.Drawing.Size(192, 37);
            this.btnViewHistory.TabIndex = 93;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.Click += new System.EventHandler(this.BtnViewHistory_Click);
            // 
            // TreatmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 769);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TreatmentWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TreatmentWindow_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox history_textbox_1;
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