using Guna.UI2.WinForms;
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
using webTRON_Management_Software.Utils;

namespace webTRON_Management_Software.Views.Doctor
{
    public partial class Medicine : Form
    {
        int noOfRunningMedicine=1;
        int noOfPrescribedMedicine = 1; 

        //Instantiate list of medicine object
        List<Models.Medicine> medicineList = new List<Models.Medicine>();

        //Instantiate list of row
        List<MedicineRow> listOfRunningMedicine = new List<MedicineRow>();
        List<MedicineRow> listOfPrescribedMedicine = new List<MedicineRow>();

        /*
        string patientID;
        string registrationDate;
        string firstName;
        string lastName;
        string address;
        string referredTo;
        string gender;
        int age;
        string contactNumber;
        string status;
        */
        Patient patient = new Patient();
        Employee employee = new Employee();
        public Medicine()
        {
            InitializeComponent();
            startDatePicker1.Value = DateTime.Today;
            prescribedMedicineStartDate1.Value = DateTime.Today;
        }

        public Medicine(Patient ptn, Employee emp)
        {
            InitializeComponent();
            startDatePicker1.Value = DateTime.Today;
            prescribedMedicineStartDate1.Value = DateTime.Today;
            patient = ptn;
            employee = emp;
        }
        public Medicine(Employee emp)
        {
            InitializeComponent();
            startDatePicker1.Value = DateTime.Today;
            prescribedMedicineStartDate1.Value = DateTime.Today;
            employee = emp;

        }
        //Click event on add button of running medicine panel
        private void BtnAddRunningMedicine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(medicineNameTextBox1.Text) || string.IsNullOrEmpty(endDayTextBox1.Text))
            {
                DisplayAlert("Danger", "Fill required fields.");
            }
            else
            {
                Models.Medicine.Name=medicineNameTextBox1.Text;
                Models.Medicine.StartDate=DateTime.Parse(startDatePicker1.Text);
                Models.Medicine.EndDay=Convert.ToInt32(endDayTextBox1.Text);
                Models.Medicine.Remarks= remarksTextBox1.Text;
               if (Models.Medicine.Insert(patient.patientID))
                {
                    DataTable dt1 = new DataTable();
                    dt1 = Models.Medicine.FetchRunningMedicines(patient.patientID);
                    runningMedicinesGridView.DataSource = dt1;
                    medicineNameTextBox1.Text = "";
                    endDayTextBox1.Text = "";
                    remarksTextBox1.Text = "";

                    //get previously taken medicine
                    DataTable dt = new DataTable();
                    dt = Models.Medicine.FetchPreviouslyTakenMedicines(patient.patientID);
                    previouslyTakenMedicineGridView.DataSource = dt;
                    DisplayAlert("Success", "Successfully inserted.");

                }
            }

        }

        //CLick event on btnAddPrescribedMedicine
        private void BtnAddPrescribedMedicine_Click(object sender, EventArgs e)
        {
            
            //Validate input here
            if (string.IsNullOrEmpty(prescribedMedicineTextBox1.Text) || string.IsNullOrEmpty(prescribedMedicineEndDayTextBox1.Text))
            {
                DisplayAlert("Danger", "Fill required fields.");
            }
            else
            {
                Models.Medicine.Name = prescribedMedicineTextBox1.Text;
                Models.Medicine.StartDate = DateTime.Parse(prescribedMedicineStartDate1.Text);
                Models.Medicine.EndDay = Convert.ToInt32(prescribedMedicineEndDayTextBox1.Text);
                Models.Medicine.Remarks = prescribedMedicineRemarksTextBox1.Text;
                if (Models.Medicine.Insert(patient.patientID))
                {
                    DataTable dt2 = new DataTable();
                    dt2 = Models.Medicine.FetchRunningMedicines(patient.patientID);
                    runningMedicinesGridView.DataSource = dt2;
                    prescribedMedicineTextBox1.Text = "";
                    prescribedMedicineEndDayTextBox1.Text = "";
                    prescribedMedicineRemarksTextBox1.Text = "";

                    //get previously taken medicine
                    DataTable dt3 = new DataTable();
                    dt3 = Models.Medicine.FetchPreviouslyTakenMedicines(patient.patientID);
                    previouslyTakenMedicineGridView.DataSource = dt3;
                    DisplayAlert("Success", "Successfully inserted.");
                }
            }

        }
        //Click event on Next Button
        private void BtnNext_Click(object sender, EventArgs e)
        {
            //patient status OUT

            //save to database

            //move to dashboard
            Dashboard dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Hide();
            /*
            bool isSucess;
            //Get patient id
            string patientID = lblPatientIDValue.Text;
            //Initialize count
            int count = 1;
            while (count <= noOfRunningMedicine)
            {
                //Instantiate Medicines 
                Models.Medicine medicine = new Models.Medicine();
                if (!string.IsNullOrEmpty(listOfRunningMedicine[count-1].MedicineName.Text) || !string.IsNullOrEmpty(listOfRunningMedicine[noOfRunningMedicine - 1].EndDay.Text))
                {
                    medicine.Name = listOfRunningMedicine[count - 1].MedicineName.Text;
                    medicine.StartDate = listOfRunningMedicine[count - 1].StartDate.Value;
                    medicine.EndDay = Convert.ToInt32(listOfRunningMedicine[count - 1].EndDay.Text);
                    medicine.Remarks =listOfRunningMedicine[count-1].Remarks.Text;
                    medicineList.Add(medicine);
                }
                count++;
                
            }
             //Reinitialize count to 1
             count = 1;
             while(count <= noOfPrescribedMedicine)
             {
                //Instantiate Medicines 
                Models.Medicine medicine = new Models.Medicine();
                if (!string.IsNullOrEmpty(listOfPrescribedMedicine[count - 1].MedicineName.Text) || !string.IsNullOrEmpty(listOfPrescribedMedicine[count - 1].EndDay.Text))
                 {
                     medicine.Name = listOfPrescribedMedicine[count-1].MedicineName.Text;
                     medicine.StartDate=listOfPrescribedMedicine[count-1].StartDate.Value;
                     medicine.EndDay = Convert.ToInt32(listOfPrescribedMedicine[count-1].EndDay.Text);
                     medicine.Remarks =listOfPrescribedMedicine[count-1].Remarks.Text;
                     medicineList.Add(medicine);
                 }
                 count++;
             }

            if (medicineList.Count > 0)
            {
                //Insert data into database
                isSucess = Models.Medicine.Insert(patientID, medicineList);
            }
            else
            {
                //Switch to tests form if there is no any medicine exists in the medicine list
                isSucess = true;
            }
            if (isSucess)
            {
                //Switch to tests form
                var test = new Tests();
                test.Show();
                this.Hide();
            }
            else
            {
                DisplayAlert("Danger", "Error Occured");
            }
            */
        }

        //Load event on medicine form
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(employee.UserID);
            //MessageBox.Show(patient.patientID);

            if (!String.IsNullOrEmpty(patient.patientID))
            {
                //initialize label text
                lblRegistrationDateOutput.Text = patient.registrationDate;
                lblAddressOutput.Text = patient.address;
                lblAgeOutput.Text = patient.age.ToString();
                lblGenderOutput.Text = patient.gender;
                lblFirstNameOutput.Text = patient.firstName;
                lblLastNameOutput.Text = patient.lastName;
                lblContactOutput.Text = patient.contactNumber;
                lblReferredToOutput.Text = patient.referredTo;
                lblPatientIDOutput.Text = patient.patientID;

                //get running medicines
                DataTable dt = new DataTable();
                dt = Models.Medicine.FetchRunningMedicines(patient.patientID);
                runningMedicinesGridView.DataSource = dt;

                //get previously taken medicine
                dt = Models.Medicine.FetchPreviouslyTakenMedicines(patient.patientID);
                previouslyTakenMedicineGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Not allowed", "Error");
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
               
            }
            
            /*
            //Initialize active patient details
            InitializeActiverPatientDetails();

            //Instantiate new row
            MedicineRow row = new MedicineRow();
            row.MedicineName = medicineNameTextBox1;
            row.StartDate = startDatePicker1;
            row.EndDay = endDayTextBox1;
            row.Remarks = remarksTextBox1;
            listOfRunningMedicine.Add(row);

            //Instantiate another row
            MedicineRow anotherRow = new MedicineRow();
            anotherRow.MedicineName = prescribedMedicineTextBox1;
            anotherRow.StartDate = prescribedMedicineStartDate1;
            anotherRow.EndDay = prescribedMedicineEndDayTextBox1;
            anotherRow.Remarks = prescribedMedicineRemarksTextBox1;
            listOfPrescribedMedicine.Add(anotherRow);

            //Load grid view
            LoadGridView();
            */

        }

        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Initialize active patient details
       private void InitializeActiverPatientDetails()
        {
            lblPatientIDOutput.Text = "PTN-21-000000";
        }
        //Hide alert
        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            alertTransition.HideSync(alertPanel);
        }
        //Display alert
        private void DisplayAlert(string type, string message)
        {
            if (type == "Danger")
            {
                alertPanel.BackgroundImage = Properties.Resources.alert_danger_background;
                alertImage.Image = Properties.Resources.alert_danger_icon;
                alertText.ForeColor = Color.Red;

            }
            else if (type == "Success")
            {
                alertPanel.BackgroundImage = Properties.Resources.alert_sucess_background;
                alertImage.Image = Properties.Resources.alert_sucess_icon;
                alertText.ForeColor = Color.Green;
            }
            alertText.Text = message;
            alertTransition.ShowSync(alertPanel);
        }

        //Click event on exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Load Grid View
        private void LoadGridView()
        {
            string patientID = lblPatientIDOutput.Text;
            DataTable dt = Models.Medicine.FetchPreviouslyTakenMedicines(patientID);
            previouslyTakenMedicineGridView.DataSource = dt;
            previouslyTakenMedicineGridView.ClearSelection();

            DataTable dataTable = Models.Medicine.FetchRunningMedicines(patientID);
            runningMedicinesGridView.DataSource =dataTable;
            runningMedicinesGridView.ClearSelection();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
        }

        private void btnTests_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TreatmentWindow treatmentWindow = new TreatmentWindow(employee,patient);
            treatmentWindow.Show();

        }

    }
}
