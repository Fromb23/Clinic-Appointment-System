

namespace ClinicAppointment
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel4 = new Panel();
            closeLabel = new Label();
            label12 = new Label();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            fullNameTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            doctorIdTextBOX = new TextBox();
            departmentConboBox = new ComboBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            label11 = new Label();
            label8 = new Label();
            label13 = new Label();
            doctorsGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            clinicNavigation1 = new ClinicNavigation();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(closeLabel);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(206, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 52);
            panel4.TabIndex = 6;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Cursor = Cursors.Hand;
            closeLabel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeLabel.ForeColor = Color.White;
            closeLabel.Location = new Point(812, 12);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(23, 23);
            closeLabel.TabIndex = 50;
            closeLabel.Text = "X";
            closeLabel.Click += closeLabel_Click;
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
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(230, 151);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(250, 27);
            fullNameTextBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(503, 120);
            label9.Name = "label9";
            label9.Size = new Size(105, 18);
            label9.TabIndex = 10;
            label9.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(772, 120);
            label10.Name = "label10";
            label10.Size = new Size(58, 18);
            label10.TabIndex = 12;
            label10.Text = "ID NO";
            // 
            // doctorIdTextBOX
            // 
            doctorIdTextBOX.Location = new Point(772, 151);
            doctorIdTextBOX.Name = "doctorIdTextBOX";
            doctorIdTextBOX.Size = new Size(250, 27);
            doctorIdTextBOX.TabIndex = 11;
            // 
            // departmentConboBox
            // 
            departmentConboBox.FormattingEnabled = true;
            departmentConboBox.Location = new Point(503, 151);
            departmentConboBox.Name = "departmentConboBox";
            departmentConboBox.Size = new Size(250, 26);
            departmentConboBox.TabIndex = 13;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSeaGreen;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Teal;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(348, 232);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 42);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Teal;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(514, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 42);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Teal;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(689, 232);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 42);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(572, 290);
            label11.Name = "label11";
            label11.Size = new Size(106, 18);
            label11.TabIndex = 19;
            label11.Text = "Doctors List";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(230, 120);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 8;
            label8.Text = "Full Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(308, 76);
            label13.Name = "label13";
            label13.Size = new Size(181, 18);
            label13.TabIndex = 20;
            label13.Text = "Doctors Management";
            // 
            // doctorsGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            doctorsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            doctorsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            doctorsGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            doctorsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            doctorsGridView.ColumnHeadersHeight = 40;
            doctorsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            doctorsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            doctorsGridView.GridColor = Color.DarkSeaGreen;
            doctorsGridView.Location = new Point(241, 315);
            doctorsGridView.Name = "doctorsGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            doctorsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            doctorsGridView.RowHeadersVisible = false;
            doctorsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            doctorsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            doctorsGridView.ScrollBars = ScrollBars.Vertical;
            doctorsGridView.Size = new Size(710, 241);
            doctorsGridView.TabIndex = 47;
            doctorsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            doctorsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            doctorsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            doctorsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            doctorsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            doctorsGridView.ThemeStyle.BackColor = SystemColors.Control;
            doctorsGridView.ThemeStyle.GridColor = Color.DarkSeaGreen;
            doctorsGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            doctorsGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            doctorsGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorsGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            doctorsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            doctorsGridView.ThemeStyle.HeaderStyle.Height = 40;
            doctorsGridView.ThemeStyle.ReadOnly = false;
            doctorsGridView.ThemeStyle.RowsStyle.BackColor = Color.DarkGray;
            doctorsGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            doctorsGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorsGridView.ThemeStyle.RowsStyle.ForeColor = Color.White;
            doctorsGridView.ThemeStyle.RowsStyle.Height = 25;
            doctorsGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            doctorsGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            doctorsGridView.CellContentClick += doctorsGridView_CellContentClick;
            // 
            // clinicNavigation1
            // 
            clinicNavigation1.Location = new Point(2, -2);
            clinicNavigation1.Name = "clinicNavigation1";
            clinicNavigation1.Size = new Size(207, 656);
            clinicNavigation1.TabIndex = 48;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1053, 647);
            Controls.Add(clinicNavigation1);
            Controls.Add(doctorsGridView);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(departmentConboBox);
            Controls.Add(label10);
            Controls.Add(doctorIdTextBOX);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(fullNameTextBox);
            Controls.Add(panel4);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Doctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctors";
            Load += Doctors_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DoctorsGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel4;
        private PictureBox pictureBox7;
        private Label label7;
        private TextBox fullNameTextBox;
        private Label label9;
        private Label label10;
        private TextBox doctorIdTextBOX;
        private ComboBox departmentConboBox;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label13;
        private Guna.UI2.WinForms.Guna2DataGridView departmentsGridView;
        private PaintEventHandler panel1_Paint;
        private Guna.UI2.WinForms.Guna2DataGridView doctorsGridView;
        private Label closeLabel;
        private ClinicNavigation clinicNavigation1;
    }
}