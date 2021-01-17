
namespace WindowsFormsApp2
{
    partial class HomePage
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
            this.editProfileButton = new System.Windows.Forms.Button();
            this.UpdateCourseButton = new System.Windows.Forms.Button();
            this.AddExamButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.showCourcesButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UpdateExamButton = new System.Windows.Forms.Button();
            this.DeleteExamButton = new System.Windows.Forms.Button();
            this.DeleteCourseButton = new System.Windows.Forms.Button();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.HideCourseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Options = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // editProfileButton
            // 
            this.editProfileButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.editProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileButton.Location = new System.Drawing.Point(5, 30);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(160, 40);
            this.editProfileButton.TabIndex = 0;
            this.editProfileButton.Text = "Edit Profile";
            this.editProfileButton.UseVisualStyleBackColor = false;
            this.editProfileButton.Click += new System.EventHandler(this.EditProfileClick);
            // 
            // UpdateCourseButton
            // 
            this.UpdateCourseButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.UpdateCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCourseButton.Location = new System.Drawing.Point(5, 330);
            this.UpdateCourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateCourseButton.Name = "UpdateCourseButton";
            this.UpdateCourseButton.Size = new System.Drawing.Size(160, 40);
            this.UpdateCourseButton.TabIndex = 8;
            this.UpdateCourseButton.Text = "Update Course";
            this.UpdateCourseButton.UseVisualStyleBackColor = false;
            this.UpdateCourseButton.Click += new System.EventHandler(this.UpdateCourseClick);
            // 
            // AddExamButton
            // 
            this.AddExamButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AddExamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExamButton.Location = new System.Drawing.Point(5, 380);
            this.AddExamButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(160, 40);
            this.AddExamButton.TabIndex = 9;
            this.AddExamButton.Text = "Add Exam";
            this.AddExamButton.UseVisualStyleBackColor = false;
            this.AddExamButton.Click += new System.EventHandler(this.AddExamClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoutButton);
            this.groupBox1.Controls.Add(this.showCourcesButton);
            this.groupBox1.Controls.Add(this.addCategoryButton);
            this.groupBox1.Controls.Add(this.addGradeButton);
            this.groupBox1.Controls.Add(this.ApplyButton);
            this.groupBox1.Controls.Add(this.UpdateExamButton);
            this.groupBox1.Controls.Add(this.DeleteExamButton);
            this.groupBox1.Controls.Add(this.DeleteCourseButton);
            this.groupBox1.Controls.Add(this.AddCourseButton);
            this.groupBox1.Controls.Add(this.HideCourseButton);
            this.groupBox1.Controls.Add(this.AddExamButton);
            this.groupBox1.Controls.Add(this.editProfileButton);
            this.groupBox1.Controls.Add(this.UpdateCourseButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(133, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(170, 627);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(5, 580);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(160, 40);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showCourcesButton
            // 
            this.showCourcesButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.showCourcesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.showCourcesButton.Location = new System.Drawing.Point(5, 130);
            this.showCourcesButton.Name = "showCourcesButton";
            this.showCourcesButton.Size = new System.Drawing.Size(160, 40);
            this.showCourcesButton.TabIndex = 4;
            this.showCourcesButton.Text = "Show Courses";
            this.showCourcesButton.UseVisualStyleBackColor = false;
            this.showCourcesButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.addCategoryButton.Location = new System.Drawing.Point(5, 80);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(160, 40);
            this.addCategoryButton.TabIndex = 1;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            this.addCategoryButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // addGradeButton
            // 
            this.addGradeButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.addGradeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGradeButton.Location = new System.Drawing.Point(5, 530);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(160, 40);
            this.addGradeButton.TabIndex = 12;
            this.addGradeButton.Text = "Add Student Grade";
            this.addGradeButton.UseVisualStyleBackColor = false;
            this.addGradeButton.Click += new System.EventHandler(this.AddGradeClick);
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ApplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyButton.Location = new System.Drawing.Point(5, 80);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(160, 40);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply Course";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyClick);
            // 
            // UpdateExamButton
            // 
            this.UpdateExamButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.UpdateExamButton.Location = new System.Drawing.Point(5, 430);
            this.UpdateExamButton.Name = "UpdateExamButton";
            this.UpdateExamButton.Size = new System.Drawing.Size(160, 40);
            this.UpdateExamButton.TabIndex = 10;
            this.UpdateExamButton.Text = "Update Exam";
            this.UpdateExamButton.UseVisualStyleBackColor = false;
            this.UpdateExamButton.Click += new System.EventHandler(this.UpdateExamButton_Click);
            // 
            // DeleteExamButton
            // 
            this.DeleteExamButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DeleteExamButton.Location = new System.Drawing.Point(5, 480);
            this.DeleteExamButton.Name = "DeleteExamButton";
            this.DeleteExamButton.Size = new System.Drawing.Size(160, 40);
            this.DeleteExamButton.TabIndex = 11;
            this.DeleteExamButton.Text = "Delete Exam";
            this.DeleteExamButton.UseVisualStyleBackColor = false;
            this.DeleteExamButton.Click += new System.EventHandler(this.DeleteExamButton_Click);
            // 
            // DeleteCourseButton
            // 
            this.DeleteCourseButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DeleteCourseButton.Location = new System.Drawing.Point(5, 230);
            this.DeleteCourseButton.Name = "DeleteCourseButton";
            this.DeleteCourseButton.Size = new System.Drawing.Size(160, 40);
            this.DeleteCourseButton.TabIndex = 6;
            this.DeleteCourseButton.Text = "Delete Course";
            this.DeleteCourseButton.UseVisualStyleBackColor = false;
            this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.AddCourseButton.Location = new System.Drawing.Point(5, 280);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(160, 40);
            this.AddCourseButton.TabIndex = 7;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = false;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseClick);
            // 
            // HideCourseButton
            // 
            this.HideCourseButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.HideCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideCourseButton.Location = new System.Drawing.Point(5, 180);
            this.HideCourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.HideCourseButton.Name = "HideCourseButton";
            this.HideCourseButton.Size = new System.Drawing.Size(160, 40);
            this.HideCourseButton.TabIndex = 5;
            this.HideCourseButton.Text = "Hide/Show Course";
            this.HideCourseButton.UseVisualStyleBackColor = false;
            this.HideCourseButton.Click += new System.EventHandler(this.HideCourseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(524, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 440);
            this.dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(583, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(620, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // Options
            // 
            this.Options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Options.AutoSize = true;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(521, 43);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(67, 18);
            this.Options.TabIndex = 6;
            this.Options.Text = "Options";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1021, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1367, 699);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button UpdateCourseButton;
        private System.Windows.Forms.Button AddExamButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button HideCourseButton;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.Button DeleteCourseButton;
        private System.Windows.Forms.Button DeleteExamButton;
        private System.Windows.Forms.Button UpdateExamButton;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Options;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button showCourcesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}