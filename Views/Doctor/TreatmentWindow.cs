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
        int numberOfOldPrescriptionPanel = 1;
        //to get patientID from 
        string patientID = "";

        //array of text boxes
        Guna2TextBox[] textBoxArray = new Guna2TextBox[5];
        string textBoxName;



        //prescription text Array
        Guna2TextBox[] prescriptionTextBoxArray = new Guna2TextBox[5];
        // prescriptionTextBoxArray[0]=newTopic1TextField;

        //array of old prescription panels
        Guna.UI2.WinForms.Guna2Panel[] arrayOfOldPrescriptionPanel = new Guna2Panel[5];


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
            if (textBoxArray[numberOfTextFields - 1].Text != "")
            {

                if (numberOfTextFields != 5)
                {
                    numberOfTextFields++;

                    int yBtnPoint = 82 + 45 * (numberOfTextFields - 1);
                    int yTextFieldPoint = 37 + 45 * (numberOfTextFields - 1);

                    //to change the position of the Add Topic Button
                    btnAddTopic.Location = new Point(4, yBtnPoint);


                    //to create textfield on the history panel
                    Guna2TextBox textBox = new Guna2TextBox();
                    textBoxName = "newTopic" + numberOfTextFields + "TextField";
                    textBox.Name = textBoxName;


                    textBox.PlaceholderText = "New Topic";

                    textBox.Location = new Point(4, yTextFieldPoint);

                    textBox.Size = new Size(149, 33);

                    this.prescriptionPanel.Controls.Add(textBox);

                    textBox.Focus();





                    if (numberOfTextFields == 5)
                    {
                        btnAddTopic.Enabled = false;
                    }
                }
            }
        }

        private void PrescriptionPanel_Paint(object sender, PaintEventArgs e)
        {


            lblTodaysDateOutput.Text = Generator.GetRegistrationDate();
        }



        private void PatientSerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            patientID = lblPtn.Text + "-" + yearComboBox + "-" + patientSerialNumberTextBox.Text;
        }

        //when we type topic on topic textbox it changes to the text field also
        private void NewTopic1TextField_TextChanged(object sender, EventArgs e)
        {
            lblTodaysPrescriptionTitleOutput.Text = ": " + newTopic1TextField.Text;
        }

        int i = 0;
        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            DataTable dt = Prescription.GetPatientPrescriptionHistory(patientID);
             if (dt.Rows.Count > 0)
            {
             foreach (DataRow dr in dt.Rows)
           
            {

                int panelYCoordinate = 194 * numberOfOldPrescriptionPanel;
                numberOfOldPrescriptionPanel++;
                MessageBox.Show(panelYCoordinate.ToString());
                //create old prescription panel 
                Guna2Panel pnl = new Guna2Panel();
                arrayOfOldPrescriptionPanel[i] = pnl;
                pnl.Location = new Point(0, panelYCoordinate);
                pnl.Size = new Size(804, 194);
                pnl.Name = "oldPrescriptionPanel" + numberOfOldPrescriptionPanel;
                pnl.BringToFront();
                pnl.Visible = true;

                //create 
                Guna2TextBox tb = new Guna2TextBox();
                tb.Name = "oldPrescriptionTextField" + numberOfOldPrescriptionPanel;
                // tb.Text = i[3].ToString();
                tb.Text = "lalalalala";
                tb.Location = new Point(12, 20);
                tb.Size = new Size(789, 153);
                tb.Multiline = true;
                tb.Visible = true;

                Label lb1 = new Label();
                lb1.Name = "lblprescriptionDateOutput" + numberOfOldPrescriptionPanel;
                //  lb1.Text = i[1].ToString();
                lb1.Text = "sdfsssssssssssss";
                lb1.Location = new Point(10, 2);
                lb1.Visible = true;
                lb1.Size = new Size(97, 15);



                Label lb2 = new Label();
                lb2.Name = "lblPrescriptionTitleOutput" + numberOfOldPrescriptionPanel;
                //lb2.Text = i[2].ToString();
                lb2.Text = "aaaaaaaaaa";
                lb2.Location = new Point(119, 2);
                lb2.Size = new Size(119, 2);
                


                Label lb3 = new Label();
                lb3.Name = "lblPrescribedBy" + numberOfOldPrescriptionPanel;
                lb3.Text = "Prescribed By:";
                lb3.Location = new Point(556, 173);
                lb3.Size = new Size(84, 15);


                Label lb4 = new Label();
                lb4.Name = "lblPrescribedDoctorNameOutput";
                lb4.Text = "vvvvvvvvvv";
                lb4.Location = new Point(651, 173);
                lb4.Size = new Size(135, 15);

                //add to the panel
                this.prescriptionDisplayPanel.Controls.Add(arrayOfOldPrescriptionPanel[i]);
                this.arrayOfOldPrescriptionPanel[i].Controls.Add(tb);
                this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb1);
                this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb2);
                this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb3);
                this.arrayOfOldPrescriptionPanel[i].Controls.Add(lb4);
                MessageBox.Show("added to their respective place!" );
                i++;
            


            }
            MessageBox.Show("inside if");
             }
             else
            {
               MessageBox.Show("inside else");

             }
        }
    }
}
