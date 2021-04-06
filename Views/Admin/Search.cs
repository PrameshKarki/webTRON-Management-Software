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
        private bool selectionChanged;

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
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Instantiating Settings form
            var setting = new Settings(employee);
            setting.Show();
            this.Hide();
        }
        //Click event on Minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
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

        //CellClick event on DataGridView
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetButtonStatus();

            if (!selectionChanged)
            {
                DataGridView.ClearSelection();
                selectionChanged = true;
            }
            else
            {
                selectionChanged = false;
            }
        }

        //Selection change event on DataGriwView
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            selectionChanged = true;
        }
        //Set button color
        private void SetButtonStatus()
        {
            if (DataGridView.CurrentCell.RowIndex < 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled=true;
            }
        }
        //Click event on delete button
        private void BtnDelete_Click(object sender, EventArgs e)
        {   
            //Get current row index
            int index = DataGridView.CurrentCell.RowIndex;
            string userID = DataGridView.Rows[index].Cells[0].Value.ToString();
            var returnValue=MessageBox.Show("Are you sure?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (returnValue.ToString() == "Yes")
            {
                bool isDeleted = User.Delete(userID);
                User.SetAccountStatus(userID, "Inactive");

                if (isDeleted)
                {
                    MessageBox.Show("Account deleted sucessfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error occured!Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

           
        }
    }
}
