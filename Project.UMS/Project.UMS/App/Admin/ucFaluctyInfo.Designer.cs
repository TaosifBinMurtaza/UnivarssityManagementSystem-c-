
namespace Project.UMS.App.Admin
{
    partial class ucFaluctyInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFacultyInfo = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFSalery = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFJdate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.cmbFGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFDepartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFDob = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFPass = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtFFatherName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyInfo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFacultyInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 231);
            this.panel1.TabIndex = 0;
            // 
            // dgvFacultyInfo
            // 
            this.dgvFacultyInfo.AllowUserToAddRows = false;
            this.dgvFacultyInfo.AllowUserToDeleteRows = false;
            this.dgvFacultyInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultyInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FacultyName,
            this.FatherName,
            this.BirthDate,
            this.JoiningDate,
            this.Gender,
            this.Department,
            this.Position,
            this.Salary,
            this.Password});
            this.dgvFacultyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacultyInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvFacultyInfo.Name = "dgvFacultyInfo";
            this.dgvFacultyInfo.ReadOnly = true;
            this.dgvFacultyInfo.RowHeadersWidth = 51;
            this.dgvFacultyInfo.RowTemplate.Height = 24;
            this.dgvFacultyInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultyInfo.Size = new System.Drawing.Size(1020, 231);
            this.dgvFacultyInfo.TabIndex = 0;
            this.dgvFacultyInfo.DoubleClick += new System.EventHandler(this.dgvFacultyInfo_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtFSalery);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cmbFPosition);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpFJdate);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSearchById);
            this.panel2.Controls.Add(this.cmbFGender);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtFID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnGeneratePassword);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbFDepartment);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpFDob);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtFPass);
            this.panel2.Controls.Add(this.txtFname);
            this.panel2.Controls.Add(this.txtFFatherName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 308);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 135;
            this.label12.Text = "By ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.UMS.Properties.Resources.icons8_search_40px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // txtFSalery
            // 
            this.txtFSalery.Location = new System.Drawing.Point(596, 167);
            this.txtFSalery.Name = "txtFSalery";
            this.txtFSalery.Size = new System.Drawing.Size(215, 22);
            this.txtFSalery.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(521, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Salery";
            // 
            // cmbFPosition
            // 
            this.cmbFPosition.FormattingEnabled = true;
            this.cmbFPosition.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer"});
            this.cmbFPosition.Location = new System.Drawing.Point(595, 133);
            this.cmbFPosition.Name = "cmbFPosition";
            this.cmbFPosition.Size = new System.Drawing.Size(216, 24);
            this.cmbFPosition.TabIndex = 52;
            this.cmbFPosition.Text = "<<Select>>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Joining Date";
            // 
            // dtpFJdate
            // 
            this.dtpFJdate.CustomFormat = "yyyy-MM-dd";
            this.dtpFJdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFJdate.Location = new System.Drawing.Point(183, 208);
            this.dtpFJdate.Name = "dtpFJdate";
            this.dtpFJdate.Size = new System.Drawing.Size(149, 22);
            this.dtpFJdate.TabIndex = 50;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::Project.UMS.Properties.Resources.icons8_refresh_30px;
            this.btnRefresh.Location = new System.Drawing.Point(921, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 43);
            this.btnRefresh.TabIndex = 48;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Image = global::Project.UMS.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(932, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(664, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 35);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(499, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 35);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(50, 275);
            this.txtSearchById.Multiline = true;
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(276, 30);
            this.txtSearchById.TabIndex = 44;
            this.txtSearchById.TextChanged += new System.EventHandler(this.txtSearchById_TextChanged);
            // 
            // cmbFGender
            // 
            this.cmbFGender.FormattingEnabled = true;
            this.cmbFGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbFGender.Location = new System.Drawing.Point(595, 58);
            this.cmbFGender.Name = "cmbFGender";
            this.cmbFGender.Size = new System.Drawing.Size(121, 24);
            this.cmbFGender.TabIndex = 43;
            this.cmbFGender.Text = "<<Select>>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 27);
            this.label10.TabIndex = 42;
            this.label10.Text = "Add Faculty Info";
            // 
            // txtFID
            // 
            this.txtFID.Location = new System.Drawing.Point(183, 58);
            this.txtFID.Name = "txtFID";
            this.txtFID.ReadOnly = true;
            this.txtFID.Size = new System.Drawing.Size(244, 22);
            this.txtFID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = " Faculty ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Faculty Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Father\'s Name ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(817, 203);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(83, 26);
            this.btnGeneratePassword.TabIndex = 41;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date of  Birth";
            // 
            // cmbFDepartment
            // 
            this.cmbFDepartment.FormattingEnabled = true;
            this.cmbFDepartment.Items.AddRange(new object[] {
            "FASS",
            "FBA",
            "FE",
            "FST"});
            this.cmbFDepartment.Location = new System.Drawing.Point(595, 97);
            this.cmbFDepartment.Name = "cmbFDepartment";
            this.cmbFDepartment.Size = new System.Drawing.Size(216, 24);
            this.cmbFDepartment.TabIndex = 40;
            this.cmbFDepartment.Text = "<<Select>>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Department";
            // 
            // dtpFDob
            // 
            this.dtpFDob.CustomFormat = "yyyy-MM-dd";
            this.dtpFDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFDob.Location = new System.Drawing.Point(183, 167);
            this.dtpFDob.Name = "dtpFDob";
            this.dtpFDob.Size = new System.Drawing.Size(149, 22);
            this.dtpFDob.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(496, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "Password";
            // 
            // txtFPass
            // 
            this.txtFPass.Location = new System.Drawing.Point(595, 204);
            this.txtFPass.Name = "txtFPass";
            this.txtFPass.Size = new System.Drawing.Size(216, 22);
            this.txtFPass.TabIndex = 37;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(183, 96);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(244, 22);
            this.txtFname.TabIndex = 34;
            // 
            // txtFFatherName
            // 
            this.txtFFatherName.Location = new System.Drawing.Point(183, 134);
            this.txtFFatherName.Name = "txtFFatherName";
            this.txtFFatherName.Size = new System.Drawing.Size(244, 22);
            this.txtFFatherName.TabIndex = 35;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Faculty ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyName.DataPropertyName = "FacultyName";
            this.FacultyName.HeaderText = "Faculty name";
            this.FacultyName.MinimumWidth = 6;
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
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
            // BirthDate
            // 
            this.BirthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Date of Birth";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // JoiningDate
            // 
            this.JoiningDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.MinimumWidth = 6;
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
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
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Designation";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
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
            // ucFaluctyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucFaluctyInfo";
            this.Size = new System.Drawing.Size(1020, 539);
            this.Load += new System.EventHandler(this.ucFaluctyInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultyInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvFacultyInfo;
        private System.Windows.Forms.ComboBox cmbFGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFDob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFPass;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtFFatherName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.ComboBox cmbFPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFJdate;
        private System.Windows.Forms.TextBox txtFSalery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}
