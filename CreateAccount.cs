using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webTRON_Management_Software
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sideBar.Visible)
            {
                sideBarTransition.HideSync(sideBar);
            }
            else
            {
                sideBarTransition.ShowSync(sideBar);
               
            }
        }
    }
}
