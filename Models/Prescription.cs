using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTRON_Management_Software.Models
{
    class Prescription
    {
        public string patientID { get; set; }
        public string prescriptionDate { get; set; }
        public string prescriptionTopic { get; set; }
        public string prescriptionText { get; set; }
        public string prescribrdBy { get; set; }


        //connection string
        private static string connectionString = "server=localhost;user id=root; password=laxudb;persistsecurityinfo=True;database=webtronmanagement";
        // private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        //instance variables of the class Patient

        public static DataTable GetPatientPrescriptionHistory(string ID)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM prescription WHERE patientId LIKE '%"+ID+"%'",con);
            if (ad == null)
            {
                return null;
            }
            else
            {
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt;
            }
            //*Note* if we returned object by initializing instances of the object one by one then it becomes a bit 
            //tidious and memory consuming
        }
        
    }
}
