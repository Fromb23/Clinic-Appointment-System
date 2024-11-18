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
    public partial class Department : Form
    {
        private List<DepartmentModel> DepartmentsList;

        public Department()
        {
            InitializeComponent();
            DepartmentsList = new List<DepartmentModel>();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateDepartment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (departmentTextBox.Text == "")
            {
                MessageBox.Show("Department name required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddDepartment();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDepartment();
        }

        private void LoadDepartments()
        {
            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Departments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                DepartmentsList = dataTable.AsEnumerable().Select(row => new DepartmentModel
                {
                    Id = row.Field<int>("Id"),
                    Name = row.Field<string>("name")
                }).ToList();
                departmentsGridView.DataSource = dataTable;
            }
        }

        private void AddDepartment()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Departments (name) VALUES (@name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", departmentTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            LoadDepartments();
            ClearFields();
        }

        private void UpdateDepartment()
        {
            using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Departments SET name = @name WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", departmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@id", key);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadDepartments();
            ClearFields();
        }

        private void DeleteDepartment()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Departments WHERE Id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", key);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDepartments();
            ClearFields();
        }

        private void ClearFields()
        {
            departmentTextBox.Clear();
        }

        int key = 0;
        private void departmentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = departmentsGridView.Rows[e.RowIndex];
                departmentTextBox.Text = row.Cells["name"].Value.ToString();
                key = Convert.ToInt32(row.Cells["Id"].Value.ToString());
                Console.WriteLine("Hello there...");
            }
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
