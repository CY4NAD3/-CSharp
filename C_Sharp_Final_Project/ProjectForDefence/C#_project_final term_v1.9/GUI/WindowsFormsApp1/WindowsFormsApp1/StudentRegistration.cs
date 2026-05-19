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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.Items.Add("Other");
        }

     
        
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=DESKTOP-MJTHEPS\\SQLEXPRESS; database=PeerSyncDB; integrated security=SSPI";

            string name = nameTextBox.Text.Trim();
            string aiubId = aiubIdTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string gender = genderComboBox.SelectedItem?.ToString();
            string department = departmentTextBox.Text.Trim();
            string semester = semesterTextBox.Text.Trim();
            string skills = skillsTextBox.Text.Trim();
            string workStyle = workStyleTextBox.Text.Trim();

          
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aiubId) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(department) || string.IsNullOrWhiteSpace(semester))
            {
                MessageBox.Show("Please fill all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE AiubId = @AiubId";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@AiubId", aiubId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This AIUB ID is already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    
                    string insertUserQuery = @"INSERT INTO [User] (AiubId, PasswordHash, Name, Gender, Department, Semester, Role, ReputationScore) 
                                              VALUES (@AiubId, @Password, @Name, @Gender, @Department, @Semester, 'Student', 0);
                                              SELECT SCOPE_IDENTITY();";

                    int newUserId;
                    using (SqlCommand command = new SqlCommand(insertUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AiubId", aiubId);
                        command.Parameters.AddWithValue("@Password", password); 
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Department", department);
                        command.Parameters.AddWithValue("@Semester", semester);

                        newUserId = Convert.ToInt32(command.ExecuteScalar());
                    }

                    
                    if (!string.IsNullOrWhiteSpace(skills))
                    {
                        string[] skillArray = skills.Split(',');
                        foreach (string skill in skillArray)
                        {
                            string skillTrimmed = skill.Trim();
                            if (!string.IsNullOrWhiteSpace(skillTrimmed))
                            {
                                string insertSkillQuery = "INSERT INTO Skill (UserId, SkillName) VALUES (@UserId, @SkillName)";
                                using (SqlCommand skillCmd = new SqlCommand(insertSkillQuery, connection))
                                {
                                    skillCmd.Parameters.AddWithValue("@UserId", newUserId);
                                    skillCmd.Parameters.AddWithValue("@SkillName", skillTrimmed);
                                    skillCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    
                    if (!string.IsNullOrWhiteSpace(workStyle))
                    {
                        string[] styleArray = workStyle.Split(',');
                        foreach (string style in styleArray)
                        {
                            string styleTrimmed = style.Trim();
                            if (!string.IsNullOrWhiteSpace(styleTrimmed))
                            {
                                string insertStyleQuery = "INSERT INTO WorkStyle (UserId, StyleName) VALUES (@UserId, @StyleName)";
                                using (SqlCommand styleCmd = new SqlCommand(insertStyleQuery, connection))
                                {
                                    styleCmd.Parameters.AddWithValue("@UserId", newUserId);
                                    styleCmd.Parameters.AddWithValue("@StyleName", styleTrimmed);
                                    styleCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Registration successful! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    StudentLogin studentLogin = new StudentLogin();
                    studentLogin.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin s1 = new StudentLogin();
            s1.Show();

        }
    }
}
