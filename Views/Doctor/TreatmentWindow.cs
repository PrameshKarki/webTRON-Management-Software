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
    public partial class TreatmentWindow : Form
    {
        int numberOfTextFields = 1;
        //to get patientID from 
        string patientID="";
        Guna.UI2.WinForms.Guna2TextBox[] textBoxArray = new Guna2TextBox[5];
        // textBoxArray[0]=   Guna.UI2.WinForms;
        Guna.UI2.WinForms.Guna2TextBox[] prescriptionTextBoxArray = new Guna2TextBox[5];
        Guna.UI2.WinForms.Guna2Panel[] prescriptionPanelArray = new Guna2Panel[5];
        public TreatmentWindow()
        {
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

        private void BtnAddTopic_Click(object sender, EventArgs e)
        {

            if (numberOfTextFields != 5)
            {
                numberOfTextFields++;

                int yBtnPoint = 82 + 45 * (numberOfTextFields - 1);
                int yTextFieldPoint = 37 + 45 * (numberOfTextFields - 1);

                //to change the position of the Add Topic Button
                btnAddTopic.Location = new Point(4, yBtnPoint);

                
                //to create textfield on the history panel
                Guna.UI2.WinForms.Guna2TextBox textBox = new Guna2TextBox();

                textBox.Name = "newTopic" + numberOfTextFields + "TextField";

                textBox.PlaceholderText = "New Topic";

                textBox.Location = new Point(4, yTextFieldPoint);
                
                textBox.Size = new Size(149, 33);

                this.prescriptionPanel.Controls.Add(textBox);

                textBox.Focus();
                //initialize to textBox array
                textBoxArray[numberOfTextFields - 1] = textBox;

                


                /*
                // to add the prescription Panel;
                Guna.UI2.WinForms.Guna2Panel prescriptionPanel = new Guna2Panel();
                prescriptionPanel.Name = "prescription" + numberOfTextFields + "Panel";
                prescriptionPanel.Location = new Point(228, 37);
                prescriptionPanel.Size = new Size(755, 336);
                prescriptionPanel.BringToFront();
                MessageBox.Show(prescriptionPanel.Visible.ToString());
                this.historyPanel.Controls.Add(prescriptionPanel);
                //to initialize prescription Panel array
                prescriptionPanelArray[numberOfTextFields - 1] = prescriptionPanel;
                */
                /*
                // for textfield inside prescription textfields
                Guna.UI2.WinForms.Guna2TextBox prescriptionTextBox = new Guna2TextBox();
                prescriptionTextBox.Name = "prescription" + numberOfTextFields + "TextBox";
                prescriptionTextBox.Location = new Point(225, 120 * (numberOfTextFields - 1));
                prescriptionTextBox.Size = new Size(761, 108);
                prescriptionTextBox.Text = "Hey! Give him your Prescription.";
                prescriptionTextBox.BringToFront();
                prescriptionTextBox.Focus();
                // MessageBox.Show(prescriptionPanelArray[numberOfTextFields - 1].Enabled.ToString());
                this.historyPanel.Controls.Add(prescriptionTextBox);
                //initialize prescriptionTextBoxarray
                prescriptionTextBoxArray[numberOfTextFields - 1] = prescriptionTextBox;
                prescriptionTextBox.Text = numberOfTextFields.ToString();
                */



                if (numberOfTextFields == 5)
                {
                    btnAddTopic.Enabled = false;
                }
            }
        }

        private void PrescriptionPanel_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Prescription.GetPatientPrescriptionHistory(patientID);
          
            if (dt.Rows!=null)
            {
               
                //display table data 
            }
            else
            {
                prescriptionHistory1TextField.Enabled = false;
                prescriptionHistory1TextField.Visible = false;

                todaysPrescriptionPanel.Location = new Point(3, 34);
                lblTodaysDateOutput.Text = Generator.GetRegistrationDate();
            }
        }

        private void PatientSerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            patientID = lblPtn.Text + "-" + yearComboBox + "-" + patientSerialNumberTextBox.Text;
        }
    }
}
