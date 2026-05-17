using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class HomeFeed : Form
    {
        private string connectionString =
            "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        private DataTable candidatesTable;
        private int currentIndex = 0;

        public HomeFeed()
        {
            InitializeComponent();
        }

        private void HomeFeed_Load(object sender, EventArgs e)
        {
            LoadCandidates();
            ShowCurrentCandidate();
        }

        
        private void LoadCandidates()
        {
            string query = @"
                SELECT DISTINCT
                    u.UserId,
                    u.Name,
                    u.Department,
                    u.Semester,
                    u.ReputationScore,
                    s.SkillName,
                    w.StyleName
                FROM [User] u
                LEFT JOIN Skill s ON u.UserId = s.UserId
                LEFT JOIN WorkStyle w ON u.UserId = w.UserId
                WHERE u.Role = 'Student'
                AND u.UserId != @CurrentUserId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@CurrentUserId", StudentLogin.LoggedInUserId);

                    candidatesTable = new DataTable();
                    adapter.Fill(candidatesTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        
        private void ShowCurrentCandidate()
        {
            if (candidatesTable == null || currentIndex >= candidatesTable.Rows.Count)
            {
                nameLabel.Text = "No Candidate";
                departmentLabel.Text = "";
                semesterLabel.Text = "";
                skillsLabel.Text = "";
                workStyleLabel.Text = "";
                reputationLabel.Text = "";
                return;
            }

            DataRow row = candidatesTable.Rows[currentIndex];

            nameLabel.Text = "Name: " + row["Name"];
            departmentLabel.Text = "Department: " + row["Department"];
            semesterLabel.Text = "Semester: " + row["Semester"];

            skillsLabel.Text = "Skill: " +
                (row["SkillName"] == DBNull.Value ? "N/A" : row["SkillName"].ToString());

            workStyleLabel.Text = "Work Style: " +
                (row["StyleName"] == DBNull.Value ? "N/A" : row["StyleName"].ToString());

            reputationLabel.Text = "Reputation:  " + row["ReputationScore"];
        }

        
        private void SwipeUser(bool isInterested)
        {
            if (candidatesTable == null || currentIndex >= candidatesTable.Rows.Count)
                return;

            int swipedUserId = Convert.ToInt32(candidatesTable.Rows[currentIndex]["UserId"]);

            SaveSwipe(StudentLogin.LoggedInUserId, swipedUserId, isInterested);

            currentIndex++;
            ShowCurrentCandidate();
        }

        private void SaveSwipe(int swiperId, int swipedId, bool isInterested)
        {
            string query = "INSERT INTO Swipe (SwiperId, SwipedId, IsInterested) VALUES (@a, @b, @c)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@a", swiperId);
                    cmd.Parameters.AddWithValue("@b", swipedId);
                    cmd.Parameters.AddWithValue("@c", isInterested);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Swipe Error: " + ex.Message);
            }
        }

        private bool CheckMutualMatch(int user1, int user2)
        {
            string query = @"
                SELECT COUNT(*) FROM Swipe
                WHERE SwiperId = @u2 AND SwipedId = @u1 AND IsInterested = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@u1", user1);
                cmd.Parameters.AddWithValue("@u2", user2);

                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void CreateMatch(int user1, int user2)
        {
            string query = "INSERT INTO [Match] (User1Id, User2Id) VALUES (@u1, @u2)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u1", user1);
                    cmd.Parameters.AddWithValue("@u2", user2);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Match Error: " + ex.Message);
            }
        }

        

        private void connectButton_Click_1(object sender, EventArgs e)
        {
            if (candidatesTable == null || currentIndex >= candidatesTable.Rows.Count)
                return;

            int swipedUserId = Convert.ToInt32(candidatesTable.Rows[currentIndex]["UserId"]);

            SaveSwipe(StudentLogin.LoggedInUserId, swipedUserId, true);

            if (CheckMutualMatch(StudentLogin.LoggedInUserId, swipedUserId))
            {
                CreateMatch(StudentLogin.LoggedInUserId, swipedUserId);
                MessageBox.Show("It's a Match!");
            }

            currentIndex++;
            ShowCurrentCandidate();
        }

        private void passButton_Click_1(object sender, EventArgs e)
        {
            SwipeUser(false);
        }

       

        private void chatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chat().Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Group().Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Profile().Show();
        }

        private void chatButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Chat().Show();
        }

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Profile().Show();
        }
    }
}