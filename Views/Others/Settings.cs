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

namespace webTRON_Management_Software.Views.Others
{
    public partial class Settings : Form
    {
        //Instantiate employee class
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

        //Sign out
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
        //Click event on dashboard button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //Instantiate dashboard form
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Close();

        }

        //Load event on settings form
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
        //Click event on changeinfo
        private void BtnChangeInfo_Click(object sender, EventArgs e)
        {
            //Instantiate change info form
            var changeInfo = new ChangeInfo(employee);
            changeInfo.Show();
            this.Close();
        }

        //Click event on change password
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            //Instantiate change password form
            var changePassword = new ChangePassword(employee);
            changePassword.Show();
            this.Close();
        }
    }
}
