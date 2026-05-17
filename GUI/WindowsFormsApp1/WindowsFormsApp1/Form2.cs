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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=KK; integrated security=SSPI";



            string id = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string age = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();



            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(age) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (!int.TryParse(age, out int parsedAge))
            {
                MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string query = "INSERT INTO Section (Id, Name, Age, Address) VALUES (@Id, @Name, @Age, @Address)";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", parsedAge);
                    command.Parameters.AddWithValue("@Address", address);



                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();



                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }
    }
}
