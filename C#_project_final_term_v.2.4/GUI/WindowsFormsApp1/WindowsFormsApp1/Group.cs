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
    public partial class Group : Form
    {
        private string connectionString =
            "data source=LEGION\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            LoadMatchedUsers();
            LoadMyGroups();
        }

        private void LoadMatchedUsers()
        {
            checkedListBox1.Items.Clear();

            string query = "SELECT DISTINCT u.UserId, u.Name " +
                           "FROM [Match] m " +
                           "INNER JOIN [User] u " +
                           "ON ((m.User1Id = @MyId AND u.UserId = m.User2Id) " +
                           "OR (m.User2Id = @MyId AND u.UserId = m.User1Id))";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@MyId", SqlDbType.Int).Value =
                    StudentLogin.LoggedInUserId;

                con.Open();

                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    checkedListBox1.Items.Add(
                        new ComboItem(
                            r["Name"].ToString(),
                            r["UserId"].ToString()
                        )
                    );
                }
            }
        }

        private void LoadMyGroups()
        {
            listBox1.Items.Clear();

            string query = "SELECT DISTINCT pg.GroupId, pg.ProjectTitle " +
                           "FROM ProjectGroup pg " +
                           "INNER JOIN GroupMember gm " +
                           "ON pg.GroupId = gm.GroupId " +
                           "WHERE gm.UserId = @UserId";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.Add("@UserId", SqlDbType.Int).Value =
                    StudentLogin.LoggedInUserId;

                con.Open();

                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    listBox1.Items.Add(
                        new GroupItem(
                            r["ProjectTitle"].ToString(),
                            r["GroupId"].ToString()
                        )
                    );
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string course = courseTextBox.Text.Trim();
            string title = projectTitleTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(course) ||
                string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select teammates!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction tr = con.BeginTransaction();

                try
                {
                    string insertGroupQuery =
                        "INSERT INTO ProjectGroup (CourseName, ProjectTitle, CreatorId) " +
                        "VALUES (@c, @p, @u); " +
                        "SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd =
                        new SqlCommand(insertGroupQuery, con, tr);

                    cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = course;
                    cmd.Parameters.Add("@p", SqlDbType.VarChar).Value = title;
                    cmd.Parameters.Add("@u", SqlDbType.Int).Value = StudentLogin.LoggedInUserId;

                    int groupId =
                        Convert.ToInt32(cmd.ExecuteScalar());

                    string creatorQuery =
                        "INSERT INTO GroupMember (GroupId, UserId, Role) " +
                        "VALUES (@g, @u, 'Creator')";

                    SqlCommand creator =
                        new SqlCommand(creatorQuery, con, tr);

                    creator.Parameters.Add("@g", SqlDbType.Int).Value = groupId;
                    creator.Parameters.Add("@u", SqlDbType.Int).Value = StudentLogin.LoggedInUserId;

                    creator.ExecuteNonQuery();

                    foreach (ComboItem i in checkedListBox1.CheckedItems)
                    {
                        string memberQuery =
                            "INSERT INTO GroupMember (GroupId, UserId, Role) " +
                            "VALUES (@g, @u, 'Member')";

                        SqlCommand m =
                            new SqlCommand(memberQuery, con, tr);

                        m.Parameters.Add("@g", SqlDbType.Int).Value = groupId;
                        m.Parameters.Add("@u", SqlDbType.Int).Value = Convert.ToInt32(i.Value);

                        m.ExecuteNonQuery();
                    }

                    tr.Commit();

                    MessageBox.Show("Group Created!");

                    courseTextBox.Clear();
                    projectTitleTextBox.Clear();

                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }

                    LoadMyGroups();
                }
                catch (Exception ex)
                {
                    tr.Rollback();

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a group first!");
                return;
            }

            GroupItem g =
                (GroupItem)listBox1.SelectedItem;

            int groupId =
                Convert.ToInt32(g.Value);

            this.Hide();

            RateTeamMate rate =
                new RateTeamMate(groupId);

            rate.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomeFeed h1 = new HomeFeed();
            h1.Show();
        }
    }

    public class ComboItem
    {
        public string Text;
        public string Value;

        public ComboItem(string t, string v)
        {
            Text = t;
            Value = v;
        }

        public override string ToString()
        {
            return Text;
        }
    }

    public class GroupItem
    {
        public string Text;
        public string Value;

        public GroupItem(string t, string v)
        {
            Text = t;
            Value = v;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}