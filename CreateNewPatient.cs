using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Utils;

namespace webTRON_Management_Software
{
    public partial class CreateNewPatient : Form
    {
        Patient ptn = new Patient();
        public CreateNewPatient()
        {
            InitializeComponent();
        }

        private void CreatePatient_Load(object sender, EventArgs e)
        {
            string regNumber = Generator.generatePatientId();
            string regDate = Generator.getRegistrationDate();
            lblRegistrationIdOutput.Text = regNumber;
            lblRegistrationDateOutput.Text = regDate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void isOthers_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateNewPatient_Click(object sender, EventArgs e)
        {

            // check if all the fields are Filled or not.
            if (string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(ageTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text) || (isMale.Checked == false & isFemale.Checked == false & isOthers.Checked == false))
            {
                MessageBox.Show("Complete Information Should be Supplied.", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ptn.Registration_Number = Generator.generatePatientId();
                ptn.Registration_Date = Generator.getRegistrationDate();
                ptn.FirstName = firstNameTxtBox.Text;
                ptn.LastName = lastNameTextBox.Text;
                ptn.Address = addressTextBox.Text;
                ptn.ReferredTo = referredToComboBox.Text;
                ptn.Age = ageTextBox.Text;
                ptn.ContactNumber = contactNumberTextBox.Text;
                ptn.Status = "in";

                if (isMale.Checked)
                    ptn.Sex = isMale.Text;
                else if (isFemale.Checked)
                    ptn.Sex = isFemale.Text;
                else if (isOthers.Checked)
                    ptn.Sex = isOthers.Text;

                bool isSuccess = Patient.Insert(ptn);
                if (isSuccess)
                {
                    MessageBox.Show("Registration Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    //clear all fields
                    firstNameTxtBox.Text = "";
                    lastNameTextBox.Text = "";
                    addressTextBox.Text = "";
                    addressTextBox.Text = "";
                    isFemale.Checked = false;
                    isMale.Checked = false;
                    isOthers.Checked = false;
                    ageTextBox.Text = "";
                    contactNumberTextBox.Text = "";
                    referredToComboBox.SelectedIndex = -1;
                    firstNameTxtBox.Focus();


                    //TO DISPLAY THE NEXT REGISTRATION ID AFTER INSERTING THE INFO OF ONE PATIENT...
                    string regNumber = Generator.generatePatientId();
                    string regDate = Generator.getRegistrationDate();
                    lblRegistrationIdOutput.Text = regNumber;
                    lblRegistrationDateOutput.Text = regDate;
                }
                else
                {
                    MessageBox.Show("Error!!!", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



        }


    }
}
