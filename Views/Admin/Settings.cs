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
    public partial class Settings : Form
    {

        //Instantiate Employee Class
        Employee employee = new Employee();
        public Settings()
        {
            InitializeComponent();
        }
        public Settings(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on dashboard icon
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Admin.Dashboard(employee);
            dashboard.Show();
            this.Hide();

        }
        //Click event on Users icon
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            var users = new Admin.Users(employee);
            users.Show();
            this.Hide();

        }
        //Load event on settings icon
        private void Settings_Load(object sender, EventArgs e)
        {
            //Initialize active user details
            InitializeActiverUserDetails();
        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;
            lblUserIdValue.Text = employee.UserID;
            lblFullNameValue.Text = $"{employee.FirstName} {employee.LastName}";
            lblEmailValue.Text = employee.Email;
            lblContactNumberValue.Text = employee.ContactNumber;

        }
        //Click event on signout and exit button
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
        //Click event on change password button
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            var changePassword = new ChangePassword(employee);
            changePassword.Show();
            this.Hide();

        }

        //Click event on change info button
        private void BtnChangeInfo_Click(object sender, EventArgs e)
        {
            //Instantiate change info form
            var changeInfo = new ChangeInfo(employee);
            changeInfo.Show();
            this.Hide();

        }
    }
}
