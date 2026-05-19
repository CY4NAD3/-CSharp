using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            try
            {
                using SqlConnection con = DbHelper.GetAuthConnection();
                con.Open();

                // Parameterized query (safer than string concat)
                string query = "SELECT COUNT(*) FROM Users WHERE UserName=@u AND Password=@p";
                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    Dashboard ds = new Dashboard();
                    ds.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong credentials!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnEyeOpen_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnEyeClosed.BringToFront();
            }
        }

        private void btnEyeClosed_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                btnEyeOpen.BringToFront();
            }
        }
    }
}
