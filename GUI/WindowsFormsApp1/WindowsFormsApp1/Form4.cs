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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int id;
        string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=KK; integrated security=SSPI";

        public Form4(int i)
        {
            id = i;
            InitializeComponent();
            LoadDetails();
        }

        private void LoadDetails()
        {
            string query = "SELECT Id, Name, Age, Address FROM Section WHERE Id = @Id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate the text boxes with the retrieved data
                        textBox1.Text = reader["Id"].ToString();
                        textBox2.Text = reader["Name"].ToString();
                        textBox3.Text = reader["Age"].ToString();
                        textBox4.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newName = textBox2.Text.Trim();
            string newAge = textBox3.Text.Trim();
            string newAddress = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newAge) || string.IsNullOrWhiteSpace(newAddress))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Section SET Name = @Name, Age = @Age, Address = @Address WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", newName);
                    command.Parameters.AddWithValue("@Age", newAge);
                    command.Parameters.AddWithValue("@Address", newAddress);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No record was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this profile?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );



            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM section WHERE Id = @Id";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);



                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();



                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No profile was found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
     "Are you sure you want to exit the application?",
     "Confirm Exit",
     MessageBoxButtons.YesNo,
     MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
