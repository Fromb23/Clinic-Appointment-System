using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointment
{
    public partial class ClinicNavigation : UserControl
    {
        public ClinicNavigation()
        {
            InitializeComponent();
        }
        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            Form form = new Doctors();
            this.FindForm().Hide();
            form.Show();
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            Form form = new Appointments();
            this.FindForm().Hide();
            form.Show();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Form form = new Users();
            form.Show();
            this.FindForm().Hide();
        }

        private void departmentsBtn_Click(object sender, EventArgs e)
        {
            Form form = new Department();
            form.Show();
            this.FindForm().Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            Form form = new Login();
            form.Show();
            this.FindForm().Hide();
        }
    }
}
