using Microsoft.Data.SqlClient;

namespace ClinicAppointment
{
    public partial class Login : Form
    {
        string sqlString = "";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userNameTxtBox.Text) || string.IsNullOrWhiteSpace(passwordTxtBox.Text))
                {
                    MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();

                    string sqlString = "SELECT * FROM Users WHERE userName = @userName AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", userNameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@password", passwordTxtBox.Text); // Hash if stored as hashed
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            // Save login details (basic session mechanism)
                            CurrentUser.UserName = dr["userName"].ToString();
                            CurrentUser.FullName = dr["fullName"].ToString();

                            // Navigate to Doctors form
                            Form doctors_dashboard = new Doctors();
                            doctors_dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userNameTxtBox.Clear();
                            passwordTxtBox.Clear();
                            userNameTxtBox.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
