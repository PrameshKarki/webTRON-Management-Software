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
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Admin
{
    public partial class ChangePassword : Form
    {
        //Instantiate Employee Class
        Employee employee = new Employee();
        public ChangePassword()
        {
            InitializeComponent();
        }
        public ChangePassword(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            //Initialize active user details
            InitializeActiverUserDetails();
        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;


        }

        //Sign Out User
        private void SignOut(object sender, EventArgs e)
        {
            //WARNING:To check which element has clicked          
            string elementType = sender.GetType().ToString();
            var value = MessageBox.Show("Are you sure?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (value.ToString() == "Yes")
            {
                Employee.SetStatus(employee.UserID, "Offline");
                //It ensures sign out has clicked
                if (elementType == "Guna.UI2.WinForms.Guna2Button")
                {
                    LandingWindow landingWindow = new LandingWindow();
                    landingWindow.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }


            }
        }
        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Click event on dashboard button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Admin.Dashboard(employee);
            dashboard.Show();
            this.Hide();
        }

        //Click event on users button
        private void BtnUsers_Click(object sender, EventArgs e)
        {

            //Instantiating user form
            var users = new Users(employee);
            users.Show();
            this.Hide();
        }

        //Click event on settings button
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Instantiating Settings form
            var settings = new Settings(employee);
            settings.Show();
            this.Hide();

        }
        //Click event on change password
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(currentPasswordTextBox.Text) || string.IsNullOrEmpty(newPasswordTextBox.Text) || string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string currentPassword = currentPasswordTextBox.Text;
                
                //Instantiate User Class
                User usr = new User();
                usr.userID = employee.UserID;
                usr.password = currentPassword;

                //Check current password or not
                bool isValid = User.CheckUser(usr);
                if (isValid)
                {
                    string newPassword = newPasswordTextBox.Text;
                    string confirmPassword = confirmPasswordTextBox.Text;
                    if (newPassword == confirmPassword)
                    {
                        //Show confirmation code panel
                        verificationCodePanel.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Password doesn't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
