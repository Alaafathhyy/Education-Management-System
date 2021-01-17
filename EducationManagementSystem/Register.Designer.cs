
using System;

namespace EducationManagementSystem
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
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.mailText = new System.Windows.Forms.TextBox();
            this.userTypeCheckBox = new System.Windows.Forms.CheckedListBox();
            this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.RegisterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(464, 269);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(116, 39);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(130, 43);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(124, 19);
            this.nameText.TabIndex = 1;
            // 
            // mobileText
            // 
            this.mobileText.Location = new System.Drawing.Point(130, 142);
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(124, 19);
            this.mobileText.TabIndex = 3;
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(130, 194);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(127, 19);
            this.mailText.TabIndex = 4;
            // 
            // userTypeCheckBox
            // 
            this.userTypeCheckBox.CheckOnClick = true;
            this.userTypeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeCheckBox.FormattingEnabled = true;
            this.userTypeCheckBox.Items.AddRange(new object[] {
            "Student",
            "Instructor"});
            this.userTypeCheckBox.Location = new System.Drawing.Point(116, 240);
            this.userTypeCheckBox.Name = "userTypeCheckBox";
            this.userTypeCheckBox.Size = new System.Drawing.Size(141, 34);
            this.userTypeCheckBox.TabIndex = 5;
            // 
            // RegisterGroupBox
            // 
            this.RegisterGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterGroupBox.BackColor = System.Drawing.Color.SeaShell;
            this.RegisterGroupBox.Controls.Add(this.label5);
            this.RegisterGroupBox.Controls.Add(this.PasswordText);
            this.RegisterGroupBox.Controls.Add(this.mailText);
            this.RegisterGroupBox.Controls.Add(this.userTypeCheckBox);
            this.RegisterGroupBox.Controls.Add(this.mobileText);
            this.RegisterGroupBox.Controls.Add(this.nameText);
            this.RegisterGroupBox.Controls.Add(this.label4);
            this.RegisterGroupBox.Controls.Add(this.label3);
            this.RegisterGroupBox.Controls.Add(this.label1);
            this.RegisterGroupBox.Controls.Add(this.RegisterButton);
            this.RegisterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterGroupBox.Location = new System.Drawing.Point(69, 38);
            this.RegisterGroupBox.Name = "RegisterGroupBox";
            this.RegisterGroupBox.Size = new System.Drawing.Size(602, 328);
            this.RegisterGroupBox.TabIndex = 0;
            this.RegisterGroupBox.TabStop = false;
            this.RegisterGroupBox.Text = "Registeration Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(130, 89);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(124, 19);
            this.PasswordText.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(69, 402);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(116, 39);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackClick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 470);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RegisterGroupBox);
            this.Name = "Register";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.RegisterGroupBox.ResumeLayout(false);
            this.RegisterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox mobileText;
        private System.Windows.Forms.TextBox mailText;
        private System.Windows.Forms.CheckedListBox userTypeCheckBox;
        private System.Windows.Forms.GroupBox RegisterGroupBox;
        private EventHandler form2_Load;

        public EventHandler GetForm2_Load()
        {
            return form2_Load;
        }

        private void SetForm2_Load(EventHandler value)
        {
            form2_Load = value;
        }

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordText;
    }
}