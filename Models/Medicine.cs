using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software.Models
{
    class Medicine
    {
        //Connection String
       // private static string connectionString = "server=localhost;user id=root;pwd=password;database=webtronmanagement";
        private static string connectionString = "server=localhost;user id=root;pwd=laxudb;database=webtronmanagement";

        //Properties
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int EndDay { get; set; }
        public string Remarks { get; set; }


        //Methods

        //Method to insert
        public static bool Insert(string patientID,List<Medicine> medicineList)
        {
            //Create default variable and set it false
            bool isSucess = false;

            string remarks;

            //MySQL Connection
            MySqlConnection conn = new MySqlConnection(connectionString);

            //SQL Query
            string SQLQuery = "INSERT INTO medicine VALUES";
            
            //Iterate through list
            for(int index = 0; index < medicineList.Count; index++)
            {
                remarks = medicineList[index].Remarks == "" ? "NULL":medicineList[index].Remarks;
                SQLQuery += $"('{patientID}','{medicineList[index].Name}','{medicineList[index].StartDate.ToString("yyyy-MM-dd")}','{medicineList[index].StartDate.AddDays(medicineList[index].EndDay).ToString("yyyy-MM-dd")}','DIR-21-434344','{remarks}'),";
            }
            //Remove  ',' from at the end of sql query
            SQLQuery = SQLQuery.Remove(SQLQuery.Length - 1);
            try
            {
                MessageBox.Show(SQLQuery);
                //MySqlCommand
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Execute Query
                cmd.ExecuteNonQuery();
                isSucess = true;
            }catch(Exception)
            {
                isSucess = false;
            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSucess;

        }
        public static DataTable FetchPreviouslyTakenMedicines(string patientID)
        {
            //Instantiate DataTable
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "SELECT medicineName AS 'Medicine Name',startDate AS 'Start Date',endDate AS 'End Date',DATEDIFF(endDate,startDate) AS Duration,prescribedBy AS 'Prescribed By',remarks as 'Remarks' FROM medicine WHERE patientID= BINARY @patientID AND endDate < Now()";
            try
            {
                //MySqlCommand
                MySqlCommand cmd = new MySqlCommand(SQLQuery,conn);
                //Open Connection
                conn.Open();
                //Add Parameters
                cmd.Parameters.AddWithValue("@patientID", patientID);
                //Load DataTable
                dt.Load(cmd.ExecuteReader());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connectiion
                conn.Close();
            }
            return dt;
        }
        public static DataTable FetchRunningMedicines(string patientID)
        {
            //Instantiate DataTable
            DataTable dt = new DataTable();
            //MySql Connection
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQL Query
            string SQLQuery = "SELECT medicineName AS 'Medicine Name',startDate AS 'Start Date',endDate AS 'End Date',DATEDIFF(endDate,startDate) AS Duration,prescribedBy AS 'Prescribed By',remarks as 'Remarks' FROM medicine WHERE patientID= BINARY @patientID AND endDate >= Now()";
            try
            {
                //MySqlCommand
                MySqlCommand cmd = new MySqlCommand(SQLQuery, conn);
                //Open Connection
                conn.Open();
                //Add Parameters
                cmd.Parameters.AddWithValue("@patientID", patientID);
                //Load DataTable
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Connectiion
                conn.Close();
            }
            return dt;
        }

    }
}
