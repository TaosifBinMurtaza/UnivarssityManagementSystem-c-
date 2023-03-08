
namespace Project.UMS.App
{
    partial class ucViewCourseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCourseInfo = new System.Windows.Forms.DataGridView();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtsearchbyCourseId = new System.Windows.Forms.TextBox();
            this.txtSearchbyname = new System.Windows.Forms.TextBox();
            this.txtSearchByDep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCourseInfo);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 334);
            this.panel1.TabIndex = 1;
            // 
            // dgvCourseInfo
            // 
            this.dgvCourseInfo.AllowUserToAddRows = false;
            this.dgvCourseInfo.AllowUserToDeleteRows = false;
            this.dgvCourseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseID,
            this.CourseName,
            this.Department});
            this.dgvCourseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourseInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvCourseInfo.Name = "dgvCourseInfo";
            this.dgvCourseInfo.ReadOnly = true;
            this.dgvCourseInfo.RowHeadersWidth = 51;
            this.dgvCourseInfo.RowTemplate.Height = 24;
            this.dgvCourseInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourseInfo.Size = new System.Drawing.Size(1020, 334);
            this.dgvCourseInfo.TabIndex = 2;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.CourseID.DefaultCellStyle = dataGridViewCellStyle9;
            this.CourseID.FillWeight = 160.4278F;
            this.CourseID.HeaderText = "Course ID";
            this.CourseID.MinimumWidth = 6;
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Width = 125;
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.FillWeight = 69.78609F;
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.FillWeight = 69.78609F;
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 334);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtsearchbyCourseId);
            this.panel2.Controls.Add(this.txtSearchbyname);
            this.panel2.Controls.Add(this.txtSearchByDep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 205);
            this.panel2.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.BackgroundImage = global::Project.UMS.Properties.Resources.icons8_refresh_30px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(915, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 28);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtsearchbyCourseId
            // 
            this.txtsearchbyCourseId.Location = new System.Drawing.Point(656, 157);
            this.txtsearchbyCourseId.Multiline = true;
            this.txtsearchbyCourseId.Name = "txtsearchbyCourseId";
            this.txtsearchbyCourseId.Size = new System.Drawing.Size(292, 32);
            this.txtsearchbyCourseId.TabIndex = 4;
            this.txtsearchbyCourseId.TextChanged += new System.EventHandler(this.txtsearchbyCourseId_TextChanged);
            // 
            // txtSearchbyname
            // 
            this.txtSearchbyname.Location = new System.Drawing.Point(335, 157);
            this.txtSearchbyname.Multiline = true;
            this.txtSearchbyname.Name = "txtSearchbyname";
            this.txtSearchbyname.Size = new System.Drawing.Size(263, 32);
            this.txtSearchbyname.TabIndex = 3;
            this.txtSearchbyname.TextChanged += new System.EventHandler(this.txtSearchbyname_TextChanged);
            // 
            // txtSearchByDep
            // 
            this.txtSearchByDep.Location = new System.Drawing.Point(34, 157);
            this.txtSearchByDep.Multiline = true;
            this.txtSearchByDep.Name = "txtSearchByDep";
            this.txtSearchByDep.Size = new System.Drawing.Size(267, 32);
            this.txtSearchByDep.TabIndex = 2;
            this.txtSearchByDep.TextChanged += new System.EventHandler(this.txtSearchByDep_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "View Course Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 133;
            this.label1.Text = "By Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 134;
            this.label3.Text = "By Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 135;
            this.label4.Text = "By Course ID";
            // 
            // ucViewCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucViewCourseInfo";
            this.Size = new System.Drawing.Size(1020, 539);
            this.Load += new System.EventHandler(this.ucViewCourseInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchbyname;
        private System.Windows.Forms.TextBox txtSearchByDep;
        private System.Windows.Forms.TextBox txtsearchbyCourseId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvCourseInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
