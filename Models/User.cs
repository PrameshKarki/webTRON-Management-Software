using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace webTRON_Management_Software.Models
{
    class User
    {
        //Connection String
        private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        //Properties
        public string userID { get; set; }
        public string password { get; set; }

        //Methods
        public bool Insert(User obj)
        {
            //Declaring a default bool variable and initializing false
            bool isSucess = false;
            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                //String SqlQuery
                string SQLQuery ="INSERT INTO Users(userID,password) VALUES(@userID,AES_ENCRYPT(@password,'webTRON'))";
                //MySql Command
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                cmd.Parameters.AddWithValue("@userID", obj.userID);
                cmd.Parameters.AddWithValue("@password", obj.password);
                //Connection Open
                conn.Open();
                //Execute Query
                //Here ExecuteNonQuery() returns the number of rows affected
                int row = cmd.ExecuteNonQuery();
                isSucess = row > 0 ? true : false;

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
            return isSucess;

        }

    }
}
