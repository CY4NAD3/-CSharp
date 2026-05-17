using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChangePassword : Form
    {
        private string connectionString =
            "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile p1 = new Profile();
            p1.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPassTextBox.Text.Trim();
            string newPassword = newPassTextBox.Text.Trim();
            string confirmPassword = confirmPassTextBox.Text.Trim();

            
            if (oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM [User]
                        WHERE UserId = @UserId
                        AND PasswordHash = @OldPassword";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@UserId", StudentLogin.LoggedInUserId);
                        checkCmd.Parameters.AddWithValue("@OldPassword", oldPassword);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Old password is incorrect!");
                            return;
                        }
                    }

                    
                    string updateQuery = @"
                        UPDATE [User]
                        SET PasswordHash = @NewPassword
                        WHERE UserId = @UserId";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@UserId", StudentLogin.LoggedInUserId);

                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password changed successfully!");

                    
                    oldPassTextBox.Clear();
                    newPassTextBox.Clear();
                    confirmPassTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}