using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Library1._1.PAL.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private MySqlConnection connection;

        public UserControlDashboard()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Database=library;User=root;Password=root;";
            connection = new MySqlConnection(connectionString);
        }

        // count classes
        private int CountDistinctClasses()
        {
            int classCount = 0;
            connection.Open();
            string query = "SELECT COUNT(DISTINCT class) FROM student";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                classCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            connection.Close();
            return classCount;
        }
        // count students
        private int CountDistinctStudents()
        {
            int classCount = 0;
            connection.Open();
            string query = "SELECT COUNT(DISTINCT REG_NUM) FROM student";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                classCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            connection.Close();
            return classCount;
        }
        // count books
        private int CountDistinctBooks()
        {
            int classCount = 0;
            connection.Open();
            string query = "SELECT COUNT(DISTINCT ID) FROM book";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                classCount = Convert.ToInt32(cmd.ExecuteScalar());
            }
            connection.Close();
            return classCount;
        }

        //show
        public void Count()
        {
            labelTotalClasses.Text = CountDistinctClasses().ToString();
            labelTotalStudents.Text = CountDistinctStudents().ToString();
            labelTotalBooks.Text = CountDistinctBooks().ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
