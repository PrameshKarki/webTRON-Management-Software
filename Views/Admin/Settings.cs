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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Admin_Settings_Load(object sender, EventArgs e)
        {

        }

        //Click event on exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //Click event on minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on dashboard icon
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Admin.Dashboard();
            dashboard.Show();
            this.Hide();

        }
        //Click event on Users icon
        private void btnUsers_Click(object sender, EventArgs e)
        {
            var users = new Admin.Users();
            users.Show();
            this.Hide();

        }
    }
}
