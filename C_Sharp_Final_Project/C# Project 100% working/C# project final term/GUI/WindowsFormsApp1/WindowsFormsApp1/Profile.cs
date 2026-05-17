using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Profile : Form
    {
        private string connectionString =
            "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        public Profile()
        {
            InitializeComponent();
            this.Load += Profile_Load;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            
            string query = @"
                SELECT 
                    u.Name,
                    u.ReputationScore
                FROM [User] u
                WHERE u.UserId = @UserId";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserId", StudentLogin.LoggedInUserId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        nameLabel.Text = "Name: " + dr["Name"].ToString();

                        
                        int reputationScore = dr["ReputationScore"] != DBNull.Value
                            ? Convert.ToInt32(dr["ReputationScore"])
                            : 0;

                        reputationLabel.Text = "Reputation:  " + reputationScore;
                    }
                    else
                    {
                        MessageBox.Show("User not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeFeed().Show();
        }

        private void changeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword().Show();
        }
    }
}