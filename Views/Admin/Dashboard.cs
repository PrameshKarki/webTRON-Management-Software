using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Views.Admin
{
    public partial class Dashboard : Form
    {
        //Primary color of form
        private String primaryColor = "#176BCF";

        public Dashboard()
        {
            InitializeComponent();
        }

        //Load event on admin dashboard
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //Set primary color of components
            setPrimaryColor();
        }
        //Method to set primary colour in different components
        private void setPrimaryColor()
        {
          
        }
        //Click event on minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Click event on exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Click event on Users button
        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users userForm = new Users();
            userForm.Show();
            this.Hide();

        }

        //Click event on Settings button
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settingForm = new Settings();
            settingForm.Show();
            this.Hide();

        }
    }
}
