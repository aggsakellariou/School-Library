using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library1._1.PAL.User_Control
{
    public partial class UserControlStudent : UserControl
    {
        private MySqlConnection connection;
        private DataTable dataTableLoan;
        private DataTable dataTableReturn;

        public UserControlStudent()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeComboBoxLoan();
            InitializeComboBoxReturn();
            InitializeDataGridViewLoan();
            InitializeDataGridViewReturn();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Database=library;User=root;Password=root;";
            connection = new MySqlConnection(connectionString);
        }
        private void InitializeDataGridViewLoan()
        {
            dataTableLoan = new DataTable();

            dataGridViewLoan.DataSource = dataTableLoan;
            dataGridViewLoan.Columns["Column1L"].Visible = false;
            dataGridViewLoan.Columns["Column2L"].Visible = false;
            LoanButtonColumn.Text = "Loan";
            LoanButtonColumn.UseColumnTextForButtonValue = true;
            Column6L.DefaultCellStyle.NullValue = DateTime.Now.ToString("yyyy-MM-dd");


            RefreshDataGridViewLoan();
        }
        private void InitializeDataGridViewReturn()
        {
            dataTableReturn = new DataTable();

            dataGridViewReturn.DataSource = dataTableReturn;
            dataGridViewReturn.Columns["ColumnREG_NUM"].Visible = false;
            dataGridViewReturn.Columns["ColumnCLASS"].Visible = false;
            dataGridViewReturn.Columns["ColumnID"].Visible = false;
            returnButtonColumn.Text = "Return";
            returnButtonColumn.UseColumnTextForButtonValue = true;

            RefreshDataGridViewReturn();
        }
        private void TabControlAddStudent_Leave(object sender, EventArgs e)
        {
            tabControlAddStudent.SelectedTab = tabPageLoan;
        }


        //
        //tab loan
        //
        private void PictureBoxLoan_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxLoan, "Search");
        }

        // comboBox
        private void InitializeComboBoxLoan()
        {
            connection.Open();

            string query = "SELECT DISTINCT class FROM student ORDER BY class ASC";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxLoan.Items.Add(reader["class"].ToString());
                    }
                }
            }
            connection.Close();
        }
        private void RefreshDataGridViewLoan()
        {
            connection.Open();
            string query = "SELECT REG_NUM, CLASS, LNAME, FNAME, DATE_FORMAT(NOW(), '%d/%m/%y') AS LOAN_DATE " +
                   "FROM student " +
                   "WHERE CLASS = @class";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@class", comboBoxLoan.Text);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    dataTableLoan.Clear();
                    adapter.Fill(dataTableLoan);
                }
            }
            connection.Close();
            labelLoan.Text = dataGridViewLoan.Rows.Count.ToString();
        }
        private void ComboBoxLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridViewLoan();
        }

        //insert
        private void DataGridViewLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewLoan.Columns["LoanButtonColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dataGridViewLoan.Rows[e.RowIndex];

                string STUDENT_REG_NUM = clickedRow.Cells["Column1L"].Value.ToString();
                string BOOK_ID = clickedRow.Cells["Column5L"].Value.ToString();

                string loanDateCellValue = clickedRow.Cells["Column6L"].Value != null
                     ? clickedRow.Cells["Column6L"].Value.ToString()
                     : DateTime.Now.ToString("yyyy-MM-dd");
                string LOAN_DATE;

                if (string.IsNullOrEmpty(loanDateCellValue))
                {
                    LOAN_DATE = DateTime.Now.ToString("yyyy-MM-dd");
                }
                else
                {
                    LOAN_DATE = loanDateCellValue;
                }

                MessageBox.Show("Data from the clicked row:\n" + STUDENT_REG_NUM + ", " + BOOK_ID + ", " + LOAN_DATE);
                bool success = InsertData(STUDENT_REG_NUM, BOOK_ID, LOAN_DATE);
                if (success)
                {
                    MessageBox.Show("Data inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert data.");
                }
            }
        }
        public bool InsertData(string studentRegNum, string bookId, string loanDate)
        {
            string connectionString = "Server=localhost;Database=library;User=root;Password=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO movements (STUDENT_REG_NUM, BOOK_ID, LOAN_DATE) VALUES (@studentRegNum, @bookId, @loanDate)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@studentRegNum", studentRegNum);
                        cmd.Parameters.AddWithValue("@bookId", bookId);
                        cmd.Parameters.AddWithValue("@loanDate", loanDate);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


        //
        //tab return
        //
        private void PictureBoxReturn_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxReturn, "Search");
        }
        // search combobox
        private void InitializeComboBoxReturn()
        {
            connection.Open();

            string query = "SELECT DISTINCT class FROM student ORDER BY class ASC";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxReturn.Items.Add(reader["class"].ToString());
                    }
                }
            }
            connection.Close();
        }
        private void RefreshDataGridViewReturn()
        {
            connection.Open();
            string query = "SELECT s.LNAME, s.FNAME, m.ID, m.BOOK_ID, m.LOAN_DATE, DATE_FORMAT(IFNULL(m.RET_DATE, NOW()), '%d/%m/%y') AS RET_DATE " +
                           "FROM student s " +
                           "INNER JOIN movements m ON s.REG_NUM = m.STUDENT_REG_NUM " +
                           "WHERE s.CLASS = @class AND m.RET_DATE IS NULL";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@class", comboBoxReturn.Text);

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    dataTableReturn.Clear();
                    adapter.Fill(dataTableReturn);
                }
            }
            connection.Close();
            labelReturn.Text = dataGridViewReturn.Rows.Count.ToString();
        }
        private void ComboBoxReturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridViewReturn();
        }

        //Update
        private void DataGridViewReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewReturn.Columns["returnButtonColumn"].Index && e.RowIndex >= 0)
            {
                int id = (int)dataGridViewReturn.Rows[e.RowIndex].Cells["ColumnID"].Value;

                object editedDateValue = dataGridViewReturn.Rows[e.RowIndex].Cells["ColumnRET_DATE"].Value;

                if (editedDateValue != null)
                {
                    string editedDate = editedDateValue.ToString();
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                    if (DateTime.TryParse(editedDate, out DateTime parsedDate))
                    {
                        string returnDate = parsedDate.ToString("yyyy-MM-dd");
                        bool success = UpdateDatabase(id, returnDate);

                        if (success)
                        {
                            MessageBox.Show("Return successful!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to return the book.");
                        }
                    }
                    else
                    {
                        bool success2 = UpdateDatabase(id, currentDate);

                        if (success2)
                        {
                            MessageBox.Show("Return successful!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to return the book.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a return date.");
                }
            }
        }
        private bool UpdateDatabase(int id, string returnDate)
        {
            connection.Open();

            string query = "UPDATE movements SET RET_DATE = @returnDate WHERE ID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);

                int rowsAffected = cmd.ExecuteNonQuery();

                connection.Close();

                return rowsAffected > 0; 
            }
        }
    }
}
