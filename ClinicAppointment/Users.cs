using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ClinicAppointment
{
    public partial class Users : Form
    {
        private List<UserModel> UsersList;
        int key = 0;
        public Users()
        {
            InitializeComponent();
            UsersList = new List<UserModel>();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // Load users to the Grid View
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = @"
                                    SELECT Id, fullName, contact, gender FROM Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    UsersList = dataTable.AsEnumerable().Select(row => new UserModel
                    {
                        Id = row.Field<int>("Id"),
                        FullName = row.Field<string>("fullName") ?? string.Empty,
                        Gender = row.Field<string>("gender") ?? string.Empty,
                        Contact = row.Field<string>("contact") ?? string.Empty
                    }).ToList();
                    usersGridView.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fullNameTxtBox.Text) ||
                    string.IsNullOrWhiteSpace(contactTxtBox.Text) || string.IsNullOrWhiteSpace(genderComboBox.Text))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Users (fullName, contact, gender) VALUES  (@name, @cont, @gen)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullNameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@cont", contactTxtBox.Text);
                        cmd.Parameters.AddWithValue("@gen", genderComboBox.Text);
                        cmd.ExecuteNonQuery();
                        LoadUsers();
                        MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        private void UpdateUser()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Users SET fullName = @name, contact = @contact, gender = @gender WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullNameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@contact", contactTxtBox.Text);
                        cmd.Parameters.AddWithValue("@gender", genderComboBox.Text);
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadUsers();
            ClearFields();
        }

        private void DeleteUser()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadUsers();
            ClearFields();
        }

        private void ClearFields()
        {
            fullNameTxtBox.Clear();
            genderComboBox.Select();
            contactTxtBox.Clear();
            key = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void usersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = usersGridView.Rows[e.RowIndex];
                    fullNameTxtBox.Text = row.Cells["fullName"].Value.ToString();
                    contactTxtBox.Text = row.Cells["contact"].Value.ToString();
                    genderComboBox.Text = row.Cells["gender"].Value.ToString();
                    key = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error selecting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class UserModel
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Gender { get; set; }
        public required string Contact { get; set; }
    }
}
