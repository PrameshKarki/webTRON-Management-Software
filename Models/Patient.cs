using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace webTRON_Management_Software.Models
{
    class Patient
    {
        //connection string
        private static string connectionString = "server=localhost;user id=root; password=laxudb;persistsecurityinfo=True;database=webtronmanagement";

        //instance variables of the class Patient
        public string Registration_Number { get; set; }
        public string Registration_Date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ReferredTo { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string ContactNumber { get; set; }
        public string Status { get; set; }


        // method to insert the datas to the database 
        public static bool Insert(Patient ptn)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "insert into patientinfo values(@prmRegistrationNumber,@prmRegiatratioDate,@prmFirstName, @prmLastName, @prmContact,@prmSex,@prmReferredTo,@prmStatus,@prmAge,@prmAddress)";
            command.Parameters.AddWithValue("prmRegistrationNumber", ptn.Registration_Number);
            command.Parameters.AddWithValue("prmRegiatratioDate", ptn.Registration_Date);
            command.Parameters.AddWithValue("prmFirstName", ptn.FirstName);
            command.Parameters.AddWithValue("prmLastName", ptn.LastName);
            command.Parameters.AddWithValue("prmContact", ptn.ContactNumber);
            command.Parameters.AddWithValue("prmSex", ptn.Sex);
            command.Parameters.AddWithValue("prmReferredTo", ptn.ReferredTo);
            command.Parameters.AddWithValue("prmStatus", ptn.Status);
            command.Parameters.AddWithValue("prmAge", ptn.Age);
            command.Parameters.AddWithValue("prmAddress", ptn.Address);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }



        public static bool Update(Patient ObjUpdate)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
            MessageBox.Show("Inside Update...");
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "update patientinfo set Patient_First_Name=@prmFirstName, Patient_Last_Name=@prmLastName, Contact= @prmContact,Age=@prmAge,Address=@prmAddress WHERE Registration_Number=@parmRegistrationNumber";
            command.Parameters.AddWithValue("prmFirstName", ObjUpdate.FirstName);
            MessageBox.Show(ObjUpdate.FirstName);
            command.Parameters.AddWithValue("prmLastName", ObjUpdate.LastName);
            MessageBox.Show(ObjUpdate.LastName);
            command.Parameters.AddWithValue("parmRegistrationNumber", ObjUpdate.Registration_Number);
            MessageBox.Show(ObjUpdate.Registration_Number);
            command.Parameters.AddWithValue("prmContact", ObjUpdate.ContactNumber);
            MessageBox.Show(ObjUpdate.ContactNumber);
            command.Parameters.AddWithValue("prmAge", ObjUpdate.Age);
            MessageBox.Show(ObjUpdate.Age);
            command.Parameters.AddWithValue("prmAddress", ObjUpdate.Address);
            MessageBox.Show(ObjUpdate.Address);
          
                command.ExecuteNonQuery();
                MessageBox.Show("Inside TRY...");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+"Inside CATCH...");
                return false;
               

            }
            finally
            {
                MessageBox.Show("Inside Finally...");
                conn.Close();
            }
            return true;
        }








    }
}
