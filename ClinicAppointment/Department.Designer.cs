namespace ClinicAppointment
{
    partial class Department
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            label13 = new Label();
            label11 = new Label();
            departmentsGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            departmentTextBox = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            label12 = new Label();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            clinicNavigation1 = new ClinicNavigation();
            ((System.ComponentModel.ISupportInitialize)departmentsGridView).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(283, 99);
            label13.Name = "label13";
            label13.Size = new Size(225, 18);
            label13.TabIndex = 48;
            label13.Text = "Departments Management";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(567, 284);
            label11.Name = "label11";
            label11.Size = new Size(150, 18);
            label11.TabIndex = 47;
            label11.Text = "Departments List";
            // 
            // departmentsGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            departmentsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            departmentsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            departmentsGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            departmentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            departmentsGridView.ColumnHeadersHeight = 40;
            departmentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            departmentsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            departmentsGridView.GridColor = Color.DarkSeaGreen;
            departmentsGridView.Location = new Point(247, 325);
            departmentsGridView.Name = "departmentsGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            departmentsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            departmentsGridView.RowHeadersVisible = false;
            departmentsGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            departmentsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            departmentsGridView.ScrollBars = ScrollBars.Vertical;
            departmentsGridView.Size = new Size(710, 241);
            departmentsGridView.TabIndex = 46;
            departmentsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            departmentsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            departmentsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            departmentsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            departmentsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            departmentsGridView.ThemeStyle.BackColor = SystemColors.Control;
            departmentsGridView.ThemeStyle.GridColor = Color.DarkSeaGreen;
            departmentsGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            departmentsGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            departmentsGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentsGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            departmentsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            departmentsGridView.ThemeStyle.HeaderStyle.Height = 40;
            departmentsGridView.ThemeStyle.ReadOnly = false;
            departmentsGridView.ThemeStyle.RowsStyle.BackColor = Color.DarkGray;
            departmentsGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            departmentsGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentsGridView.ThemeStyle.RowsStyle.ForeColor = Color.White;
            departmentsGridView.ThemeStyle.RowsStyle.Height = 25;
            departmentsGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            departmentsGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            departmentsGridView.CellContentClick += departmentsGridView_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.Teal;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(697, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 42);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.Teal;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(532, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 42);
            btnAdd.TabIndex = 44;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSeaGreen;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.Teal;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(366, 215);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(141, 42);
            btnEdit.TabIndex = 43;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(521, 151);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(209, 27);
            departmentTextBox.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(567, 120);
            label8.Name = "label8";
            label8.Size = new Size(105, 18);
            label8.TabIndex = 38;
            label8.Text = "Department";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(198, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 52);
            panel4.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(804, 15);
            label9.Name = "label9";
            label9.Size = new Size(23, 23);
            label9.TabIndex = 49;
            label9.Text = "X";
            label9.Click += label9_Click_1;
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
            // clinicNavigation1
            // 
            clinicNavigation1.Location = new Point(-6, -1);
            clinicNavigation1.Name = "clinicNavigation1";
            clinicNavigation1.Size = new Size(207, 656);
            clinicNavigation1.TabIndex = 49;
            // 
            // Department
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 656);
            Controls.Add(clinicNavigation1);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(departmentsGridView);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(departmentTextBox);
            Controls.Add(label8);
            Controls.Add(panel4);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            Load += Department_Load;
            ((System.ComponentModel.ISupportInitialize)departmentsGridView).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView departmentsGridView;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private TextBox departmentTextBox;
        private Label label8;
        private Panel panel4;
        private Label label12;
        private PictureBox pictureBox7;
        private Label label7;
        private Label label9;
        private ClinicNavigation clinicNavigation1;
    }
}