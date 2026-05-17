using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RateTeamMate : Form
    {
        private string connectionString =
            "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        private int groupId;

        
        public RateTeamMate(int groupId)
        {
            InitializeComponent();
            this.groupId = groupId;
            this.Load += RateTeamMate_Load;
        }

        private void RateTeamMate_Load(object sender, EventArgs e)
        {
            
            if (groupId <= 0)
            {
                MessageBox.Show("Invalid Group!");
                this.Close();
                return;
            }

            LoadTeammates();

            
            ContributionnumericUpDown1.Value = 3;
            CommunicationnumericUpDown2.Value = 3;
            ReliabilitynumericUpDown3.Value = 3;
            PunctualitynumericUpDown4.Value = 3;
        }

        
        private void LoadTeammates()
        {
            string query = @"
                SELECT u.UserId, u.Name
                FROM GroupMember gm
                JOIN [User] u ON u.UserId = gm.UserId
                WHERE gm.GroupId = @GroupId
                AND gm.UserId <> @CurrentUser";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                da.SelectCommand.Parameters.Add("@GroupId", SqlDbType.Int).Value = groupId;
                da.SelectCommand.Parameters.Add("@CurrentUser", SqlDbType.Int).Value = StudentLogin.LoggedInUserId;

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No teammates found in this group!");
                }
            }
        }

        
        private bool AlreadyRated(int rateeId)
        {
            string query = @"
                SELECT COUNT(*) FROM Rating
                WHERE RaterId=@RaterId AND RateeId=@RateeId AND GroupId=@GroupId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@RaterId", StudentLogin.LoggedInUserId);
                cmd.Parameters.AddWithValue("@RateeId", rateeId);
                cmd.Parameters.AddWithValue("@GroupId", groupId);

                con.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        
        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a teammate!");
                return;
            }

            int rateeId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserId"].Value);

            if (AlreadyRated(rateeId))
            {
                MessageBox.Show("Already rated this user!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO Rating
                        (RaterId, RateeId, GroupId, Contribution, Communication, Reliability, Punctuality, Comments)
                        VALUES
                        (@RaterId, @RateeId, @GroupId, @Contribution, @Communication, @Reliability, @Punctuality, @Comments)", con);

                    cmd.Parameters.AddWithValue("@RaterId", StudentLogin.LoggedInUserId);
                    cmd.Parameters.AddWithValue("@RateeId", rateeId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Contribution", (int)ContributionnumericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@Communication", (int)CommunicationnumericUpDown2.Value);
                    cmd.Parameters.AddWithValue("@Reliability", (int)ReliabilitynumericUpDown3.Value);
                    cmd.Parameters.AddWithValue("@Punctuality", (int)PunctualitynumericUpDown4.Value);
                    cmd.Parameters.AddWithValue("@Comments", "");

                    cmd.ExecuteNonQuery();

                    
                    SqlCommand rep = new SqlCommand(@"
                        UPDATE [User]
                        SET ReputationScore = CAST(
                            ISNULL((
                                SELECT AVG(
                                    CAST((Contribution + Communication + Reliability + Punctuality) AS FLOAT) / 4.0
                                )
                                FROM Rating
                                WHERE RateeId = @RateeId
                            ), 0) AS INT)
                        WHERE UserId = @RateeId", con);

                    rep.Parameters.AddWithValue("@RateeId", rateeId);
                    rep.ExecuteNonQuery();

                    MessageBox.Show("Rating Submitted Successfully!");

                    this.Hide();
                    new Group().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Group().Show();
        }
    }
}