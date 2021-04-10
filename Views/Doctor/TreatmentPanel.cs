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

namespace webTRON_Management_Software.Views.Doctor
{
    public partial class TreatmentPanel : Form
    {
        int numberOfTextFields = 1;
        Guna.UI2.WinForms.Guna2TextBox[] textBoxArray = new Guna2TextBox[5];
       // textBoxArray[0]=   Guna.UI2.WinForms;
        Guna.UI2.WinForms.Guna2TextBox[] prescriptionTextBoxArray = new Guna2TextBox[5];
        Guna.UI2.WinForms.Guna2Panel[] prescriptionPanelArray = new Guna2Panel[5];
        public TreatmentPanel()
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

                int yBtnPoint=82+45*(numberOfTextFields-1);
                int yTextFieldPoint= 37 + 45 * (numberOfTextFields - 1);

                //to change the position of the Add Topic Button
                btnAddTopic.Location = new Point(4,yBtnPoint);


                //to create textfield on the history panel
                Guna.UI2.WinForms.Guna2TextBox textBox = new Guna2TextBox();
                textBox.Name = "newTopic" + numberOfTextFields + "TextField";
                textBox.PlaceholderText = "New Topic";
                textBox.Location = new Point(4, yTextFieldPoint);
                textBox.Size = new Size(149, 33);
                this.historyPanel.Controls.Add(textBox);
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

                // for textfield inside prescription textfields
                Guna.UI2.WinForms.Guna2TextBox prescriptionTextBox = new Guna2TextBox();
                prescriptionTextBox.Name= "prescription" + numberOfTextFields + "TextBox";
                prescriptionTextBox.Location = new Point(225, 120*(numberOfTextFields-1));
                prescriptionTextBox.Size = new Size(761, 108);
                prescriptionTextBox.Text = "Hey! Give him your Prescription.";
                prescriptionTextBox.BringToFront();
                prescriptionTextBox.Focus();
               // MessageBox.Show(prescriptionPanelArray[numberOfTextFields - 1].Enabled.ToString());
                this.historyPanel.Controls.Add(prescriptionTextBox);
                //initialize prescriptionTextBoxarray
                prescriptionTextBoxArray[numberOfTextFields - 1] = prescriptionTextBox;
                prescriptionTextBox.Text = numberOfTextFields.ToString();
               
                if (numberOfTextFields == 5)
                {
                    btnAddTopic.Enabled = false;
                }
            }
        }


    }
}
