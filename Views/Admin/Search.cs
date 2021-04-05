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
    public partial class Search : Form
    {
        //Instantiating Employee Class
        Employee employee = new Employee();
        public Search()
        {
            InitializeComponent();
        }
        public Search(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

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
        //Load event on Search form
        private void Search_Load(object sender, EventArgs e)
        {
            LoadGridView();
            //Set Width of columns here
            //Initialize activer user details
            InitializeActiverUserDetails();

        }
        //Method to update grid data view
        private void LoadGridView()
        {
            DataTable dt = Employee.Fetch();
            DataGridView.DataSource = dt;
        }

        //Text Change Event on Search Text Box
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchString = searchTextBox.Text.Trim();
            DataTable searchedTable = Employee.Search(searchString);
            DataGridView.DataSource = searchedTable;
        }

        //Click event on dashboard icon
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Admin.Dashboard(employee);
            dashboard.Show();
            this.Hide();


        }
        //Click event on settings icon
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Instantiating Settings form
            var setting = new Settings(employee);
            setting.Show();
            this.Hide();
        }
        //Click event on Minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on users button
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            //Instantiating user form
            var users = new Users(employee);
            users.Show();
            this.Hide();

        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;


        }


    }
}
