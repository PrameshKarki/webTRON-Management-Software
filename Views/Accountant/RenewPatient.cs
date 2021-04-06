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

namespace webTRON_Management_Software.Views.Accountant
{
    public partial class RenewPatient : Form
    {
        public RenewPatient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void DisplayDataInDataGridView()
        {
            DataGridView.Rows.Clear();
            DataTable dt = Patient.GetTableData();
            foreach (DataRow item in dt.Rows) // from DataTable dt we have to read and Insert them in Gridview. DataRow is the datatype. item is name given to them which are rows of dt;
            {
                int n = DataGridView.Rows.Add(); // adds a row in the DataGridView and returns the index of the added row;
                DataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                DataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                DataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                DataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                DataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                DataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                DataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                DataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                DataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                DataGridView.Rows[n].Cells[9].Value = item[9].ToString();
            }
        }

        private void RenewPatient_Load(object sender, EventArgs e)
        {
            DataGridView.RowCount = 2;
                DateTime dateTime = DateTime.Now;
            int year = (dateTime.Year) % 100;
            int[] yearArray = new int[10];
            for (var i = 0; i < 10; i++)
                yearArray[i] = year - i;
            for (var i = 0; i < 10; i++)
                yearComboBox.Items.Add(yearArray[i]);
            yearComboBox.StartIndex = 0;

        }

        private void patientSerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string idToSearch = roleTextBox.Text+"-"+yearComboBox.Text+"-"+patientSerialNumberTextBox.Text;
            Patient patient = new Patient();
            patient.Registration_Number = idToSearch;
            patient.Registration_Date = idToSearch;
            patient.FirstName = idToSearch;
            patient.LastName = idToSearch;
            patient.ContactNumber = idToSearch;
            patient.Sex = idToSearch;
            patient.ReferredTo = idToSearch;
            patient.Status = idToSearch;
            patient.Age = idToSearch;
            patient.Address = idToSearch;

            DataTable dt = Patient.SeachAndGetTopRowFromTable(patient);  // inserts the data table returned from MySqlDataAdapter sda to the DataTable dt;
            DataGridView.Rows.Clear(); // clear the values in the gridview;
            foreach (DataRow item in dt.Rows) // from DataTable dt we have to read and Insert them in Gridview. DataRow is the datatype. item is name given to them which are rows of dt;
            {
                int n = DataGridView.Rows.Add(); // adds a row in the DataGridView and returns the index of the added row;
                DataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                DataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                DataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                DataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                DataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                DataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                DataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                DataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                DataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                DataGridView.Rows[n].Cells[9].Value = item[9].ToString();
            }

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            bool isSuccess;
            string idToSearch = roleTextBox.Text + "-" + yearComboBox.Text + "-" + patientSerialNumberTextBox.Text;
            if (isSuccess = Patient.Renew(idToSearch))
            {
                MessageBox.Show("Successfully Renewed.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Error", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
