using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library1._1.PAL.Forms
{
    public partial class FormMain : Form
    {
        public string Username, Role;

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if (Role == "ADMIN")
            {
                buttonDashboard.Hide();
                userControlDashboard1.Visible = false;
            }

            buttonBooks.Hide();
            buttonBooks2.Hide();
            buttonBooks3.Hide();
            buttonClass.Hide();
        }
        //
        //log out
        //
        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                FormLogin loginForm = new FormLogin();
                loginForm.Show();
                this.Close();
            }
        }
        //
        //date n time
        //
        private void TimerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }
        //
        //side panel
        //
        private void MoveSidePanel(Control button)
        {
            panelSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y);
        }

        //
        //buttons
        //

        //dashboard
        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlAddStudent1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }

        //student
        private void ButtonStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonStudent);
            //userControlAddStudent1.ClearTextBox();
            userControlAddStudent1.Visible = true;
            userControlDashboard1.Visible = false;
        }
    }
}
