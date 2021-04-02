using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace webTRON_Management_Software.Models
{
    class Employee
    {
        //Connection String
        private static string connectionString="server=localhost;user id=root;pwd=password;database=webtronmanagement";
        //Properties
        public string userID { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        
        //Methods
        //Method to insert Employee data in database 
        public bool Insert(Employee obj)
        {
            //Declaring a default bool variable and initializing false
            bool isSucess = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //String SqlQuery
                string SQLQuery = "INSERT INTO employeeInfo(userID,firstName,lastName,email,address,contactNumber,dateOfBirth,sex,role,status) VALUES(@userID,@firstName,@lastName,@email,@address,@contactNumber,@dateOfBirth,@sex,@role,@status)";
                //MySql Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", obj.userID);
                cmd.Parameters.AddWithValue("@firstName", obj.FirstName);
                cmd.Parameters.AddWithValue("@lastName", obj.LastName);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@address", obj.Address);
                cmd.Parameters.AddWithValue("@contactNumber", obj.ContactNumber);
                cmd.Parameters.AddWithValue("@dateOfBirth", obj.DateOfBirth);
                cmd.Parameters.AddWithValue("@sex", obj.Sex);
                cmd.Parameters.AddWithValue("@role", obj.Role);
                cmd.Parameters.AddWithValue("@status", obj.Status);
                //Connection Open
                conn.Open();
                //Execute Query
                //Here ExecuteNonQuery() returns the number of rows affected
                int row = cmd.ExecuteNonQuery();
                isSucess = row > 0 ? true : false;

            }
            /*catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            finally
            {
                //Close Connection
                conn.Close();
            }
            return isSucess;
           
        }

        //Method to check wheather the email is exist in database or not
        public bool IsEmailExist(string email)
        {
            //Declaring default bool variable and initiazling it false
            bool isExist = false;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string SQLQuery = "SELECT EXISTS(Select userID FROM employeeInfo WHERE email=BINARY @email)";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Creating parameter to add values
                cmd.Parameters.AddWithValue("@email", email);

                //Open Connection
                conn.Open();
                //ExecuteQuery->In above query it returns either 0 or 1 
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    int count = Convert.ToInt32(returnValue);
                    isExist = count == 1 ? true : false;
                }
                else
                {
                    MessageBox.Show("Error Occured!\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return isExist;

        }
        //Method to store verification code in database
         public bool StoreVerificationCode(string userEmail,double verificationCode)
        {
            //Fetched user ID
            string fetchedUserID = "";
           
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //First SQLQuery
                string SQLQueryFirst = "SELECT userID FROM employeeInfo WHERE email=BINARY @userEmail";
                //Second SQLQuery
                string SQLQuerySecond = "INSERT INTO verificationCodes(userID,code) VALUES(@fetchedUserID,@verificationCode) ON DUPLICATE KEY UPDATE code=@verificationCode";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQueryFirst, conn);

                //Add Parameters
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                //Open Connection
                conn.Open();
                //Execute query
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    fetchedUserID = returnValue.ToString();


                }
                else
                {
                    MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmd = new MySqlCommand(SQLQuerySecond, conn);
                cmd.Parameters.AddWithValue("@fetchedUserID", fetchedUserID);
                cmd.Parameters.AddWithValue("@verificationCode", verificationCode);
                //Execute query
                cmd.ExecuteNonQuery();
                

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            finally
            {
                //Close Connection
                conn.Close();
            }
            return true;

        }
        //Method to check valid verification code
        public bool IsValidVerificationCode(string userEmail,int code)
        {
            //Declare default variable and set it false
            bool isValid = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //SQL Query
                string SQLQuery = "SELECT EXISTS(SELECT userID FROM employeeInfo NATURAL JOIN verificationCodes WHERE email=BINARY @userEmail AND code=@code)";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery,conn);
                //Pass parameters
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                cmd.Parameters.AddWithValue("@code", code);
                //Connection open
                conn.Open();
                //Execute query->it returns either 0 or 1
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    int value = Convert.ToInt32(returnValue);
                    isValid = value == 1 ? true : false;
                }
                else
                {
                    MessageBox.Show("Error Occured!\nPlease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //Method to update password from database
        public bool UpdatePassword(string userEmail,string newPassword)
        {
            //Fetched user ID
            string fetchedUserID = "";

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //First SQLQuery
                string SQLQueryFirst = "SELECT userID FROM employeeInfo WHERE email=BINARY @userEmail";
                //Second SQLQuery
                string SQLQuerySecond = "UPDATE Users SET password=AES_ENCRYPT(@newPassword,'webTRON') WHERE userID=BINARY @userID";
                //MySQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQueryFirst, conn);

                //Add Parameters
                cmd.Parameters.AddWithValue("@userEmail", userEmail);
                //Open Connection
                conn.Open();
                //Execute query
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    fetchedUserID = returnValue.ToString();


                }
                else
                {
                    MessageBox.Show("Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmd = new MySqlCommand(SQLQuerySecond, conn);
                cmd.Parameters.AddWithValue("@userID", fetchedUserID);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                //Execute query
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Close Connection
                conn.Close();
            }
            //Password changed sucessfully so return true
            return true;

        }

    }
}
