using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTRON_Management_Software.Models
{
    class Medicine
    {
        //Properties
        public string Name { get; set; }
        public string StartDate { get; set; }
        public int EndDay { get; set; }
        public string Remarks { get; set; }

        //Methods
        //Method to insert
        public static bool Insert(Medicine obj)
        {
            bool isSucess = false;
            return isSucess;

        }
       
    }
}
