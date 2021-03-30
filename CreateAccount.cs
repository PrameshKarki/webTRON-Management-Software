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
        Employee obj = new Employee();
      
       
        public CreateAccount()
        {
            InitializeComponent();
        }

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
            obj.FirstName = firstNameTxtBox.Text;
            obj.LastName = lastNameTextBox.Text;
            obj.Email = emailTextBox.Text;
            obj.Address = addressTextBox.Text;
            obj.DateOfBirth = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
            obj.ContactNumber = contactNumberTextBox.Text;
            obj.userID = Generator.generateUserId(obj.Role);
           
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

            //Input validation
            if (obj.Role=="" || obj.FirstName == "" || obj.LastName == "" || obj.Email == "" || obj.Address == "" || obj.DateOfBirth == "" || obj.ContactNumber == "" || obj.Sex == "")
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool isSucess = obj.Insert(obj);
                if (isSucess)
                {
                    MessageBox.Show("New account has been created sucessfully.","Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bool isS=Email.SendAccountInfo(obj.Email, obj.userID, Generator.generatePassword());
                    resetFormFields();
                    MessageBox.Show(isS.ToString());
                    
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

        
    }
}
