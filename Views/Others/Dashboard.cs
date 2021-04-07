using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Views.Admin;
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Others
{
    public partial class Dashboard : Form
    {
        //Instantiate employee class
        Employee employee = new Employee();

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //Load event on Dashboard
        private void OtherDashboard_Load(object sender, EventArgs e)
        {
            //Load Grid View
            LoadGridView();

            //Change width height of columns,rows of grid view at run time
            staffsDataGridView.Rows[0].Selected = false;
            staffsDataGridView.Columns[0].Width = 150;
            staffsDataGridView.Columns[1].Width = 150;
            staffsDataGridView.Columns[3].Width = 150;
            staffsDataGridView.Columns[4].Width = 100;


            //Initialize activeUserDetails
            InitializeActiverUserDetails();
        }
        //Load data on grid data table
        private void LoadGridView()
        {
            //Instantiate data table
            DataTable dt = Employee.FetchStaffsDetails();
            staffsDataGridView.DataSource = dt;
        }


        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;
            if (employee.img != null)
            {
                //Change active user picture
                MemoryStream ms = new MemoryStream(employee.img);
                activeUserPicture.Image = Image.FromStream(ms);
            }
        }

        //Sign Out
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
        //Click event on settings button
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settings = new Settings(employee);
            settings.Show();
            this.Hide();
        }

        //Text change event on search box
        private void SearchStaffsTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchString = searchStaffsTextBox.Text.Trim();
            //Instantiate data table
            DataTable dt = Employee.SearchStaffDetails(searchString);
            staffsDataGridView.DataSource = dt;

        }

       
    }
}
