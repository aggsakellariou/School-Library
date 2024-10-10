using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using MySql.Data.MySqlClient;


namespace Library1._1.PAL.Forms 
{
    public partial class FormLogin : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; Database=library; User=root; Password=root;");

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();
            labelFP.Hide();
        }

        //
        //show icon
        //
        private void PictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }
        private void PictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        //
        //hide icon
        //
        private void PictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
        }
        private void PictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        //
        //Login
        //
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string check = IsValidNamePass(textBoxName.Text.Trim(), textBoxPassword.Text.Trim());
            if (!string.IsNullOrEmpty(textBoxName.Text.Trim()) && !string.IsNullOrEmpty(textBoxPassword.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(check))
                {
                    FormMain formMain = new FormMain
                    {
                        Username = textBoxName.Text,
                        Role = check
                    };
                    textBoxName.Clear();
                    textBoxPassword.Clear();
                    PictureBoxHide_Click(sender, e);
                    textBoxName.Focus();
                    pictureBoxError.Hide();
                    labelError.Hide();
                    formMain.ShowDialog();
                    this.Hide();
                }
                else
                {
                    pictureBoxError.Show();
                    labelError.Show();
                }
            }
        }

        //
        //Database
        //
        public static string Role = "";
        private string IsValidNamePass(string username, string password)
        {
            string role = "";
            try
            {
                string cmdText = "SELECT USERNAME, PASSWORD, ROLE FROM user WHERE USERNAME = @Username AND PASSWORD = @Password";
                using (MySqlConnection localConnection = new MySqlConnection(connection.ConnectionString))
                {
                    localConnection.Open();
                    MySqlCommand selectCommand = new MySqlCommand(cmdText, localConnection);
                    selectCommand.Parameters.AddWithValue("@Username", username);
                    selectCommand.Parameters.AddWithValue("@Password", password);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        role = dataTable.Rows[0]["ROLE"].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return role;
        }

        //
        //username
        //
        private void TextBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        //
        //password
        //
        private void TextBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }
        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }

        //
        //forgot password
        //
        private void LabelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }
    }
}
