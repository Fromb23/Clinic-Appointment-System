namespace ClinicAppointment
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            fullNameTxtBox = new TextBox();
            userNameTxtBox = new TextBox();
            label4 = new Label();
            contactTxtBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            genderComboBox = new ComboBox();
            confirmPassTxtBox = new TextBox();
            label7 = new Label();
            passwordTxtBox = new TextBox();
            label8 = new Label();
            btnRegister = new Button();
            signInLabel = new Label();
            closeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 541);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(211, 40);
            label1.Name = "label1";
            label1.Size = new Size(374, 29);
            label1.TabIndex = 1;
            label1.Text = "Clinic Appointment System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(211, 172);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 3;
            label2.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(197, 211);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 4;
            label3.Text = "Full Name";
            // 
            // fullNameTxtBox
            // 
            fullNameTxtBox.Location = new Point(197, 241);
            fullNameTxtBox.Name = "fullNameTxtBox";
            fullNameTxtBox.Size = new Size(202, 27);
            fullNameTxtBox.TabIndex = 5;
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Location = new Point(442, 241);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(202, 27);
            userNameTxtBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(442, 211);
            label4.Name = "label4";
            label4.Size = new Size(90, 18);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // contactTxtBox
            // 
            contactTxtBox.Location = new Point(197, 328);
            contactTxtBox.Name = "contactTxtBox";
            contactTxtBox.Size = new Size(202, 27);
            contactTxtBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(197, 298);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 8;
            label5.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(442, 298);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            genderComboBox.Location = new Point(442, 329);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(202, 26);
            genderComboBox.TabIndex = 11;
            // 
            // confirmPassTxtBox
            // 
            confirmPassTxtBox.Location = new Point(442, 410);
            confirmPassTxtBox.Name = "confirmPassTxtBox";
            confirmPassTxtBox.Size = new Size(202, 27);
            confirmPassTxtBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(442, 380);
            label7.Name = "label7";
            label7.Size = new Size(148, 18);
            label7.TabIndex = 14;
            label7.Text = "ConfirmPassword";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(197, 410);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(202, 27);
            passwordTxtBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(197, 380);
            label8.Name = "label8";
            label8.Size = new Size(85, 18);
            label8.TabIndex = 12;
            label8.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Teal;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(197, 463);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(447, 39);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.Font = new Font("Verdana", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            signInLabel.ForeColor = Color.Crimson;
            signInLabel.Location = new Point(568, 513);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(66, 18);
            signInLabel.TabIndex = 17;
            signInLabel.Text = "Sign In";
            signInLabel.Click += signInLabel_Click;
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeLabel.ForeColor = Color.Crimson;
            closeLabel.Location = new Point(634, 9);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(29, 29);
            closeLabel.TabIndex = 18;
            closeLabel.Text = "X";
            closeLabel.Click += closeLabel_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 540);
            Controls.Add(closeLabel);
            Controls.Add(signInLabel);
            Controls.Add(btnRegister);
            Controls.Add(confirmPassTxtBox);
            Controls.Add(label7);
            Controls.Add(passwordTxtBox);
            Controls.Add(label8);
            Controls.Add(genderComboBox);
            Controls.Add(label6);
            Controls.Add(contactTxtBox);
            Controls.Add(label5);
            Controls.Add(userNameTxtBox);
            Controls.Add(label4);
            Controls.Add(fullNameTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox fullNameTxtBox;
        private TextBox userNameTxtBox;
        private Label label4;
        private TextBox contactTxtBox;
        private Label label5;
        private Label label6;
        private ComboBox genderComboBox;
        private TextBox confirmPassTxtBox;
        private Label label7;
        private TextBox passwordTxtBox;
        private Label label8;
        private Button btnRegister;
        private Label signInLabel;
        private Label closeLabel;
    }
}