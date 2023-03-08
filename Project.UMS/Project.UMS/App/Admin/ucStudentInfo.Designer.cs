
namespace Project.UMS.App.Admin
{
    partial class ucStudentInfo
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
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSFatherName = new System.Windows.Forms.TextBox();
            this.txtSMotherName = new System.Windows.Forms.TextBox();
            this.txtSPass = new System.Windows.Forms.TextBox();
            this.dtpSDob = new System.Windows.Forms.DateTimePicker();
            this.cmbSProgram = new System.Windows.Forms.ComboBox();
            this.cmbSDepartment = new System.Windows.Forms.ComboBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.AllowUserToAddRows = false;
            this.dgvStudentInfo.AllowUserToDeleteRows = false;
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StudentName,
            this.FatherName,
            this.MotherName,
            this.Gender,
            this.BirthDate,
            this.Program,
            this.Department,
            this.Password});
            this.dgvStudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudentInfo.Location = new System.Drawing.Point(0, 276);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.ReadOnly = true;
            this.dgvStudentInfo.RowHeadersWidth = 51;
            this.dgvStudentInfo.RowTemplate.Height = 24;
            this.dgvStudentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentInfo.Size = new System.Drawing.Size(1020, 263);
            this.dgvStudentInfo.TabIndex = 0;
            this.dgvStudentInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentInfo_CellDoubleClick);
            this.dgvStudentInfo.DoubleClick += new System.EventHandler(this.dgvStudentInfo_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Student ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // FatherName
            // 
            this.FatherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FatherName.DataPropertyName = "FatherName";
            this.FatherName.HeaderText = "Father\'s Name";
            this.FatherName.MinimumWidth = 6;
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            // 
            // MotherName
            // 
            this.MotherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MotherName.DataPropertyName = "MotherName";
            this.MotherName.HeaderText = "Mother\'s Name";
            this.MotherName.MinimumWidth = 6;
            this.MotherName.Name = "MotherName";
            this.MotherName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Date of Birtth";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Program
            // 
            this.Program.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Program.DataPropertyName = "Program";
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 6;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Father\'s Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mother\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of  Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Program";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Password";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(132, 40);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(276, 22);
            this.txtID.TabIndex = 10;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(132, 78);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(276, 22);
            this.txtSname.TabIndex = 12;
            // 
            // txtSFatherName
            // 
            this.txtSFatherName.Location = new System.Drawing.Point(132, 116);
            this.txtSFatherName.Name = "txtSFatherName";
            this.txtSFatherName.Size = new System.Drawing.Size(276, 22);
            this.txtSFatherName.TabIndex = 13;
            // 
            // txtSMotherName
            // 
            this.txtSMotherName.Location = new System.Drawing.Point(133, 151);
            this.txtSMotherName.Name = "txtSMotherName";
            this.txtSMotherName.Size = new System.Drawing.Size(276, 22);
            this.txtSMotherName.TabIndex = 14;
            // 
            // txtSPass
            // 
            this.txtSPass.Location = new System.Drawing.Point(555, 152);
            this.txtSPass.Name = "txtSPass";
            this.txtSPass.Size = new System.Drawing.Size(216, 22);
            this.txtSPass.TabIndex = 15;
            // 
            // dtpSDob
            // 
            this.dtpSDob.CustomFormat = "yyyy-MM-dd";
            this.dtpSDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDob.Location = new System.Drawing.Point(556, 41);
            this.dtpSDob.Name = "dtpSDob";
            this.dtpSDob.Size = new System.Drawing.Size(215, 22);
            this.dtpSDob.TabIndex = 16;
            // 
            // cmbSProgram
            // 
            this.cmbSProgram.FormattingEnabled = true;
            this.cmbSProgram.Items.AddRange(new object[] {
            "B.Sc",
            "M.Sc",
            "BBA",
            "MBA"});
            this.cmbSProgram.Location = new System.Drawing.Point(555, 75);
            this.cmbSProgram.Name = "cmbSProgram";
            this.cmbSProgram.Size = new System.Drawing.Size(216, 24);
            this.cmbSProgram.TabIndex = 17;
            this.cmbSProgram.Text = "<<Select>>";
            // 
            // cmbSDepartment
            // 
            this.cmbSDepartment.FormattingEnabled = true;
            this.cmbSDepartment.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "English",
            "Math",
            "Law",
            "Economics",
            "Accounting"});
            this.cmbSDepartment.Location = new System.Drawing.Point(555, 117);
            this.cmbSDepartment.Name = "cmbSDepartment";
            this.cmbSDepartment.Size = new System.Drawing.Size(216, 24);
            this.cmbSDepartment.TabIndex = 18;
            this.cmbSDepartment.Text = "<<Select>>";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.AutoSize = true;
            this.btnGeneratePassword.Location = new System.Drawing.Point(788, 152);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(78, 27);
            this.btnGeneratePassword.TabIndex = 19;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(50, 248);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(276, 22);
            this.txtSearchById.TabIndex = 20;
            this.txtSearchById.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 44);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(630, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 44);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.BackgroundImage = global::Project.UMS.Properties.Resources.Delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(948, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 42);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::Project.UMS.Properties.Resources.icons8_refresh_30px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(948, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 36);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchById);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGeneratePassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbSDepartment);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbSProgram);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpSDob);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSPass);
            this.panel1.Controls.Add(this.txtSname);
            this.panel1.Controls.Add(this.txtSMotherName);
            this.panel1.Controls.Add(this.txtSFatherName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 276);
            this.panel1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 137;
            this.label12.Text = "By ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.UMS.Properties.Resources.icons8_search_40px;
            this.pictureBox1.Location = new System.Drawing.Point(4, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(133, 182);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 23;
            this.cmbGender.Text = "<<Select>>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Add Student Info";
            // 
            // ucStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStudentInfo);
            this.Name = "ucStudentInfo";
            this.Size = new System.Drawing.Size(1020, 539);
            this.Load += new System.EventHandler(this.ucStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSFatherName;
        private System.Windows.Forms.TextBox txtSMotherName;
        private System.Windows.Forms.TextBox txtSPass;
        private System.Windows.Forms.DateTimePicker dtpSDob;
        private System.Windows.Forms.ComboBox cmbSProgram;
        private System.Windows.Forms.ComboBox cmbSDepartment;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
    }
}
