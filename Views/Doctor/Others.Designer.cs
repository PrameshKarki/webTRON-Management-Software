
namespace webTRON_Management_Software.Views.Doctor
{
    partial class Others
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Others));
            this.dragableOthersForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.alertTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.btnMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnOthers = new Guna.UI2.WinForms.Guna2Button();
            this.btnTests = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.lblReferredToValue = new System.Windows.Forms.Label();
            this.lblGenderValue = new System.Windows.Forms.Label();
            this.lblAgeValue = new System.Windows.Forms.Label();
            this.lblContactValue = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblRegisteredDateValue = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblReferredTo = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPatientIDValue = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegisteredDate = new System.Windows.Forms.Label();
            this.lblRegistrationId = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.alertTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPrescribe = new Guna.UI2.WinForms.Guna2Button();
            this.activePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.activeForm = new System.Windows.Forms.Label();
            this.activeUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.activeUserName = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.alertText = new System.Windows.Forms.Label();
            this.alertCloseBtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.alertImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.activePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.alertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dragableOthersForm
            // 
            this.dragableOthersForm.TargetControl = this;
            // 
            // alertTransition
            // 
            this.alertTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.alertTransition.Cursor = null;
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
            this.alertTransition.DefaultAnimation = animation1;
            // 
            // btnMedicine
            // 
            this.btnMedicine.CheckedState.Parent = this.btnMedicine;
            this.btnMedicine.CustomImages.Parent = this.btnMedicine;
            this.alertTransition.SetDecoration(this.btnMedicine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnMedicine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMedicine.ForeColor = System.Drawing.Color.White;
            this.btnMedicine.HoverState.Parent = this.btnMedicine;
            this.btnMedicine.Location = new System.Drawing.Point(708, 138);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.ShadowDecoration.Parent = this.btnMedicine;
            this.btnMedicine.Size = new System.Drawing.Size(86, 26);
            this.btnMedicine.TabIndex = 167;
            this.btnMedicine.Text = "Medicine";
            // 
            // btnOthers
            // 
            this.btnOthers.CheckedState.Parent = this.btnOthers;
            this.btnOthers.CustomImages.Parent = this.btnOthers;
            this.alertTransition.SetDecoration(this.btnOthers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnOthers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(228)))));
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOthers.ForeColor = System.Drawing.Color.White;
            this.btnOthers.HoverState.Parent = this.btnOthers;
            this.btnOthers.Location = new System.Drawing.Point(892, 138);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.ShadowDecoration.Parent = this.btnOthers;
            this.btnOthers.Size = new System.Drawing.Size(86, 26);
            this.btnOthers.TabIndex = 166;
            this.btnOthers.Text = "Others";
            // 
            // btnTests
            // 
            this.btnTests.CheckedState.Parent = this.btnTests;
            this.btnTests.CustomImages.Parent = this.btnTests;
            this.alertTransition.SetDecoration(this.btnTests, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnTests.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnTests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTests.ForeColor = System.Drawing.Color.White;
            this.btnTests.HoverState.Parent = this.btnTests;
            this.btnTests.Location = new System.Drawing.Point(800, 138);
            this.btnTests.Name = "btnTests";
            this.btnTests.ShadowDecoration.Parent = this.btnTests;
            this.btnTests.Size = new System.Drawing.Size(86, 26);
            this.btnTests.TabIndex = 165;
            this.btnTests.Text = "Tests";
            // 
            // btnPrescription
            // 
            this.btnPrescription.CheckedState.Parent = this.btnPrescription;
            this.btnPrescription.CustomImages.Parent = this.btnPrescription;
            this.alertTransition.SetDecoration(this.btnPrescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnPrescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPrescription.ForeColor = System.Drawing.Color.White;
            this.btnPrescription.HoverState.Parent = this.btnPrescription;
            this.btnPrescription.Location = new System.Drawing.Point(616, 138);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.ShadowDecoration.Parent = this.btnPrescription;
            this.btnPrescription.Size = new System.Drawing.Size(86, 26);
            this.btnPrescription.TabIndex = 164;
            this.btnPrescription.Text = "Prescription";
            // 
            // lblReferredToValue
            // 
            this.lblReferredToValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblReferredToValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReferredToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReferredToValue.Location = new System.Drawing.Point(853, 73);
            this.lblReferredToValue.Name = "lblReferredToValue";
            this.lblReferredToValue.Size = new System.Drawing.Size(103, 20);
            this.lblReferredToValue.TabIndex = 163;
            this.lblReferredToValue.Text = "{{referredTo}}";
            // 
            // lblGenderValue
            // 
            this.lblGenderValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGenderValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGenderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderValue.Location = new System.Drawing.Point(665, 92);
            this.lblGenderValue.Name = "lblGenderValue";
            this.lblGenderValue.Size = new System.Drawing.Size(73, 17);
            this.lblGenderValue.TabIndex = 162;
            this.lblGenderValue.Text = "{{gender}}";
            // 
            // lblAgeValue
            // 
            this.lblAgeValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAgeValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeValue.Location = new System.Drawing.Point(667, 60);
            this.lblAgeValue.Name = "lblAgeValue";
            this.lblAgeValue.Size = new System.Drawing.Size(52, 17);
            this.lblAgeValue.TabIndex = 161;
            this.lblAgeValue.Text = "{{age}}";
            // 
            // lblContactValue
            // 
            this.lblContactValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblContactValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblContactValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactValue.Location = new System.Drawing.Point(497, 92);
            this.lblContactValue.Name = "lblContactValue";
            this.lblContactValue.Size = new System.Drawing.Size(74, 17);
            this.lblContactValue.TabIndex = 160;
            this.lblContactValue.Text = "{{contact}}";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAddressValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressValue.Location = new System.Drawing.Point(495, 64);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(79, 17);
            this.lblAddressValue.TabIndex = 159;
            this.lblAddressValue.Text = "{{address}}";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblNameValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameValue.Location = new System.Drawing.Point(287, 89);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(63, 17);
            this.lblNameValue.TabIndex = 158;
            this.lblNameValue.Text = "{{name}}";
            // 
            // lblRegisteredDateValue
            // 
            this.lblRegisteredDateValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegisteredDateValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegisteredDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDateValue.Location = new System.Drawing.Point(287, 62);
            this.lblRegisteredDateValue.Name = "lblRegisteredDateValue";
            this.lblRegisteredDateValue.Size = new System.Drawing.Size(122, 17);
            this.lblRegisteredDateValue.TabIndex = 157;
            this.lblRegisteredDateValue.Text = "{{registeredDate}}";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblGender, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(604, 94);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 156;
            this.lblGender.Text = "Gender:";
            // 
            // lblReferredTo
            // 
            this.lblReferredTo.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblReferredTo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblReferredTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReferredTo.Location = new System.Drawing.Point(761, 73);
            this.lblReferredTo.Name = "lblReferredTo";
            this.lblReferredTo.Size = new System.Drawing.Size(98, 20);
            this.lblReferredTo.TabIndex = 155;
            this.lblReferredTo.Text = "Referred To:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAge, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(624, 62);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 17);
            this.lblAge.TabIndex = 154;
            this.lblAge.Text = "Age:";
            // 
            // lblPatientIDValue
            // 
            this.lblPatientIDValue.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblPatientIDValue, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPatientIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPatientIDValue.Location = new System.Drawing.Point(544, 20);
            this.lblPatientIDValue.Name = "lblPatientIDValue";
            this.lblPatientIDValue.Size = new System.Drawing.Size(95, 20);
            this.lblPatientIDValue.TabIndex = 153;
            this.lblPatientIDValue.Text = "{{patientID}}";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblContact, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(429, 92);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 17);
            this.lblContact.TabIndex = 152;
            this.lblContact.Text = "Contact:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblAddress, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(425, 64);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 151;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(240, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 150;
            this.lblName.Text = "Name:";
            // 
            // lblRegisteredDate
            // 
            this.lblRegisteredDate.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegisteredDate, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegisteredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredDate.Location = new System.Drawing.Point(174, 62);
            this.lblRegisteredDate.Name = "lblRegisteredDate";
            this.lblRegisteredDate.Size = new System.Drawing.Size(115, 17);
            this.lblRegisteredDate.TabIndex = 149;
            this.lblRegisteredDate.Text = "Registered Date:";
            // 
            // lblRegistrationId
            // 
            this.lblRegistrationId.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblRegistrationId, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblRegistrationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistrationId.Location = new System.Drawing.Point(454, 21);
            this.lblRegistrationId.Name = "lblRegistrationId";
            this.lblRegistrationId.Size = new System.Drawing.Size(84, 20);
            this.lblRegistrationId.TabIndex = 148;
            this.lblRegistrationId.Text = "Patient ID:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.alertTransition.SetDecoration(this.lblSummary, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSummary.Location = new System.Drawing.Point(14, 152);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(80, 20);
            this.lblSummary.TabIndex = 168;
            this.lblSummary.Text = "Summary:";
            // 
            // guna2Panel1
            // 
            this.alertTransition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 180);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(976, 356);
            this.guna2Panel1.TabIndex = 169;
            // 
            // alertTimer
            // 
            this.alertTimer.Enabled = true;
            this.alertTimer.Interval = 5000;
            this.alertTimer.Tick += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // btnPrescribe
            // 
            this.btnPrescribe.Animated = true;
            this.btnPrescribe.CheckedState.Parent = this.btnPrescribe;
            this.btnPrescribe.CustomImages.Parent = this.btnPrescribe;
            this.alertTransition.SetDecoration(this.btnPrescribe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPrescribe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(207)))));
            this.btnPrescribe.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnPrescribe.ForeColor = System.Drawing.Color.White;
            this.btnPrescribe.HoverState.Parent = this.btnPrescribe;
            this.btnPrescribe.Image = global::webTRON_Management_Software.Properties.Resources.prescribe_icon;
            this.btnPrescribe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrescribe.Location = new System.Drawing.Point(857, 571);
            this.btnPrescribe.Name = "btnPrescribe";
            this.btnPrescribe.ShadowDecoration.Parent = this.btnPrescribe;
            this.btnPrescribe.Size = new System.Drawing.Size(131, 42);
            this.btnPrescribe.TabIndex = 170;
            this.btnPrescribe.Text = "Prescribe";
            this.btnPrescribe.TextOffset = new System.Drawing.Point(-7, 0);
            // 
            // activePanel
            // 
            this.activePanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.rectangle_curved_large;
            this.activePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.activePanel.Controls.Add(this.activeForm);
            this.activePanel.Controls.Add(this.activeUserPicture);
            this.activePanel.Controls.Add(this.activeUserName);
            this.alertTransition.SetDecoration(this.activePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activePanel.Location = new System.Drawing.Point(0, -1);
            this.activePanel.Name = "activePanel";
            this.activePanel.ShadowDecoration.Parent = this.activePanel;
            this.activePanel.Size = new System.Drawing.Size(165, 80);
            this.activePanel.TabIndex = 147;
            // 
            // activeForm
            // 
            this.activeForm.AutoSize = true;
            this.activeForm.BackColor = System.Drawing.Color.Transparent;
            this.alertTransition.SetDecoration(this.activeForm, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.alertTransition.SetDecoration(this.activeUserPicture, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.alertTransition.SetDecoration(this.activeUserName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.activeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeUserName.ForeColor = System.Drawing.Color.White;
            this.activeUserName.Location = new System.Drawing.Point(64, 9);
            this.activeUserName.Name = "activeUserName";
            this.activeUserName.Size = new System.Drawing.Size(52, 24);
            this.activeUserName.TabIndex = 1;
            this.activeUserName.Text = "John";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnMinimize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(914, 27);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(21, 4);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 146;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.btnExit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(963, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnExit.TabIndex = 145;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // alertPanel
            // 
            this.alertPanel.BackgroundImage = global::webTRON_Management_Software.Properties.Resources.alert_danger_background;
            this.alertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alertPanel.Controls.Add(this.alertText);
            this.alertPanel.Controls.Add(this.alertCloseBtn);
            this.alertPanel.Controls.Add(this.alertImage);
            this.alertTransition.SetDecoration(this.alertPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertPanel.Location = new System.Drawing.Point(1, 569);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.ShadowDecoration.Parent = this.alertPanel;
            this.alertPanel.Size = new System.Drawing.Size(306, 55);
            this.alertPanel.TabIndex = 103;
            this.alertPanel.Visible = false;
            // 
            // alertText
            // 
            this.alertText.AutoSize = true;
            this.alertTransition.SetDecoration(this.alertText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.alertText.ForeColor = System.Drawing.Color.Red;
            this.alertText.Location = new System.Drawing.Point(56, 17);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(90, 20);
            this.alertText.TabIndex = 2;
            this.alertText.Text = "{{alertText}}";
            // 
            // alertCloseBtn
            // 
            this.alertCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alertTransition.SetDecoration(this.alertCloseBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertCloseBtn.Image = global::webTRON_Management_Software.Properties.Resources.alert_close_icon;
            this.alertCloseBtn.Location = new System.Drawing.Point(269, 17);
            this.alertCloseBtn.Name = "alertCloseBtn";
            this.alertCloseBtn.ShadowDecoration.Parent = this.alertCloseBtn;
            this.alertCloseBtn.Size = new System.Drawing.Size(20, 20);
            this.alertCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertCloseBtn.TabIndex = 1;
            this.alertCloseBtn.TabStop = false;
            this.alertCloseBtn.Click += new System.EventHandler(this.AlertTimer_Tick);
            // 
            // alertImage
            // 
            this.alertTransition.SetDecoration(this.alertImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.alertImage.Image = global::webTRON_Management_Software.Properties.Resources.alert_danger_icon;
            this.alertImage.Location = new System.Drawing.Point(22, 17);
            this.alertImage.Name = "alertImage";
            this.alertImage.ShadowDecoration.Parent = this.alertImage;
            this.alertImage.Size = new System.Drawing.Size(20, 20);
            this.alertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alertImage.TabIndex = 0;
            this.alertImage.TabStop = false;
            // 
            // Others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.btnPrescribe);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.btnOthers);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.lblReferredToValue);
            this.Controls.Add(this.lblGenderValue);
            this.Controls.Add(this.lblAgeValue);
            this.Controls.Add(this.lblContactValue);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblRegisteredDateValue);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblReferredTo);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPatientIDValue);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRegisteredDate);
            this.Controls.Add(this.lblRegistrationId);
            this.Controls.Add(this.activePanel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.alertPanel);
            this.alertTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Others";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Others";
            this.Load += new System.EventHandler(this.Others_Load);
            this.activePanel.ResumeLayout(false);
            this.activePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertCloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragableOthersForm;
        private Guna.UI2.WinForms.Guna2Panel alertPanel;
        private System.Windows.Forms.Label alertText;
        private Guna.UI2.WinForms.Guna2Transition alertTransition;
        private Guna.UI2.WinForms.Guna2PictureBox alertCloseBtn;
        private Guna.UI2.WinForms.Guna2PictureBox alertImage;
        private System.Windows.Forms.Timer alertTimer;
        private Guna.UI2.WinForms.Guna2Button btnMedicine;
        private Guna.UI2.WinForms.Guna2Button btnOthers;
        private Guna.UI2.WinForms.Guna2Button btnTests;
        private Guna.UI2.WinForms.Guna2Button btnPrescription;
        private System.Windows.Forms.Label lblReferredToValue;
        private System.Windows.Forms.Label lblGenderValue;
        private System.Windows.Forms.Label lblAgeValue;
        private System.Windows.Forms.Label lblContactValue;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblRegisteredDateValue;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblReferredTo;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPatientIDValue;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRegisteredDate;
        private System.Windows.Forms.Label lblRegistrationId;
        private Guna.UI2.WinForms.Guna2Panel activePanel;
        private System.Windows.Forms.Label activeForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox activeUserPicture;
        private System.Windows.Forms.Label activeUserName;
        private Guna.UI2.WinForms.Guna2PictureBox btnMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private System.Windows.Forms.Label lblSummary;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnPrescribe;
    }
}