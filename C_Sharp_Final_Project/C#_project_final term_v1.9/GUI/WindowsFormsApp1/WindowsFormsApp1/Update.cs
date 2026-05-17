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
    public partial class Update : Form
    {
        private string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";
        private int userId;

        public Update(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");
        }

        private void Update_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        
        private void LoadUserData()
        {
            string query = "SELECT * FROM [User] WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nameTextBox.Text = reader["Name"].ToString();
                        departmentTextBox.Text = reader["Department"].ToString();
                        semesterTextBox.Text = reader["Semester"].ToString();
                        comboBox1.SelectedItem = reader["Gender"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string department = departmentTextBox.Text.Trim();
            string semester = semesterTextBox.Text.Trim();
            string gender = comboBox1.Text;

            string query = @"UPDATE [User] SET 
                            Name = @Name,
                            Gender = @Gender,
                            Department = @Department,
                            Semester = @Semester
                            WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@Semester", semester);
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("User updated successfully!");

                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}