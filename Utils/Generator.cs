using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Utils
{
    class Generator
    {
        //Connection String
        private static string connectionString = "server=localhost;user id=root; password=laxudb;persistsecurityinfo=True;database=webtronmanagement";

        //Possible Characters
        static char[] upperCaseLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static char[] lowerCaseLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static char[] possibleNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char[] possibleSpecialCharacters = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=' };

        //Array of possible combination
       static char[][] possibleCombinations = new char[4][] { upperCaseLetters, lowerCaseLetters, possibleNumbers, possibleSpecialCharacters };

        //Method that generates random Number in between range
        private static int getRandomNumber(int min, int max)
        {
            Random r = new Random();
            int randomNumber = r.Next(min, max);
            return randomNumber;
        }
           
        //Method that generates random password and returns it
        public static string generatePassword()
        {
            int index;
            string password = "";
            //Here 6 is default password length
            for (index = 0; index < 6; index++)
            {
                int randomNumber = getRandomNumber(0, possibleCombinations.Length);
                char[] pickedArray = possibleCombinations[randomNumber];
                randomNumber = getRandomNumber(0, pickedArray.Length);
                string pickedLetters = pickedArray[randomNumber].ToString();
                password += pickedLetters;

            }
            return password;
        }
        //EmployeeID generator
        public static string generateEmployeeId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            int initiator = 121212;
            int counter, countOfTotalUser=0;
           
            string userID = "";
           
            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(UserID) FROM EmployeeInfo where Role=Employee";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if(returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID += "EMP-" + date + "-" + counter;
            return userID;

        }

        //DoctorId generator
        public static string generateDoctorId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            int initiator = 434343;
            int counter, countOfTotalUser = 0;

            string userID = "";

            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(UserId) FROM EmployeeInfo where Role=Doctor";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID += "DIR-" + date + "-" + counter;
            return userID;

        }
        //patinetID generator
        public static string generatePatientId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            int initiator = 545454;
            int counter, countOfTotalUser = 0;

            string userID = "";

            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(Registration_Number) FROM patientinfo";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID = "PTN-" + date + "-" + counter;


            return userID;

        }

        //Generate Management ID
        public static string generateManagementId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            int initiator = 545454;
            int counter, countOfTotalUser = 0;

            string userID = "";

            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(UserId) FROM patientinfo WHERE Role=Management";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID = "MNT-" + date + "-" + counter;


            return userID;

        }

        //Generate AdiminId

        public static string generateAdminId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            int initiator = 545454;
            int counter, countOfTotalUser = 0;

            string userID = "";

            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(UserID) FROM patientinfo WHERE Role=Admin";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID = "ADM-" + date + "-" + counter;


            return userID;

        }

        //generate Accountant ID

        public static string generateAccountantId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            int initiator = 545454;
            int counter, countOfTotalUser = 0;

            string userID = "";

            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(UserID) FROM patientinfo WHERE Role=Accountant";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID = "ACC-" + date + "-" + counter;


            return userID;

        }

        //Generate Security ID
        public static string generateSecurityId()
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);

            int initiator = 545454;
            int counter, countOfTotalUser = 0;

            string userID = "";

            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(UserID) FROM patientinfo WHERE Role=Accountant";
                //SQL Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                object returnValue = cmd.ExecuteScalar();
                if (returnValue != null)
                {
                    countOfTotalUser = Convert.ToInt32(returnValue);
                }
                else
                {
                    MessageBox.Show("Error Occured! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            counter = initiator + countOfTotalUser;
            DateTime d = DateTime.Now;
            int date = (d.Year) % 100;
            userID = "SEC-" + date + "-" + counter;


            return userID;

        }


        public static int generateVerificationCode()
        {
            Random r = new Random();
            int number = r.Next(1000, 9999);
            return number;
        }

        //get todays registration date
        public static string getRegistrationDate()
        {
            DateTime dt = DateTime.Now;
            string date = dt.Year + "-" + dt.Month + "-" + dt.Day;
            return date.ToString();
        }

    }
}
