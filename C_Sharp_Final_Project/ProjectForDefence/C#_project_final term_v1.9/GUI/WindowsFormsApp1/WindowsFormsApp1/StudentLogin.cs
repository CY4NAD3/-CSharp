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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class StudentLogin : Form
    {
      
        public static int LoggedInUserId = 0;
        public static string LoggedInAiubId = "";
        public static string LoggedInUserName = "";

        private string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        public StudentLogin()
        {
            InitializeComponent();
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string aiubId = aiubIDTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(aiubId) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string query = "SELECT UserId, Name FROM [User] WHERE AiubId = @AiubId AND PasswordHash = @Password AND Role = 'Student'";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AiubId", aiubId);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        LoggedInUserId = Convert.ToInt32(reader["UserId"]);
                        LoggedInAiubId = aiubId;
                        LoggedInUserName = reader["Name"].ToString();

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        HomeFeed homeFeed = new HomeFeed();
                        homeFeed.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        
        private void registrationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

       
    }
}