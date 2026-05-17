using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        private string connectionString =
            "data source=AZURE\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void LoadAllUsers()
        {
            string query = "SELECT UserId, AiubId, Name, Gender, " +
                           "Department, Semester, ReputationScore " +
                           "FROM [User] " +
                           "WHERE Role='Student'";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            string searchText =
                searchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadAllUsers();
                return;
            }

            string query = "SELECT UserId, AiubId, Name, Gender, " +
                           "Department, Semester, ReputationScore " +
                           "FROM [User] " +
                           "WHERE Role='Student' " +
                           "AND (Name LIKE @Search " +
                           "OR AiubId LIKE @Search)";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection);

                    adapter.SelectCommand.Parameters.AddWithValue(
                        "@Search",
                        "%" + searchText + "%"
                    );

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No users found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adNewButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registration registration =
                new Registration();

            registration.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int userId =
                Convert.ToInt32(
                    dataGridView1.SelectedRows[0]
                    .Cells["UserId"].Value
                );

            this.Hide();

            Update updateForm =
                new Update(userId);

            updateForm.Show();
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete!", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int userId =
                Convert.ToInt32(
                    dataGridView1.SelectedRows[0]
                    .Cells["UserId"].Value
                );

            string userName =
                dataGridView1.SelectedRows[0]
                .Cells["Name"].Value.ToString();

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete " + userName + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction =
                        connection.BeginTransaction();

                    try
                    {
                        string deleteSwipeQuery =
                            "DELETE FROM Swipe " +
                            "WHERE SwiperId=@UserId " +
                            "OR SwipedId=@UserId";

                        SqlCommand swipeCommand =
                            new SqlCommand(
                                deleteSwipeQuery,
                                connection,
                                transaction
                            );

                        swipeCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        swipeCommand.ExecuteNonQuery();

                        string deleteMatchQuery =
                            "DELETE FROM Match " +
                            "WHERE User1Id=@UserId " +
                            "OR User2Id=@UserId";

                        SqlCommand matchCommand =
                            new SqlCommand(
                                deleteMatchQuery,
                                connection,
                                transaction
                            );

                        matchCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        matchCommand.ExecuteNonQuery();

                        string deleteGroupMemberQuery =
                            "DELETE FROM GroupMember " +
                            "WHERE UserId=@UserId";

                        SqlCommand gmCommand =
                            new SqlCommand(
                                deleteGroupMemberQuery,
                                connection,
                                transaction
                            );

                        gmCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        gmCommand.ExecuteNonQuery();

                        string deleteRatingQuery =
                            "DELETE FROM Rating " +
                            "WHERE GroupId IN " +
                            "(SELECT GroupId FROM ProjectGroup WHERE CreatorId=@UserId) " +
                            "OR RaterId=@UserId " +
                            "OR RateeId=@UserId";

                        SqlCommand ratingCommand =
                            new SqlCommand(
                                deleteRatingQuery,
                                connection,
                                transaction
                            );

                        ratingCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        ratingCommand.ExecuteNonQuery();

                        string deleteProjectQuery =
                            "DELETE FROM ProjectGroup " +
                            "WHERE CreatorId=@UserId";

                        SqlCommand pgCommand =
                            new SqlCommand(
                                deleteProjectQuery,
                                connection,
                                transaction
                            );

                        pgCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        pgCommand.ExecuteNonQuery();

                        string deleteSkillQuery =
                            "DELETE FROM Skill " +
                            "WHERE UserId=@UserId";

                        SqlCommand skillCommand =
                            new SqlCommand(
                                deleteSkillQuery,
                                connection,
                                transaction
                            );

                        skillCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        skillCommand.ExecuteNonQuery();

                        string deleteWorkStyleQuery =
                            "DELETE FROM WorkStyle " +
                            "WHERE UserId=@UserId";

                        SqlCommand wsCommand =
                            new SqlCommand(
                                deleteWorkStyleQuery,
                                connection,
                                transaction
                            );

                        wsCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        wsCommand.ExecuteNonQuery();

                        string deleteUserQuery =
                            "DELETE FROM [User] " +
                            "WHERE UserId=@UserId";

                        SqlCommand userCommand =
                            new SqlCommand(
                                deleteUserQuery,
                                connection,
                                transaction
                            );

                        userCommand.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        int rowsAffected =
                            userCommand.ExecuteNonQuery();

                        transaction.Commit();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadAllUsers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Welcome w1 = new Welcome();

            w1.Show();
        }
    }
}