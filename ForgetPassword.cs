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
    public partial class ForgetPassword : Form
    {
        //Instantiate Employee Class
        Employee empObj = new Employee();

        //Entered email
        string enteredEmail;

        public ForgetPassword()
        {
            InitializeComponent();
        }
      

        //Click event on close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Click event on minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on send verification code
        private void btnSendVerificationCode_Click(object sender, EventArgs e)
        {
            //Check if textbox is empty or null
            if(string.IsNullOrEmpty(recoveryEmailTextBox.Text))
            {
                MessageBox.Show("Insert valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 enteredEmail = recoveryEmailTextBox.Text;
                //Check email is exist in database or not
                if (empObj.IsEmailExist(enteredEmail))
                {
                    //Send Verification code and store this in database
                    double generatedVerificationCode = Generator.generateVerificationCode();
                    bool isMailSendSucessfully = Email.SendVerificationCode(enteredEmail, generatedVerificationCode);
                    if (isMailSendSucessfully)
                    {
                        bool isCodeStoredSucessfully=empObj.StoreVerificationCode(enteredEmail, generatedVerificationCode);
                        if (isCodeStoredSucessfully)
                        {
                            //Show enterVerificationCodePanel
                            verificationPanelTransition.ShowSync(enterVerificationCodePanel);
                        }
                        else
                        {
                            MessageBox.Show("Please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Match not found!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
    
            

        }
        //Click event on verify button click
        private void btnVerify_Click(object sender, EventArgs e)
        {
            //Check all the text fields are filled or not
            if(string.IsNullOrEmpty(verificationCodeTextBox1.Text) || string.IsNullOrEmpty(verificationCodeTextBox2.Text)|| string.IsNullOrEmpty(verificationCodeTextBox3.Text) || string.IsNullOrEmpty(verificationCodeTextBox4.Text))
            {
                MessageBox.Show("Fill all the fields","Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string verificationCode = $"{verificationCodeTextBox1.Text}{verificationCodeTextBox2.Text}{verificationCodeTextBox3.Text}{verificationCodeTextBox4.Text}";
                int code = Convert.ToInt32(verificationCode);
                //Check verification is valid or not
                bool isValid = empObj.IsValidVerificationCode(enteredEmail, code);
                if (isValid)
                {
                    resetPasswordPanelTransition.ShowSync(resetPasswordPanel);
                }
                else
                {
                    MessageBox.Show("Invalid verification code.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

                  }
        //TextChange event on different verificationCodeTextBox 
        private void verificationCodeTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox1.Text.Length == 1)
            {
                verificationCodeTextBox2.Focus();
            }

        }

        private void verificationCodeTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox2.Text.Length == 1)
            {
                verificationCodeTextBox3.Focus();
            }
        }

        private void verificationCodeTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox3.Text.Length == 1)
            {
                verificationCodeTextBox4.Focus();
            }

        }

        private void verificationCodeTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (verificationCodeTextBox4.Text.Length == 1)
            {
                btnVerify.Focus();
            }
        }
        //Click event on password reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newPasswordTextBox.Text) || string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password's do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string newPassword = newPasswordTextBox.Text;
                //Store new password in database
                bool isChanged = empObj.UpdatePassword(enteredEmail, newPassword);
                if (isChanged)
                {
                   MessageBox.Show("Password has changed sucessfully.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Then hide ForgetPassword form and show Landing window again
                    this.Hide();
                    LandingWindow landingWindow = new LandingWindow();
                    landingWindow.Show();
                }
                else
                {
                    MessageBox.Show("Plase try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
