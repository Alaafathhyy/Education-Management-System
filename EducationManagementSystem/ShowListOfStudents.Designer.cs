
namespace WindowsFormsApp2
{
    partial class ShowListOfStudents
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showDataButton = new System.Windows.Forms.Button();
            this.categoryIDText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(50, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 404);
            this.dataGridView1.TabIndex = 0;
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
            // semesterText
            // 
            this.semesterText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.semesterText.Location = new System.Drawing.Point(107, 55);
            this.semesterText.Margin = new System.Windows.Forms.Padding(2);
            this.semesterText.Name = "semesterText";
            this.semesterText.Size = new System.Drawing.Size(134, 20);
            this.semesterText.TabIndex = 1;
            // 
            // yearText
            // 
            this.yearText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearText.Location = new System.Drawing.Point(107, 18);
            this.yearText.Margin = new System.Windows.Forms.Padding(2);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(134, 20);
            this.yearText.TabIndex = 2;
            // 
            // Year
            // 
            this.Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.Year.Location = new System.Drawing.Point(47, 18);
            this.Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(33, 13);
            this.Year.TabIndex = 3;
            this.Year.Text = "Year";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(270, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category ID";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(47, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semester";
            // 
            // showDataButton
            // 
            this.showDataButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showDataButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.showDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.showDataButton.Location = new System.Drawing.Point(363, 529);
            this.showDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(114, 31);
            this.showDataButton.TabIndex = 8;
            this.showDataButton.Text = "Show Data";
            this.showDataButton.UseVisualStyleBackColor = false;
            this.showDataButton.Click += new System.EventHandler(this.showClick);
            // 
            // categoryIDText
            // 
            this.categoryIDText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryIDText.Location = new System.Drawing.Point(351, 15);
            this.categoryIDText.Margin = new System.Windows.Forms.Padding(2);
            this.categoryIDText.Name = "categoryIDText";
            this.categoryIDText.Size = new System.Drawing.Size(126, 20);
            this.categoryIDText.TabIndex = 9;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.backButton.Location = new System.Drawing.Point(50, 529);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 31);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backClick);
            // 
            // ShowListOfStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 602);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.categoryIDText);
            this.Controls.Add(this.showDataButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.semesterText);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowListOfStudents";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox semesterText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showDataButton;
        private System.Windows.Forms.TextBox categoryIDText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}