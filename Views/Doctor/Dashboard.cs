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

namespace webTRON_Management_Software.Views.Doctor
{
    public partial class Dashboard : Form
    {
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTreatmentWindow_Click(object sender, EventArgs e)
        {
            TreatmentWindow treatmentWindow = new TreatmentWindow(employee);
            treatmentWindow.Show();
            this.Hide();
        }
    }
}
