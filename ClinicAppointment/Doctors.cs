using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ClinicAppointment
{
    public partial class Doctors : Form
    {
        private List<DoctorModel> DoctorsList;
        int key = 0;

        public Doctors()
        {
            InitializeComponent();
            DoctorsList = new List<DoctorModel>();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = @"
                                    SELECT d.Id, d.fullName, d.doctorIdNo, dep.name AS Specialization
                                    FROM Doctors d
                                    JOIN Departments dep ON d.DepartmentId = dep.Id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    DoctorsList = dataTable.AsEnumerable().Select(row => new DoctorModel
                    {
                        Id = row.Field<int>("Id"),
                        Name = row.Field<string>("fullName") ?? string.Empty,
                        Specialization = row.Field<string>("Specialization") ?? string.Empty,
                        DoctorIdNo = row.Field<string>("doctorIdNo") ?? string.Empty
                    }).ToList();
                    doctorsGridView.DataSource = dataTable;

                    // Load departments into ComboBox
                    LoadDepartments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDepartments()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, Name FROM Departments";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    departmentConboBox.DataSource = dataTable;
                    departmentConboBox.DisplayMember = "Name";
                    departmentConboBox.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                Form department_screen = new Department();
                department_screen.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Department form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // adds a new doctor to the database
                AddDoctor();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // updates doctor information in the database
                UpdateDoctor();
                MessageBox.Show("Doctor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDoctor()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(doctorIdTextBOX.Text))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Doctors (fullName, departmentId, doctorIdNo) VALUES  (@name, @departmentId, @doctorIdNo)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@departmentId", departmentConboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@doctorIdNo", doctorIdTextBOX.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDoctors();
            ClearFields();
        }

        private void UpdateDoctor()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Doctors SET fullName = @name, departmentId = @specialization, doctorIdNo = @doctorId WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", fullNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@specialization", departmentConboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@doctorId", doctorIdTextBOX.Text);
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDoctors();
            ClearFields();
        }

        private void DeleteDoctor()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Doctors WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDoctors();
            ClearFields();
        }

        private void ClearFields()
        {
            fullNameTextBox.Clear();
            departmentConboBox.Select();
            doctorIdTextBOX.Clear();
            key = 0;
        }


        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void closeLabel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select a doctor to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Doctors WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doctorsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = doctorsGridView.Rows[e.RowIndex];
                    fullNameTextBox.Text = row.Cells["fullName"].Value.ToString();
                    doctorIdTextBOX.Text = row.Cells["doctorIdNo"].Value.ToString();
                    // MessageBox.Show(departmentConboBox.Selected);
                    departmentConboBox.Text = row.Cells["Specialization"].Value.ToString();
                    key = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error selecting doctor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }

    public class DoctorModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Specialization { get; set; }
        public required string DoctorIdNo { get; set; }
    }
}