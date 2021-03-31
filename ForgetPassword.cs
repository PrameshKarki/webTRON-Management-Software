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

        //........ For transparent Labels..............
        void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }
        //................................................................

        public ForgetPassword()
        {
            InitializeComponent();
        }


        //for draggable windows form............
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
        //..........................................





        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            //.........transparent background.........
            TransparetBackground(lblForgotPassword);
            TransparetBackground(lblYouCanReset);
            TransparetBackground(guna2PictureBox4);
            //............-------------------............

            //...........Start animation on load.........
            // Guna.UI2.WinForms.Guna2AnimateWindow.Start();
            //guna2AnimateWindow1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (sendVerificationCodePanel.Visible)
            {
                verificationPanelTransition.HideSync(sendVerificationCodePanel);
            }
            else
            {
                verificationPanelTransition.ShowSync(sendVerificationCodePanel);
            }
        }

        private void TEST2_Click(object sender, EventArgs e)
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
