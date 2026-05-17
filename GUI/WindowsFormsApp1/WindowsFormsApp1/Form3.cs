using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=KK; integrated security=SSPI";
        int id;
        public Form3(int i)
        {
            id = i;
            InitializeComponent();
            string query = "SELECT * FROM Section";
            FillDataGridView(query);
        }


        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT * FROM Section 
                     WHERE Id LIKE @searchTerm 
                        OR Name LIKE @searchTerm 
                        OR CAST(Age AS NVARCHAR) LIKE @searchTerm 
                        OR Address LIKE @searchTerm";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchValue + "%");

                    /* SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter acts as a bridge between a DataSet (or DataTable) and the SQL database.
                 DataTable dataTable = new DataTable();  //Instantiates a new, empty DataTable object to store the retrieved data
                 adapter.Fill(dataTable);  // Executes the SQL command and fills the dataTable with the result set returned from the database
                    dataGridView1.DataSource = dataTable;
*/
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching rows found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(id);
            f4.Show();
        }
    }
}
