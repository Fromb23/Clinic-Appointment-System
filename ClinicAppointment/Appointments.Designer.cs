namespace ClinicAppointment
{
    partial class Appointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            deleteBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            panel4 = new Panel();
            clinicNavigation1 = new ClinicNavigation();
            userComboBox = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            doctorComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            appointmentsGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(303, 88);
            label13.Name = "label13";
            label13.Size = new Size(233, 18);
            label13.TabIndex = 34;
            label13.Text = "Appointments Management";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(851, 12);
            label12.Name = "label12";
            label12.Size = new Size(23, 23);
            label12.TabIndex = 8;
            label12.Text = "X";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(536, 288);
            label11.Name = "label11";
            label11.Size = new Size(158, 18);
            label11.TabIndex = 33;
            label11.Text = "Appointments List";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.FlatAppearance.BorderColor = Color.Teal;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(681, 227);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(141, 42);
            deleteBtn.TabIndex = 31;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Teal;
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderColor = Color.Teal;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(506, 227);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(141, 42);
            addBtn.TabIndex = 30;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.LightSeaGreen;
            editBtn.Cursor = Cursors.Hand;
            editBtn.FlatAppearance.BorderColor = Color.Teal;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(340, 227);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(141, 42);
            editBtn.TabIndex = 29;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 7);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(46, 37);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 10);
            label7.Name = "label7";
            label7.Size = new Size(374, 29);
            label7.TabIndex = 4;
            label7.Text = "Clinic Appointment System";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(198, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 52);
            panel4.TabIndex = 22;
            // 
            // clinicNavigation1
            // 
            clinicNavigation1.Location = new Point(-6, -1);
            clinicNavigation1.Name = "clinicNavigation1";
            clinicNavigation1.Size = new Size(207, 687);
            clinicNavigation1.TabIndex = 35;
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(225, 175);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(192, 26);
            userComboBox.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(225, 139);
            label9.Name = "label9";
            label9.Size = new Size(133, 18);
            label9.TabIndex = 37;
            label9.Text = "Patient's Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(448, 139);
            label1.Name = "label1";
            label1.Size = new Size(127, 18);
            label1.TabIndex = 39;
            label1.Text = "Doctor's Name";
            // 
            // doctorComboBox
            // 
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(448, 175);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(192, 26);
            doctorComboBox.TabIndex = 38;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(694, 175);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 27);
            dateTimePicker.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(695, 139);
            label2.Name = "label2";
            label2.Size = new Size(158, 18);
            label2.TabIndex = 41;
            label2.Text = "Appointment Date";
            // 
            // appointmentsGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            appointmentsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            appointmentsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appointmentsGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            appointmentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            appointmentsGridView.ColumnHeadersHeight = 40;
            appointmentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            appointmentsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            appointmentsGridView.GridColor = Color.DarkSeaGreen;
            appointmentsGridView.Location = new Point(240, 320);
            appointmentsGridView.Name = "appointmentsGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            appointmentsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            appointmentsGridView.RowHeadersVisible = false;
            appointmentsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            appointmentsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            appointmentsGridView.ScrollBars = ScrollBars.Vertical;
            appointmentsGridView.Size = new Size(710, 241);
            appointmentsGridView.TabIndex = 48;
            appointmentsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            appointmentsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            appointmentsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            appointmentsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            appointmentsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            appointmentsGridView.ThemeStyle.BackColor = SystemColors.Control;
            appointmentsGridView.ThemeStyle.GridColor = Color.DarkSeaGreen;
            appointmentsGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            appointmentsGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            appointmentsGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentsGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            appointmentsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            appointmentsGridView.ThemeStyle.HeaderStyle.Height = 40;
            appointmentsGridView.ThemeStyle.ReadOnly = false;
            appointmentsGridView.ThemeStyle.RowsStyle.BackColor = Color.DarkGray;
            appointmentsGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            appointmentsGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointmentsGridView.ThemeStyle.RowsStyle.ForeColor = Color.White;
            appointmentsGridView.ThemeStyle.RowsStyle.Height = 25;
            appointmentsGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            appointmentsGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            appointmentsGridView.CellContentClick += appointmentsGridView_CellContentClick;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 653);
            Controls.Add(appointmentsGridView);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(doctorComboBox);
            Controls.Add(label9);
            Controls.Add(userComboBox);
            Controls.Add(clinicNavigation1);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(editBtn);
            Controls.Add(panel4);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            Load += Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label12;
        private Label label11;
        private Button deleteBtn;
        private Button addBtn;
        private Button editBtn;
        private PictureBox pictureBox7;
        private Label label7;
        private Panel panel4;
        private ClinicNavigation clinicNavigation1;
        private ComboBox userComboBox;
        private Label label9;
        private Label label1;
        private ComboBox doctorComboBox;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView appointmentsGridView;
    }
}