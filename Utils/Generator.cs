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
        private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";

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
        //Methods that generate userID
        public static string generateUserId(string role)
        {
            //SQLConnection
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            int initiator = 121212;
            int counter, countOfTotalUser=0;
           
            string userID = "";
           
            try
            {
                //SQL Query to fetch number of total user
                string SQLQuery = "SELECT COUNT(userID) FROM employeeInfo";
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
           
            if (role == "Doctor")
            userID += $"DIR-{date}-{counter}";
            /* WARNINGS:else if (post == "Patient")
                 userID += "PTC-" + date + "-" + counter;
             */
            else if (role == "Employee")
                userID += $"EMP-{date}-{counter}";
            else if (role == "Administration")
                userID += $"ADM-{date}-{counter}";
            else if (role == "Admin")
                userID += $"ADM-{date}-{counter}";
            //WARNINGS:ADM Duplication
            else if (role == "Accountant")
                userID += $"ACC-{date}-{counter}";
            else if (role == "Others")
                userID += $"OTH-{date}-{counter}";

            return userID;

        }
        //To generate random verification code
        public static int VerificationCode()
        {
            Random rand = new Random();
            int code = rand.Next(1000, 9999);
            return code;
        }

    }
}
