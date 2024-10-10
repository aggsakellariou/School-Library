using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1._1.PAL.Forms
{
    public partial class FormForgotPassword : Form
    {
        /*private string sql = @"Data Source = .\SQLEXPRESS;
                            Initial Catalog = Library1;
                            Integrated Security = True;";*/

        public FormForgotPassword()
        {
            InitializeComponent();
        }
        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //
        //close button
        //
        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }
        //
        // textBoxEmail
        //
        private void TextBoxEmail_Enter(object sender, EventArgs e)
        {
            if(textBoxEmail.Text.Trim() == "email@gamil.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }

            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "email@gamil.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }
        private void TextBoxEmail_Leave(object sender, EventArgs e)
        {
            if(textBoxEmail.Text.Trim() == string.Empty)
            {
                textBoxEmail.Text = "email@gamil.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
            
            if (!IsValidEmail(textBoxEmail.Text.Trim()) || textBoxEmail.Text.Trim() == "email@gamil.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }
        //
        //error icon
        //
        private void PictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError, "Invalid Email");
        }
        //
        //verify button
        //
        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            if(IsValidEmail(textBoxEmail.Text.Trim()))
            {
                //string userName = Attendance.Attendance.GetUsernamePassword("SELECT User_Name FROM User_Table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                //string password = Attendance.Attendance.GetUsernamePassword("SELECT User_Pass FROM User_Table WHERE User_Email = '" + textBoxEmail.Text.Trim() + "';", sql);
                //MessageBox.Show("Your Username is " + userName + " and Password is " + password + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
