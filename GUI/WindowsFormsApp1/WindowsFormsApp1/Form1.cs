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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string userName = textBox2.Text;



            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=KK; integrated security=SSPI";



            //string query = "SELECT COUNT(*) FROM Section WHERE Id = @Id AND Name = @Name";
            string query = "SELECT COUNT(*) FROM section WHERE Id = @Id AND Name COLLATE SQL_Latin1_General_CP1_CS_AS = @Name";



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.Parameters.AddWithValue("@Name", userName);



                    connection.Open();



                    int count = (int)command.ExecuteScalar();



                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        //Form3 f3 = new Form3();
                         Form3 f3 = new Form3(int.Parse(userId));



                        f3.Show();



                    }
                    else
                    {
                        MessageBox.Show("Invalid Id or Name.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }
    }
}
