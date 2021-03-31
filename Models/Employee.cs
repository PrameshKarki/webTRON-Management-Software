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

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connection
                conn.Close();
            }
            return isSucess;
           
        }

    }
}
