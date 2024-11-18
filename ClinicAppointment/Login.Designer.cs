using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicAppointment
{
    partial class Login
    {
      
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            userNameTxtBox = new TextBox();
            label2 = new Label();
            passwordTxtBox = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 540);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(154, 34);
            label1.Name = "label1";
            label1.Size = new Size(374, 29);
            label1.TabIndex = 1;
            label1.Text = "Clinic Appointment System";
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Location = new Point(172, 277);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(250, 27);
            userNameTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 228);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(172, 361);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(250, 27);
            passwordTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 326);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(172, 417);
            button1.Name = "button1";
            button1.Size = new Size(250, 32);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(367, 463);
            label4.Name = "label4";
            label4.Size = new Size(50, 18);
            label4.TabIndex = 6;
            label4.Text = "Reset";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(505, 9);
            label5.Name = "label5";
            label5.Size = new Size(23, 23);
            label5.TabIndex = 7;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 540);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTxtBox);
            Controls.Add(userNameTxtBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox userNameTxtBox;
        private Label label2;
        private TextBox passwordTxtBox;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}
