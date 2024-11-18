
namespace ClinicAppointment
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
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
            genderComboBox = new ComboBox();
            label10 = new Label();
            contactTxtBox = new TextBox();
            label9 = new Label();
            fullNameTxtBox = new TextBox();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            clinicNavigation1 = new ClinicNavigation();
            usersGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usersGridView).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(308, 76);
            label13.Name = "label13";
            label13.Size = new Size(165, 18);
            label13.TabIndex = 34;
            label13.Text = "Users Management";
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
            label11.Location = new Point(598, 273);
            label11.Name = "label11";
            label11.Size = new Size(90, 18);
            label11.TabIndex = 33;
            label11.Text = "Users List";
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Crimson;
            deleteBtn.FlatAppearance.BorderColor = Color.Teal;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(705, 213);
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
            addBtn.FlatAppearance.BorderColor = Color.Teal;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(540, 215);
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
            editBtn.FlatAppearance.BorderColor = Color.Teal;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(374, 215);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(141, 42);
            editBtn.TabIndex = 29;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(514, 151);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(133, 26);
            genderComboBox.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(681, 120);
            label10.Name = "label10";
            label10.Size = new Size(71, 18);
            label10.TabIndex = 27;
            label10.Text = "Contact";
            // 
            // contactTxtBox
            // 
            contactTxtBox.Location = new Point(681, 150);
            contactTxtBox.Name = "contactTxtBox";
            contactTxtBox.Size = new Size(250, 27);
            contactTxtBox.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(525, 120);
            label9.Name = "label9";
            label9.Size = new Size(66, 18);
            label9.TabIndex = 25;
            label9.Text = "Gender";
            // 
            // fullNameTxtBox
            // 
            fullNameTxtBox.Location = new Point(281, 151);
            fullNameTxtBox.Name = "fullNameTxtBox";
            fullNameTxtBox.Size = new Size(209, 27);
            fullNameTxtBox.TabIndex = 23;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(281, 120);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 24;
            label8.Text = "Full Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(206, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 52);
            panel4.TabIndex = 22;
            // 
            // clinicNavigation1
            // 
            clinicNavigation1.Location = new Point(-1, -1);
            clinicNavigation1.Name = "clinicNavigation1";
            clinicNavigation1.Size = new Size(207, 656);
            clinicNavigation1.TabIndex = 35;
            // 
            // usersGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            usersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            usersGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            usersGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            usersGridView.ColumnHeadersHeight = 40;
            usersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            usersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            usersGridView.GridColor = Color.DarkSeaGreen;
            usersGridView.Location = new Point(281, 310);
            usersGridView.Name = "usersGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            usersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            usersGridView.RowHeadersVisible = false;
            usersGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            usersGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            usersGridView.ScrollBars = ScrollBars.Vertical;
            usersGridView.Size = new Size(710, 241);
            usersGridView.TabIndex = 48;
            usersGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            usersGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            usersGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            usersGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            usersGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            usersGridView.ThemeStyle.BackColor = SystemColors.Control;
            usersGridView.ThemeStyle.GridColor = Color.DarkSeaGreen;
            usersGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            usersGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            usersGridView.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            usersGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            usersGridView.ThemeStyle.HeaderStyle.Height = 40;
            usersGridView.ThemeStyle.ReadOnly = false;
            usersGridView.ThemeStyle.RowsStyle.BackColor = Color.DarkGray;
            usersGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            usersGridView.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersGridView.ThemeStyle.RowsStyle.ForeColor = Color.White;
            usersGridView.ThemeStyle.RowsStyle.Height = 25;
            usersGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            usersGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            usersGridView.CellContentClick += usersGridView_CellContentClick;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 648);
            Controls.Add(usersGridView);
            Controls.Add(clinicNavigation1);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(editBtn);
            Controls.Add(genderComboBox);
            Controls.Add(label10);
            Controls.Add(contactTxtBox);
            Controls.Add(label9);
            Controls.Add(fullNameTxtBox);
            Controls.Add(label8);
            Controls.Add(panel4);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usersGridView).EndInit();
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
        private ComboBox comboBox1;
        private Label label10;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox1;
        private PictureBox pictureBox7;
        private Label label7;
        private Label label8;
        private Panel panel4;
        private ClinicNavigation clinicNavigation1;
        private ComboBox genderComboBox;
        private TextBox contactTxtBox;
        private TextBox fullNameTxtBox;
        private Guna.UI2.WinForms.Guna2DataGridView usersGridView;
    }
}