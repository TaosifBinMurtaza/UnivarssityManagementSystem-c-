
namespace Project.UMS.App.Admin
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnClubInfo = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCourseDetails = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucExpenses1 = new Project.UMS.App.Admin.ucExpenses();
            this.ucClubInfo1 = new Project.UMS.App.Admin.ucClubInfo();
            this.ucLibraryInfo1 = new Project.UMS.App.Admin.ucLibraryInfo();
            this.ucCourseDetails1 = new Project.UMS.App.Admin.ucCourseDetails();
            this.ucEmp1 = new Project.UMS.App.Admin.ucEmp();
            this.ucFaluctyInfo1 = new Project.UMS.App.Admin.ucFaluctyInfo();
            this.ucStudentInfo1 = new Project.UMS.App.Admin.ucStudentInfo();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 539);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.btnlogout);
            this.panel3.Controls.Add(this.lblInfo);
            this.panel3.Controls.Add(this.btnExpenses);
            this.panel3.Controls.Add(this.btnStudent);
            this.panel3.Controls.Add(this.btnClubInfo);
            this.panel3.Controls.Add(this.btnFaculty);
            this.panel3.Controls.Add(this.btnLibrary);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnCourseDetails);
            this.panel3.Location = new System.Drawing.Point(14, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 490);
            this.panel3.TabIndex = 8;
            // 
            // btnlogout
            // 
            this.btnlogout.BackgroundImage = global::Project.UMS.Properties.Resources.icons8_logout_rounded_left_64px;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Location = new System.Drawing.Point(47, 436);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(67, 51);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(62, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(59, 20);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "label1";
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Location = new System.Drawing.Point(0, 380);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(174, 50);
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.SkyBlue;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 56);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(174, 50);
            this.btnStudent.TabIndex = 0;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnClubInfo
            // 
            this.btnClubInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClubInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClubInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClubInfo.Location = new System.Drawing.Point(0, 326);
            this.btnClubInfo.Name = "btnClubInfo";
            this.btnClubInfo.Size = new System.Drawing.Size(174, 50);
            this.btnClubInfo.TabIndex = 5;
            this.btnClubInfo.Text = "Club";
            this.btnClubInfo.UseVisualStyleBackColor = false;
            this.btnClubInfo.Click += new System.EventHandler(this.btnClubInfo_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaculty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.Location = new System.Drawing.Point(0, 110);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(174, 50);
            this.btnFaculty.TabIndex = 1;
            this.btnFaculty.Text = "Faculty";
            this.btnFaculty.UseVisualStyleBackColor = false;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibrary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Location = new System.Drawing.Point(0, 272);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(174, 50);
            this.btnLibrary.TabIndex = 4;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCourseDetails
            // 
            this.btnCourseDetails.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCourseDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourseDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseDetails.Location = new System.Drawing.Point(0, 218);
            this.btnCourseDetails.Name = "btnCourseDetails";
            this.btnCourseDetails.Size = new System.Drawing.Size(174, 50);
            this.btnCourseDetails.TabIndex = 3;
            this.btnCourseDetails.Text = "Course Details";
            this.btnCourseDetails.UseVisualStyleBackColor = false;
            this.btnCourseDetails.Click += new System.EventHandler(this.btnCourseDetails_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucExpenses1);
            this.panel2.Controls.Add(this.ucClubInfo1);
            this.panel2.Controls.Add(this.ucLibraryInfo1);
            this.panel2.Controls.Add(this.ucCourseDetails1);
            this.panel2.Controls.Add(this.ucEmp1);
            this.panel2.Controls.Add(this.ucFaluctyInfo1);
            this.panel2.Controls.Add(this.ucStudentInfo1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 539);
            this.panel2.TabIndex = 1;
            // 
            // ucExpenses1
            // 
            this.ucExpenses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucExpenses1.Location = new System.Drawing.Point(0, 0);
            this.ucExpenses1.Name = "ucExpenses1";
            this.ucExpenses1.Size = new System.Drawing.Size(1020, 539);
            this.ucExpenses1.TabIndex = 7;
            // 
            // ucClubInfo1
            // 
            this.ucClubInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucClubInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucClubInfo1.Name = "ucClubInfo1";
            this.ucClubInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucClubInfo1.TabIndex = 6;
            // 
            // ucLibraryInfo1
            // 
            this.ucLibraryInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLibraryInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucLibraryInfo1.Name = "ucLibraryInfo1";
            this.ucLibraryInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucLibraryInfo1.TabIndex = 5;
            // 
            // ucCourseDetails1
            // 
            this.ucCourseDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCourseDetails1.Location = new System.Drawing.Point(0, 0);
            this.ucCourseDetails1.Name = "ucCourseDetails1";
            this.ucCourseDetails1.Size = new System.Drawing.Size(1020, 539);
            this.ucCourseDetails1.TabIndex = 4;
            // 
            // ucEmp1
            // 
            this.ucEmp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmp1.Location = new System.Drawing.Point(0, 0);
            this.ucEmp1.Name = "ucEmp1";
            this.ucEmp1.Size = new System.Drawing.Size(1020, 539);
            this.ucEmp1.TabIndex = 3;
            // 
            // ucFaluctyInfo1
            // 
            this.ucFaluctyInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFaluctyInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucFaluctyInfo1.Name = "ucFaluctyInfo1";
            this.ucFaluctyInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucFaluctyInfo1.TabIndex = 2;
            // 
            // ucStudentInfo1
            // 
            this.ucStudentInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStudentInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucStudentInfo1.Name = "ucStudentInfo1";
            this.ucStudentInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucStudentInfo1.TabIndex = 1;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel2;
        private ucStudentInfo ucStudentInfo1;
        private ucFaluctyInfo ucFaluctyInfo1;
        private System.Windows.Forms.Button button1;
        private ucEmp ucEmp1;
        private System.Windows.Forms.Button btnCourseDetails;
        private ucCourseDetails ucCourseDetails1;
        private System.Windows.Forms.Button btnLibrary;
        private ucLibraryInfo ucLibraryInfo1;
        private System.Windows.Forms.Button btnClubInfo;
        private ucClubInfo ucClubInfo1;
        private System.Windows.Forms.Button btnExpenses;
        private ucExpenses ucExpenses1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnlogout;
    }
}