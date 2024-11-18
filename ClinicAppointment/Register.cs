using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace ClinicAppointment
{
    public partial class Register : Form
    {
        string sqlString = "";
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void signInLabel_Click(object sender, EventArgs e)
        {
            Form loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate that all fields are filled
                if (string.IsNullOrWhiteSpace(fullNameTxtBox.Text) ||
                    string.IsNullOrWhiteSpace(userNameTxtBox.Text) ||
                    string.IsNullOrWhiteSpace(contactTxtBox.Text) ||
                    string.IsNullOrWhiteSpace(genderComboBox.Text) ||
                    string.IsNullOrWhiteSpace(passwordTxtBox.Text) ||
                    string.IsNullOrWhiteSpace(confirmPassTxtBox.Text))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verify that password and confirm password match
                if (passwordTxtBox.Text != confirmPassTxtBox.Text)
                {
                    MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();

                    // Check if the username already exists
                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE userName = @userName";
                    using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@userName", userNameTxtBox.Text);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertQuery = "INSERT INTO Users (userName, fullName, contact, gender, password) VALUES (@userName, @fullName, @contact, @gender, @password)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@userName", userNameTxtBox.Text);
                        insertCmd.Parameters.AddWithValue("@fullName", fullNameTxtBox.Text);
                        insertCmd.Parameters.AddWithValue("@contact", contactTxtBox.Text);
                        insertCmd.Parameters.AddWithValue("@gender", genderComboBox.Text);
                        insertCmd.Parameters.AddWithValue("@password", passwordTxtBox.Text); // Ideally hashed before storing
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
