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

namespace webTRON_Management_Software
{
    public partial class CreateAccount : Form
    {
        //Instantiate Employee Class
        Employee obj = new Employee();
        //Instantiate USer Class
        User newUser = new User();
      
       
        public CreateAccount()
        {
            InitializeComponent();
        }
        //Removeable code block
        private void button1_Click(object sender, EventArgs e)
        {
            if (sideBar.Visible)
            {
                sideBarTransition.HideSync(sideBar);
            }
            else
            {
                sideBarTransition.ShowSync(sideBar);
               
            }
        }
        //Submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Instantiate Object Properties
            obj.Role = roleComboBox.Text;
            obj.FirstName = firstNameTxtBox.Text.Trim();
            obj.LastName = lastNameTextBox.Text.Trim();
            obj.Email = emailTextBox.Text.Trim();
            obj.Address = addressTextBox.Text.Trim();
            obj.DateOfBirth = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
            obj.ContactNumber = contactNumberTextBox.Text;
            if(roleComboBox.Text=="Doctor")
            obj.userID = Generator.generateDoctorId();
            else if (roleComboBox.Text == "Management")
                obj.userID = Generator.generateManagementId();
            else if (roleComboBox.Text == "Adimn")
                obj.userID = Generator.generateAdminId();
            else if (roleComboBox.Text == "Accountant")
                obj.userID = Generator.generateAccountantId();

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

            //Input validation ---------- Much better if done before initializing the values to the object
            if (obj.Role=="" || obj.FirstName == "" || obj.LastName == "" || obj.Email == "" || obj.Address == "" || obj.DateOfBirth == "" || obj.ContactNumber == "" || obj.Sex == "")
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Insert object in database
                bool isSucess = obj.Insert(obj);

                if (isSucess)
                {
                    //Store user's user ID and password in users table
                    bool isUserCreated = storeUser();
                    if (isUserCreated)
                    {
                        bool isSend = Email.SendAccountInfo(obj.Email, newUser.userID,newUser.password);
                        if (isSend)
                        {
                            //Show small popup here
                            MessageBox.Show("New account has been created sucessfully.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetFormFields();

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
        private void resetFormFields()
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
        private bool storeUser()
        {
           //If account is created sucesfully then store corresponding user's userID and password in (users) table
            newUser.userID = obj.userID;
            newUser.password = Generator.generatePassword();
            bool isSucess=newUser.Insert(newUser);
            return isSucess;
            
        }
    }
}
