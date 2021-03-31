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
    public partial class ForgetPassword : Form
    {

        public ForgetPassword()
        {
            InitializeComponent();
        }
        
        //for draggable windows form
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
       
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
         
            //...........Start animation on load.........
            // Guna.UI2.WinForms.Guna2AnimateWindow.Start();
            //guna2AnimateWindow1.Start();
        }

        //Click event on close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Click event on minimize button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Click event on send verification code
        private void btnSendVerificationCode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(recoveryEmailTextBox.Text))
            {
                MessageBox.Show("Fill the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                verificationPanelTransition.ShowSync(sendVerificationCodePanel);
            }

            

        }
        //Click event on verify button click
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (resetPasswordPanel.Visible)
            {
                resetPasswordPanelTransition.HideSync(resetPasswordPanel);
            }
            else
            {
                resetPasswordPanelTransition.ShowSync(resetPasswordPanel);
            }

        }
    }
}
