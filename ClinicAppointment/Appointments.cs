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
    public partial class Appointments : Form
    {
        private List<AppointmentModel> AppointmentsList;
        int key = 0;
        public Appointments()
        {
            InitializeComponent();
            AppointmentsList = new List<AppointmentModel>();
        }

        private void LoadAppointments()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    a.Id,
                    a.AppointmentDateTime AS DateTime,
                    u.fullName AS UserName,
                    u.contact AS UserContact,
                    u.gender AS UserGender,
                    d.fullName AS DoctorName,
                    dep.name AS DoctorSpeciality
                FROM 
                    Appointments a
                JOIN 
                    Users u ON a.UserId = u.Id
                JOIN 
                    Doctors d ON a.DoctorId = d.Id
                JOIN 
                    Departments dep ON d.DepartmentId = dep.Id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    AppointmentsList = dataTable.AsEnumerable().Select(row => new AppointmentModel
                    {
                        Id = row.Field<int>("Id"),
                        PatientName = row.Field<string>("UserName") ?? string.Empty,
                        PatientContact = row.Field<string>("UserContact") ?? string.Empty,
                        PatientGender = row.Field<string>("UserGender") ?? string.Empty,
                        DateTime = row.Field<DateTime>("DateTime"),
                        DoctorName = row.Field<string>("DoctorName") ?? string.Empty,
                        DoctorSpeciality = row.Field<string>("DoctorSpeciality") ?? string.Empty
                    }).ToList();
                    appointmentsGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, fullName FROM Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    userComboBox.DataSource = dataTable;
                    userComboBox.DisplayMember = "fullName";
                    userComboBox.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, fullName FROM Doctors";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    doctorComboBox.DataSource = dataTable;
                    doctorComboBox.DisplayMember = "fullName";
                    doctorComboBox.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAppointment()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userComboBox.Text) ||
                    string.IsNullOrWhiteSpace(doctorComboBox.Text))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Appointments (UserId, DoctorId, AppointmentDateTime) VALUES  (@patient, @doctor, @dateTime)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patient", userComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@doctor", doctorComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@dateTime", dateTimePicker.Value);
                        cmd.ExecuteNonQuery();
                        LoadAppointments();
                        MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding appointmnet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }


        private void UpdateAppointment()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Appointments SET UserId = @patientId, DoctorId = @doctorId, AppointmentDateTime = @dateTime WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@patientId", userComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@doctorId", doctorComboBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@dateTime", dateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                        LoadAppointments();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        private void DeleteAppointment()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Appointments WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAppointments();
            ClearFields();
        }
        private void ClearFields()
        {
            userComboBox.Select();
            doctorComboBox.Select();
            dateTimePicker.Value = DateTime.Now;
            key = 0;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            UpdateAppointment();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAppointment();
        }

        private void appointmentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = appointmentsGridView.Rows[e.RowIndex];
                    userComboBox.Text = row.Cells["UserName"].Value.ToString();
                    doctorComboBox.Text = row.Cells["DoctorName"].Value.ToString();
                    dateTimePicker.Value = Convert.ToDateTime(row.Cells["DateTime"].Value.ToString());
                    key = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Error selecting appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadUsers();
            LoadDoctors();
        }
    }
    public class AppointmentModel
    {
        public int Id { get; set; }
        public required string DoctorName { get; set; }
        public required string DoctorSpeciality { get; set; }
        public required string PatientName { get; set; }
        public required string PatientContact { get; set; }
        public required string PatientGender { get; set; }
        public required DateTime DateTime { get; set; }
    }
}
