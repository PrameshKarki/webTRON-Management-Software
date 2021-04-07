using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webTRON_Management_Software.Models;
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Others
{
    public partial class ChangeInfo : Form
    {
        //Instantiate employee class
        Employee employee = new Employee();
        public ChangeInfo()
        {
            InitializeComponent();
        }
        public ChangeInfo(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }

        //CLick event on update button
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text) || (!isMale.Checked && !isFemale.Checked && !isOthers.Checked))
            {
                MessageBox.Show("Fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instantiate employee class
                Employee obj = new Employee();
                obj.UserID = employee.UserID;
                obj.FirstName = firstNameTxtBox.Text.Trim();
                obj.LastName = lastNameTextBox.Text.Trim();
                obj.Email = emailTextBox.Text;
                obj.Address = addressTextBox.Text;
                obj.ContactNumber = contactNumberTextBox.Text;
                obj.DateOfBirth = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
                //Fetch Sex
                if (isMale.Checked)
                {
                    obj.Sex = isMale.Text;
                }
                else if (isFemale.Checked)
                {
                    obj.Sex = isFemale.Text;
                }
                else if (isOthers.Checked)
                {
                    obj.Sex = isOthers.Text;
                }
                //Update information
                bool isInformationUpdatedSucessfully = Employee.Update(obj);
                if (isInformationUpdatedSucessfully)
                {
                    MessageBox.Show("Information updated sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Upadte new information instantly
                    UpdateInformation();
                    //Clear Fields
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Error Occured!Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Click event on Dashboard button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //Instantiate dashboard form
            var dashboard = new Dashboard(employee);
            dashboard.Show();
            this.Close();
        }

        //Click event in Settings button
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //Instantiate settings form
            var settings = new Settings(employee);
            settings.Show();
            this.Close();

        }
        //Sign out
        private void SignOut(object sender, EventArgs e)
        {
            //WARNING:To check which element has clicked          
            string elementType = sender.GetType().ToString();
            var value = MessageBox.Show("Are you sure?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (value.ToString() == "Yes")
            {
                Employee.SetStatus(employee.UserID, "Offline");
                //It ensures sign out has clicked
                if (elementType == "Guna.UI2.WinForms.Guna2Button")
                {
                    LandingWindow landingWindow = new LandingWindow();
                    landingWindow.Show();
                    this.Hide();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        //Click event on minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Load event on change info form
        private void ChangeInfo_Load(object sender, EventArgs e)
        {
            //Initialize active user details
            InitializeActiverUserDetails();

        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            DateTime dateOfBirth = DateTime.Parse(employee.DateOfBirth);
            activeUserName.Text = employee.FirstName;
            userIdValue.Text = employee.UserID;
            roleValue.Text = employee.Role;
            firstNameTxtBox.Text = employee.FirstName;
            lastNameTextBox.Text = employee.LastName;
            emailTextBox.Text = employee.Email;
            addressTextBox.Text = employee.Address;
            dateOfBirthPicker.Value = dateOfBirth;
            contactNumberTextBox.Text = employee.ContactNumber;
            if (employee.Sex == "Male")
            {
                isMale.Checked = true;
            }
            else if (employee.Sex == "Female")
            {
                isFemale.Checked = true;

            }
            else
            {
                isOthers.Checked = true;
            }
            if (employee.img != null)
            {
                //Change active user picture
                MemoryStream ms = new MemoryStream(employee.img);
                activeUserPicture.Image = Image.FromStream(ms);
            }

        }
        //Update information instantly
        private void UpdateInformation()
        {
            string userID = employee.UserID;
            employee = Employee.GetActiveUserDetails(userID);
            activeUserName.Text = employee.FirstName;
        }
        //Clear form fields
        private void ClearFields()
        {
            firstNameTxtBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            dateOfBirthPicker.Value = new DateTime(2000, 1, 1);
            contactNumberTextBox.Text = "";
            isMale.Checked = false;
            isFemale.Checked = false;
            isOthers.Checked = false;
        }

    }
}
