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
using Accountant=webTRON_Management_Software.Views.Accountant;
using Admin=webTRON_Management_Software.Views.Admin;
using Doctor=webTRON_Management_Software.Views.Doctor;
using Management=webTRON_Management_Software.Views.Management;
using Others=webTRON_Management_Software.Views.Others;
using Utilities=webTRON_Management_Software.Views.Utilities;

namespace webTRON_Management_Software.Views.Landing_Window
{
    public partial class LandingWindow : Form
    {

        //Instantiating User Class
        User newUser = new User();
        public LandingWindow()
        {
            InitializeComponent();
        }

        //Login Button Click Event
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //Instantiate object properties
            newUser.userID = userIDTextBox.Text;
            newUser.password = passwordTextBox.Text;

            //Validating user input
            if (newUser.userID == "" || newUser.password == "")
            {
                MessageBox.Show("Fll all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Check valid user or nont
                bool isSucess = newUser.CheckUser(newUser);
                if (isSucess)
                {
                    //check wheather the user login is first time or not into the system
                    bool isFirstTime = newUser.IsFirstTimeLogin(newUser.userID);
                    if (isFirstTime)
                    {
                        newUser.StoreLogInInfo(newUser.userID);

                    }
                    else
                    {
                        newUser.UpdateLogInInfo(newUser.userID);

                    }
                    //Authorize User
                    AuthorizeUser();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //Minimize button click event
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Close button click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Method to authorize user
        private void AuthorizeUser()
        {
            //Get User Role
            string userRole = newUser.GetUserRole(newUser.userID);
            switch (userRole)
            {
                case "Admin":
                    this.Hide();
                    var adminDashBoard = new Admin.Dashboard();
                    adminDashBoard.Show();
                    break;
                case "Doctor":
                    this.Hide();
                    var doctorDashboard = new Doctor.Dashboard();
                    doctorDashboard.Show();
                    break;
                case "Accountant":
                    this.Hide();
                    var accountDashboard = new Accountant.Dashboard();
                    accountDashboard.Show();
                    break;
                case "Management":
                    this.Hide();
                    var managementDashboard = new Management.Dashboard();
                    managementDashboard.Show();
                     break;
                case "Other":
                    this.Hide();
                    var otherDashboard = new Others.Dashboard();
                    otherDashboard.Show();
                   break;

            }

        }
        //Method to handle click event
        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            //Instantiating forget password form
            this.Hide();
            var forgetPassword = new Utilities.ForgetPassword();
            forgetPassword.Show();
        }
    }
}
