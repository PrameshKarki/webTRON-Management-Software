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
        public Medicine()
        {
            InitializeComponent();
        }

        //Click event on add button of running medicine panel
        private void BtnAddRunningMedicine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(listOfRunningMedicine[noOfRunningMedicine-1].MedicineName.Text) || string.IsNullOrEmpty(listOfRunningMedicine[noOfRunningMedicine - 1].EndDay.Text))
            {
                DisplayAlert("Danger", "Fill required fields.");
            }
            else
            {
                //Increment no of running medicine
                noOfRunningMedicine++;

                //Initialize y co-ordinate 
                int yCoOrdidate =110 + 40 * (noOfRunningMedicine - 1);
                
                //Instantiate new text box(We need 3 text box so)
                Guna2TextBox txtBox1 = new Guna2TextBox();
                Guna2TextBox txtBox2 = new Guna2TextBox();
                Guna2TextBox txtBox3 = new Guna2TextBox();

                //Instantiate new label(We need 4 label so)
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Label lbl4 = new Label();

                //Instantiate new date picker
                Guna2DateTimePicker datePicker = new Guna2DateTimePicker();


                //Set properties of label1
                lbl1.Text = "Medicine Name:";
                lbl1.Location = new Point(6, yCoOrdidate);
                lbl1.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of label2
                lbl2.Text = "Start Date:";
                lbl2.Location = new Point(306, yCoOrdidate);
                lbl2.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of label3
                lbl3.Text = "End Day:";
                lbl3.Location = new Point(526, yCoOrdidate);
                lbl3.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of label4
                lbl4.Text = "Remarks:";
                lbl4.Location = new Point(658, yCoOrdidate);
                lbl4.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of text box1
               
                txtBox1.Name = $"medicineNameTextBox{noOfRunningMedicine}";
                txtBox1.PlaceholderText = "Medicine Name";
                txtBox1.Font = new Font("Segoe UI", 10);
                txtBox1.Size = new Size(177, 30);
                txtBox1.Location = new Point(117, yCoOrdidate);
                txtBox1.ForeColor = Color.Black;

                //Set properties of text box2
                txtBox2.Name = $"endDayTextBox{noOfRunningMedicine}";
                txtBox2.PlaceholderText = "End Day";
                txtBox2.Font = new Font("Segoe UI", 10);
                txtBox2.Size = new Size(52, 30);
                txtBox2.Location = new Point(596, yCoOrdidate);
                txtBox2.ForeColor = Color.Black;


                //Set properties of text box3
                txtBox3.Name = $"remarksTextBox{noOfRunningMedicine}";
                txtBox3.PlaceholderText = "Remarks";
                txtBox3.Font = new Font("Segoe UI", 10);
                txtBox3.Size = new Size(196, 30);
                txtBox3.Location = new Point(730, yCoOrdidate);
                txtBox3.ForeColor = Color.Black;


                //Set properties of date picker
                datePicker.Name = $"startDatePicker{noOfRunningMedicine}";
                datePicker.FillColor = Color.FromArgb(23, 107, 207);
                datePicker.Size = new Size(129, 30);
                datePicker.Location = new Point(385, yCoOrdidate);
                datePicker.ForeColor = Color.White;

                //Set properties of add btn
                btnAddRunningMedicine.Location = new Point(934, yCoOrdidate);

                //Add controls in panel
                //this.runningMedicinePanel.Controls.Add(txtBox1);
                //Labels
                this.runningMedicinePanel.Controls.Add(lbl1);
                this.runningMedicinePanel.Controls.Add(lbl2);
                this.runningMedicinePanel.Controls.Add(lbl3);
                this.runningMedicinePanel.Controls.Add(lbl4);
                //text box
                this.runningMedicinePanel.Controls.Add(txtBox1);
                this.runningMedicinePanel.Controls.Add(txtBox2);
                this.runningMedicinePanel.Controls.Add(txtBox3);
                //date Picker
                this.runningMedicinePanel.Controls.Add(datePicker);


                //Add newly created text boxes to the list
                
                //Instantiate new Row
                MedicineRow row = new MedicineRow();
                row.MedicineName = txtBox1;
                row.StartDate = datePicker;
                row.EndDay = txtBox2; ;
                row.Remarks = txtBox3;
                listOfRunningMedicine.Add(row);
            }

        }

        //CLick event on btnAddPrescribedMedicine
        private void BtnAddPrescribedMedicine_Click(object sender, EventArgs e)
        {
            
            //Validate input here
            if (string.IsNullOrEmpty(listOfPrescribedMedicine[noOfPrescribedMedicine - 1].MedicineName.Text) || string.IsNullOrEmpty(listOfPrescribedMedicine[noOfPrescribedMedicine - 1].EndDay.Text))
            {
                DisplayAlert("Danger", "Fill required fields.");
            }
            else
            {
                //Increment no of running medicine
                noOfPrescribedMedicine++;

                //Initialize y co-ordinate 
                int yCoOrdidate =13 + 40 * (noOfPrescribedMedicine - 1);
                
                //Instantiate new text box(We need 3 text box so)
                Guna2TextBox txtBox1 = new Guna2TextBox();
                Guna2TextBox txtBox2 = new Guna2TextBox();
                Guna2TextBox txtBox3 = new Guna2TextBox();

                //Instantiate new label(We need 4 label so)
                Label lbl1 = new Label();
                Label lbl2 = new Label();
                Label lbl3 = new Label();
                Label lbl4 = new Label();

                //Instantiate new date picker
                Guna2DateTimePicker datePicker = new Guna2DateTimePicker();


                //Set properties of label1
                lbl1.Text = "Medicine Name:";
                lbl1.Location = new Point(9, yCoOrdidate);
                lbl1.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of label2
                lbl2.Text = "Start Date:";
                lbl2.Location = new Point(309, yCoOrdidate);
                lbl2.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of label3
                lbl3.Text = "End Day:";
                lbl3.Location = new Point(529, yCoOrdidate);
                lbl3.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of label4
                lbl4.Text = "Remarks:";
                lbl4.Location = new Point(661, yCoOrdidate);
                lbl4.Font = new Font("Microsoft Sans Serif", 10);

                //Set properties of text box1

                txtBox1.Name = $"prescribedMedicineTextBox{noOfRunningMedicine}";
                txtBox1.PlaceholderText = "Medicine Name";
                txtBox1.Font = new Font("Segoe UI", 10);
                txtBox1.Size = new Size(177, 30);
                txtBox1.Location = new Point(120, yCoOrdidate);
                txtBox1.ForeColor = Color.Black;

                //Set properties of text box2
                txtBox2.Name = $"prescribedMedicineEndDayTextBox{noOfRunningMedicine}";
                txtBox2.PlaceholderText = "End Day";
                txtBox2.Font = new Font("Segoe UI", 10);
                txtBox2.Size = new Size(52, 30);
                txtBox2.Location = new Point(599, yCoOrdidate);
                txtBox2.ForeColor = Color.Black;


                //Set properties of text box3
                txtBox3.Name = $"prescribedMedicineRemarksTextBox{noOfRunningMedicine}";
                txtBox3.PlaceholderText = "Remarks";
                txtBox3.Font = new Font("Segoe UI", 10);
                txtBox3.Size = new Size(196, 30);
                txtBox3.Location = new Point(734, yCoOrdidate);
                txtBox3.ForeColor = Color.Black;


                //Set properties of date picker
                datePicker.Name = $"prescribedMedicineStartDate{noOfRunningMedicine}";
                datePicker.FillColor = Color.FromArgb(23, 107, 207);
                lbl2.Font = new Font("Microsoft Sans Serif", 10);
                datePicker.Size = new Size(129, 30);
                datePicker.Location = new Point(388, yCoOrdidate);
                datePicker.ForeColor = Color.White;
                datePicker.Enabled = false;

                //Set properties of add btn
                btnAddPrescribedMedicine.Location = new Point(937, yCoOrdidate);

                //Add controls in panel
                this.prescribedMedicinePanel.Controls.Add(txtBox1);
                //Labels
                this.prescribedMedicinePanel.Controls.Add(lbl1);
                this.prescribedMedicinePanel.Controls.Add(lbl2);
                this.prescribedMedicinePanel.Controls.Add(lbl3);
                this.prescribedMedicinePanel.Controls.Add(lbl4);
                //text box
                this.prescribedMedicinePanel.Controls.Add(txtBox1);
                this.prescribedMedicinePanel.Controls.Add(txtBox2);
                this.prescribedMedicinePanel.Controls.Add(txtBox3);
                //date Picker
                this.prescribedMedicinePanel.Controls.Add(datePicker);

                //Instantiate medicine row
                MedicineRow row = new MedicineRow();
                row.MedicineName = txtBox1;
                row.StartDate = datePicker;
                row.EndDay = txtBox2;
                row.Remarks = txtBox3;
                listOfPrescribedMedicine.Add(row);


            }

        }
        //Click event on Next Button
        private void BtnNext_Click(object sender, EventArgs e)
        {
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

        }

        //Load event on medicine form
        private void MedicineForm_Load(object sender, EventArgs e)
        {
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

        }

        //Click event on minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Initialize active patient details
       private void InitializeActiverPatientDetails()
        {
            lblPatientIDValue.Text = "PTN-21-000000";
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
            else if (type == "Sucess")
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
            string patientID = lblPatientIDValue.Text;
            DataTable dt = Models.Medicine.FetchPreviouslyTakenMedicines(patientID);
            previouslyTakenMedicineGridView.DataSource = dt;
            previouslyTakenMedicineGridView.ClearSelection();

            DataTable dataTable = Models.Medicine.FetchRunningMedicines(patientID);
            runningMedicinesGridView.DataSource =dataTable;
            runningMedicinesGridView.ClearSelection();
        }

      
    }
}
