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
        private static string connectionString = "server=localhost;user id=root; password=laxudb;persistsecurityinfo=True;database=webtronmanagement";
        // private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
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

                conn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = "update patientInfo set firstName=@prmFirstName,lastName=@prmLastName, contact= @prmContact,age=@prmAge,address=@prmAddress WHERE registrationNumber=@parmRegistrationNumber";
                command.Parameters.AddWithValue("prmFirstName", ObjUpdate.FirstName);
                command.Parameters.AddWithValue("prmLastName", ObjUpdate.LastName);
                command.Parameters.AddWithValue("parmRegistrationNumber", ObjUpdate.Registration_Number);
                command.Parameters.AddWithValue("prmContact", ObjUpdate.ContactNumber);
                command.Parameters.AddWithValue("prmAge", ObjUpdate.Age);
                command.Parameters.AddWithValue("prmAddress", ObjUpdate.Address);
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
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from Patientinfo", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);  // inserts the data table returned from MySqlDataAdapter  sda to the DataTable dt;
            return dt;

        }





        public static DataTable SearchFromTable(Patient obj)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
             MySqlDataAdapter ad=new MySqlDataAdapter( @"select * from patientinfo where ( registrationNumber like '%" + obj.Registration_Number +
                "%') or (registrationDate like '%" + obj.Registration_Date +
                "%') or (firstName like '%" + obj.FirstName +
                "%')or (lastName like '%" + obj.LastName +
                "%')or (contact like '%" + obj.ContactNumber +
                "%') or (sex like '%" + obj.Sex+
                "%') or (referredTo like '%" + obj.ReferredTo +
                "%')or (status like '%" + obj.Status +
                "%')or (age like '%" + obj.Age +
                "%')or (address like '%" + obj.Address +
                "%')",conn);
          
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public static DataTable SeachAndGetTopRowFromTable(Patient obj)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter ad = new MySqlDataAdapter(@"select * from patientinfo where ( registrationNumber like '%" + obj.Registration_Number +
               "%') or (registrationDate like '%" + obj.Registration_Date +
               "%') or (firstName like '%" + obj.FirstName +
               "%')or (lastName like '%" + obj.LastName +
               "%')or (contact like '%" + obj.ContactNumber +
               "%') or (sex like '%" + obj.Sex +
               "%') or (referredTo like '%" + obj.ReferredTo +
               "%')or (status like '%" + obj.Status +
               "%')or (age like '%" + obj.Age +
               "%')or (address like '%" + obj.Address +
               "%') limit 1", conn);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static bool Renew(String regNumber) {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MessageBox.Show("--1");
                conn.Open();
                MessageBox.Show("--2");

                MySqlCommand command = new MySqlCommand();
                MessageBox.Show("--3");

                command.Connection = conn;
                MessageBox.Show("--4");

                command.CommandText = "update patientinfo set status=@prmStatus where registrationNumber=@prmRegistrationNumber";
                MessageBox.Show("--5");

                command.Parameters.AddWithValue("prmRegistrationNumber", regNumber);
                command.Parameters.AddWithValue("prmStatus", "in");
                MessageBox.Show("--6");

                command.ExecuteNonQuery();
                MessageBox.Show("--7");

                conn.Close();
                MessageBox.Show("--8");

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
