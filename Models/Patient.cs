using System;
using System.Collections.Generic;
using System.Data;
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
        //private static string connectionString = "server=localhost;user id=root; password=laxudb;persistsecurityinfo=True;database=webtronmanagement";
        private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        //instance variables of the class Patient
        public string patientID { get; set; }
        public string registrationDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string referredTo { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string contactNumber { get; set; }
        public string status { get; set; }


        // method to insert the datas to the database 
        public static bool Insert(Patient ptn)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO patientInfo (@prmPatientID,@prmRegiatratioDate,@prmFirstName, @prmLastName,@prmGender,@prmAge, @prmContactNumber,@prmAddress,@prmStatus,@prmReferredTo)";
            command.Parameters.AddWithValue("prmRegistrationNumber", ptn.patientID);
            command.Parameters.AddWithValue("prmRegiatratioDate", ptn.registrationDate);
            command.Parameters.AddWithValue("prmFirstName", ptn.firstName);
            command.Parameters.AddWithValue("prmLastName", ptn.lastName);
            command.Parameters.AddWithValue("prmContactNumber", ptn.contactNumber);
            command.Parameters.AddWithValue("prmGender", ptn.gender);
            command.Parameters.AddWithValue("prmReferredTo", ptn.referredTo);
            command.Parameters.AddWithValue("prmStatus", ptn.status);
            command.Parameters.AddWithValue("prmAge", ptn.age);
            command.Parameters.AddWithValue("prmAddress", ptn.address);

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

                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE patientInfo SET firstName=@prmFirstName,lastName=@prmLastName, contact= @prmContact,age=@prmAge,address=@prmAddress WHERE registrationNumber=@parmRegistrationNumber";
                command.Parameters.AddWithValue("prmFirstName", ObjUpdate.firstName);
                command.Parameters.AddWithValue("prmLastName", ObjUpdate.lastName);
                command.Parameters.AddWithValue("parmRegistrationNumber", ObjUpdate.patientID);
                command.Parameters.AddWithValue("prmContact", ObjUpdate.contactNumber);
                command.Parameters.AddWithValue("prmAge", ObjUpdate.age);
                command.Parameters.AddWithValue("prmAddress", ObjUpdate.address);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }


        public static DataTable GetTableData()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM patientInfo", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);  // inserts the data table returned from MySqlDataAdapter  sda to the DataTable dt;
            return dt;

        }





        public static DataTable SearchFromTable(Patient obj)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter(@"SELECT * FROM patientinfo WHERE ( registrationNumber LIKE '%" + obj.patientID +
               "%') OR (registrationDate like '%" + obj.registrationDate +
               "%') OR (firstName like '%" + obj.firstName +
               "%') OR (lastName like '%" + obj.lastName +
               "%') OR (contact like '%" + obj.contactNumber +
               "%') OR (sex like '%" + obj.gender +
               "%') OR (referredTo like '%" + obj.referredTo +
               "%') OR (status like '%" + obj.status +
               "%') OR (age like '%" + obj.age +
               "%') OR (address like '%" + obj.address +
               "%')", conn);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static DataTable SeachAndGetTopRowFromTable(Patient obj)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter(@"SELECT * from patientinfo WHERE registrationNumber LIKE '%" + obj.patientID + "%' LIMIT 1", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static bool Renew(String regNumber)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                MySqlCommand command = new MySqlCommand();

                command.Connection = conn;
                command.CommandText = "UPDATE patientinfo SET status=@prmStatus WHERE registrationNumber=@prmRegistrationNumber";
                command.Parameters.AddWithValue("prmRegistrationNumber", regNumber);
                command.Parameters.AddWithValue("prmStatus", "in");
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;

        }
    }

}
