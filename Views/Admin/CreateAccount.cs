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
using webTRON_Management_Software.Views.Landing_Window;

namespace webTRON_Management_Software.Views.Admin
{
    public partial class CreateAccount : Form
    {
        //Instantiate Employee Class
        Employee obj = new Employee();
        Employee employee = new Employee();
        //Instantiate USer Class
        User newUser = new User();
      
       
        public CreateAccount()
        {
            InitializeComponent();
        }

        public CreateAccount(Employee emp)
        {
            employee = emp;
            InitializeComponent();
        }



        //Submit button click
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Input Validation

            if (string.IsNullOrEmpty(roleComboBox.Text) || string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(contactNumberTextBox.Text) || (!isMale.Checked && !isFemale.Checked && !isOthers.Checked))
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Instantiate Object Properties
                obj.Role = roleComboBox.Text;
                obj.FirstName = firstNameTxtBox.Text.Trim();
                obj.LastName = lastNameTextBox.Text.Trim();
                obj.Email = emailTextBox.Text.Trim();
                obj.Address = addressTextBox.Text.Trim();
                obj.DateOfBirth = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
                obj.ContactNumber = contactNumberTextBox.Text;
                
                //UserID
                if(roleComboBox.Text=="Doctor")
                     obj.UserID = Generator.GenerateDoctorId();
                else if (roleComboBox.Text == "Admin")
                    obj.UserID = Generator.GenerateAdminId();
                else if (roleComboBox.Text == "Accountant")
                    obj.UserID = Generator.GenerateAccountantId();
                
                //Fetch Sex
                if (isMale.Checked)
                {
                    obj.Sex = isMale.Text;
                }else if (isFemale.Checked)
                {
                    obj.Sex = isFemale.Text;
                }else if (isOthers.Checked)
                {
                    obj.Sex = isOthers.Text;
                }
           
                //Set default user status offline
                obj.Status = "Offline";
                    //Insert object in database
                    bool isSucess = Employee.Insert(obj);

                    if (isSucess)
                    {
                        //Store user's user ID and password in users table
                        bool isUserCreated = StoreUser();
                        if (isUserCreated)
                        {
                            bool isSend = Email.SendAccountInfo(obj.Email, newUser.userID,newUser.password);
                            if (isSend)
                            {
                                //Show small popup here
                                MessageBox.Show("New account has been created sucessfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetFormFields();

                            }
                            else
                            {
                                //Show error popup here
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error Occured.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Occured.Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        
        }
        //Method to reset form input fields
        private void ResetFormFields()
        {
         
            firstNameTxtBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            addressTextBox.Text = "";
            dateOfBirthPicker.Value =new DateTime(2000,1,1) ;
            contactNumberTextBox.Text = "";
            isMale.Checked = false;
            isFemale.Checked = false;
            isOthers.Checked = false;
        }

        //Method to store user's userID and password in user table when account is sucessfully created
        private bool StoreUser()
        {
           //If account is created sucesfully then store corresponding user's userID and password in (users) table
            newUser.userID = obj.UserID;
            newUser.password = Generator.GeneratePassword();
            bool isSucess=newUser.Insert(newUser);
            return isSucess;
            
        }
        //Click event on Dashboard button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            var dashboard = new Admin.Dashboard(employee);
            dashboard.Show();
            this.Hide();
        }
        //Click event on Settings button
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settings = new Admin.Settings(employee);
            settings.Show();
            this.Hide();

        }

        //Click event on Minimize button
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        //Load Event on Create Account Form
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            //Initialize Active User Details
            InitializeActiverUserDetails();

        }
        //Initialize Active User Details
        private void InitializeActiverUserDetails()
        {
            activeUserName.Text = employee.FirstName;


        }
      
        //Click event on signout and exit button
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
        //Click event on users button
        private void BtnUsers_Click(object sender, EventArgs e)
        {
                //Instantiating user form
                var users = new Users(employee);
                users.Show();
                this.Hide();

        }
        
    }
}
