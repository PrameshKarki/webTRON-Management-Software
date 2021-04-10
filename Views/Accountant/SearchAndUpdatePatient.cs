using MySql.Data.MySqlClient;
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
    public partial class SearchAndUpdatePatient : Form
    {
        Patient ObjUpdate = new Patient();
        // private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        private static string connectionString = "server=localhost;user id=root;pwd=laxudb;database=webtronmanagement";
        public SearchAndUpdatePatient()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //clear all fields
            Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(ageTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text))
            {
                MessageBox.Show("Complete Information Should be Supplied.", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ObjUpdate.patientID = lblPatientIDOutput.Text;
                ObjUpdate.registrationDate = lblRegistrationDateOutput.Text;
                ObjUpdate.firstName = firstNameTextBox.Text;
                ObjUpdate.lastName = lastNameTextBox.Text;
                ObjUpdate.address = addressTextBox.Text;
                ObjUpdate.referredTo = lblReferredToOutput.Text;
                ObjUpdate.age = Convert.ToInt32(ageTextBox.Text);
                ObjUpdate.contactNumber = contactNumberTextBox.Text;
                ObjUpdate.status = lblStatusOutput.Text;
                ObjUpdate.gender = lblSexOutput.Text;
                bool isSuccess = Patient.Update(ObjUpdate);
                if (isSuccess)
                {
                    MessageBox.Show("Information Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //clear all fields
                    Clear();
                    DisplayDataInDataGridView();
                    
                }
                else
                {
                    MessageBox.Show("UNSUCCESSFUL.", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        //Method to clear all fields
        private void Clear()
        {

            //clear all fields
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            addressTextBox.Text = "";
            lblSexOutput.Text = "----------";
            ageTextBox.Text = "";
            contactNumberTextBox.Text = "";
            lblReferredToOutput.Text = "----------";
            lblRegistrationDateOutput.Text = "------------";
            lblPatientIDOutput.Text = "------------";
            firstNameTextBox.Focus();
        }

        private void SearchAndUpdatePatient_Load(object sender, EventArgs e)
        {
            DisplayDataInDataGridView();
        }


        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblPatientIDOutput.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
            lblRegistrationDateOutput.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            firstNameTextBox.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
            lastNameTextBox.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
            contactNumberTextBox.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
            lblSexOutput.Text = DataGridView.SelectedRows[0].Cells[5].Value.ToString();
            lblReferredToOutput.Text = DataGridView.SelectedRows[0].Cells[6].Value.ToString();
            lblStatusOutput.Text = DataGridView.SelectedRows[0].Cells[7].Value.ToString();
            ageTextBox.Text = DataGridView.SelectedRows[0].Cells[8].Value.ToString();
            addressTextBox.Text = DataGridView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.patientID = searchTextBox.Text;
            patient.registrationDate = searchTextBox.Text;
            patient.firstName = searchTextBox.Text;
            patient.lastName = searchTextBox.Text;
            patient.contactNumber = searchTextBox.Text;
            patient.gender = searchTextBox.Text;
            patient.referredTo = searchTextBox.Text;
            patient.status = searchTextBox.Text;
            patient.address = searchTextBox.Text;

            DataTable dt = Patient.SearchFromTable(patient);  // inserts the data table returned from MySqlDataAdapter sda to the DataTable dt;
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
    } }
