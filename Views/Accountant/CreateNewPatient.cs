using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Utils;

namespace webTRON_Management_Software.Views.Accountant
{
    public partial class CreateNewPatient : Form
    {
      
        public CreateNewPatient()
        {
            InitializeComponent();
        }

        private void CreatePatient_Load(object sender, EventArgs e)
        {
            string regNumber = Generator.GeneratePatientId();
            string regDate = Generator.GetRegistrationDate();
            lblRegistrationIdOutput.Text = regNumber;
            lblRegistrationDateOutput.Text = regDate;
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

 

        private void BtnCreateNewPatient_Click(object sender, EventArgs e)
        {

            // check if all the fields are Filled or not.
            if (string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(genderTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text) || (isMale.Checked == false & isFemale.Checked == false & isOthers.Checked == false))
            {
                MessageBox.Show("Complete Information Should be Supplied.", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Patient ptn = new Patient();
                ptn.patientID = lblRegistrationIdOutput.Text;
                ptn.registrationDate = lblRegistrationDateOutput.Text;
                ptn.firstName = firstNameTxtBox.Text;
                ptn.lastName = lastNameTextBox.Text;
                ptn.address = addressTextBox.Text;
                ptn.referredTo = referredToComboBox.Text;
                ptn.gender = genderTextBox.Text;
                ptn.contactNumber = contactNumberTextBox.Text;
                ptn.status = "in";
              
                if (isMale.Checked)
                    ptn.gender = isMale.Text;
                    
                
                else if (isFemale.Checked)
                    ptn.gender = isFemale.Text;
                    
                else if (isOthers.Checked)
                    ptn.gender = isOthers.Text;
                    

                bool isSuccess = Patient.Insert(ptn);
                if (isSuccess)
                {
                    MessageBox.Show("Registration Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrintPanelContanerPanel.Visible = true;
                    //TO DISPLAY THE NEXT REGISTRATION ID AFTER INSERTING THE INFO OF ONE PATIENT...
                    string regNumber = Generator.GeneratePatientId();
                    string regDate = Generator.GetRegistrationDate();
                    lblRegistrationIdOutput.Text = regNumber;
                    lblRegistrationDateOutput.Text = regDate;
                }
                else
                {
                    MessageBox.Show("Error!!!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //to print the Ticket
            Printer printer = new Printer(printPanel.Width,printPanel.Height,printPanel);
            printer.Print(printPanel);
            PrintPanelContanerPanel.Visible = false;
            //clear all fields
            ClearFields();
        }


        private void PrintPanel_Paint(object sender, PaintEventArgs e)
        {
            LblPanelRegistrationIdOutput.Text = lblRegistrationIdOutput.Text;
            LblPanelRegistrationDateOutput.Text = lblRegistrationDateOutput.Text;
            LblPanelFNameOutput.Text = firstNameTxtBox.Text;
            LblPanelLNameOutput.Text = lastNameTextBox.Text;
            LblPanelAgeOutput.Text = genderTextBox.Text;
          
            if (isMale.Checked)
                LblPanelSexOutput.Text = "M";
            else if (isFemale.Checked)
                LblPanelSexOutput.Text = "F";
            else if (isOthers.Checked)
                LblPanelSexOutput.Text = "O";
            
            LblPanelAddressOutput.Text = addressTextBox.Text;
            LblPanelReferredToOutput.Text = referredToComboBox.Text;

            //to create QR CODE...
            QRCoder.QRCode qr = QRCodeGenerator.generateQRCode(lblRegistrationIdOutput.Text);
            QRCodePictureBox.Image = qr.GetGraphic(50);
        }
        private void ClearFields()
        {
            firstNameTxtBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            addressTextBox.Text = "";
            isFemale.Checked = false;
            isMale.Checked = false;
            isOthers.Checked = false;
            genderTextBox.Text = "";
            contactNumberTextBox.Text = "";
            referredToComboBox.SelectedIndex = -1;
            firstNameTxtBox.Focus();
        }

    }
}
