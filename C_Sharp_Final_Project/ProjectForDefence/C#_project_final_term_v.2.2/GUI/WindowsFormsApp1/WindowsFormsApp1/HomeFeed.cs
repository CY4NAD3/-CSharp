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
            "data source=AZURE\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

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
            string query =

                "SELECT " +
                "u.UserId, " +
                "u.Name, " +
                "u.Department, " +
                "u.Semester, " +
                "u.ReputationScore, " +

                "STUFF(( " +
                "SELECT ', ' + SkillName " +
                "FROM Skill s " +
                "WHERE s.UserId = u.UserId " +
                "FOR XML PATH('') " +
                "), 1, 2, '') AS Skills, " +

                "STUFF(( " +
                "SELECT ', ' + StyleName " +
                "FROM WorkStyle w " +
                "WHERE w.UserId = u.UserId " +
                "FOR XML PATH('') " +
                "), 1, 2, '') AS WorkStyles " +

                "FROM [User] u " +

                "WHERE u.Role = 'Student' " +
                "AND u.UserId != @CurrentUserId " +

                "AND u.UserId NOT IN ( " +
                "SELECT SwipedId " +
                "FROM Swipe " +
                "WHERE SwiperId = @CurrentUserId " +
                ")";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@CurrentUserId",
                        StudentLogin.LoggedInUserId
                    );

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
            if (candidatesTable == null ||
                currentIndex >= candidatesTable.Rows.Count)
            {
                nameLabel.Text = "No More Candidates";
                departmentLabel.Text = "";
                semesterLabel.Text = "";
                skillsLabel.Text = "";
                workStyleLabel.Text = "";
                reputationLabel.Text = "";

                connectButton.Enabled = false;
                passButton.Enabled = false;

                return;
            }

            DataRow row = candidatesTable.Rows[currentIndex];

            nameLabel.Text =
                "Name: " + row["Name"].ToString();

            departmentLabel.Text =
                "Department: " + row["Department"].ToString();

            semesterLabel.Text =
                "Semester: " + row["Semester"].ToString();

            skillsLabel.Text =
                "Skills: " +
                (row["Skills"] == DBNull.Value
                ? "N/A"
                : row["Skills"].ToString());

            workStyleLabel.Text =
                "Work Style: " +
                (row["WorkStyles"] == DBNull.Value
                ? "N/A"
                : row["WorkStyles"].ToString());

            reputationLabel.Text =
                "Reputation: " +
                row["ReputationScore"].ToString();
        }

        private void SaveSwipe(
            int swiperId,
            int swipedId,
            bool isInterested)
        {
            string query =

                "INSERT INTO Swipe " +
                "(SwiperId, SwipedId, IsInterested) " +
                "VALUES " +
                "(@a, @b, @c)";

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, con);

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
            string query =

                "SELECT COUNT(*) " +
                "FROM Swipe " +
                "WHERE SwiperId = @u2 " +
                "AND SwipedId = @u1 " +
                "AND IsInterested = 1";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@u1", user1);
                cmd.Parameters.AddWithValue("@u2", user2);

                con.Open();

                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void CreateMatch(int user1, int user2)
        {
            string checkQuery =

                "SELECT COUNT(*) " +
                "FROM [Match] " +
                "WHERE " +
                "(User1Id = @u1 AND User2Id = @u2) " +
                "OR " +
                "(User1Id = @u2 AND User2Id = @u1)";

            string insertQuery =

                "INSERT INTO [Match] " +
                "(User1Id, User2Id) " +
                "VALUES " +
                "(@u1, @u2)";

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand checkCmd =
                        new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@u1", user1);
                        checkCmd.Parameters.AddWithValue("@u2", user2);

                        int count =
                            (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                            return;
                    }

                    using (SqlCommand insertCmd =
                        new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@u1", user1);
                        insertCmd.Parameters.AddWithValue("@u2", user2);

                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Match Error: " + ex.Message);
            }
        }

        private void connectButton_Click_1(object sender, EventArgs e)
        {
            if (candidatesTable == null ||
                currentIndex >= candidatesTable.Rows.Count)
                return;

            int swipedUserId =
                Convert.ToInt32(
                    candidatesTable.Rows[currentIndex]["UserId"]);

            SaveSwipe(
                StudentLogin.LoggedInUserId,
                swipedUserId,
                true
            );

            if (CheckMutualMatch(
                StudentLogin.LoggedInUserId,
                swipedUserId))
            {
                CreateMatch(
                    StudentLogin.LoggedInUserId,
                    swipedUserId
                );

                MessageBox.Show("It's a Match!");
            }

            currentIndex++;

            ShowCurrentCandidate();
        }

        private void passButton_Click_1(object sender, EventArgs e)
        {
            if (candidatesTable == null ||
                currentIndex >= candidatesTable.Rows.Count)
                return;

            int swipedUserId =
                Convert.ToInt32(
                    candidatesTable.Rows[currentIndex]["UserId"]);

            SaveSwipe(
                StudentLogin.LoggedInUserId,
                swipedUserId,
                false
            );

            currentIndex++;

            ShowCurrentCandidate();
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