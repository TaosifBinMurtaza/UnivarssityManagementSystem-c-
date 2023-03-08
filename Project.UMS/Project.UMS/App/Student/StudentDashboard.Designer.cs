
namespace Project.UMS.App.Student
{
    partial class StudentDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewClubInfo = new System.Windows.Forms.Button();
            this.btnViewLibraryInfo = new System.Windows.Forms.Button();
            this.btnViewCourseInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucViewLibraryInfo1 = new Project.UMS.App.ucViewLibraryInfo();
            this.ucViewCourseInfo1 = new Project.UMS.App.ucViewCourseInfo();
            this.ucViewClubInfo1 = new Project.UMS.App.ucViewClubInfo();
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
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnViewClubInfo);
            this.panel3.Controls.Add(this.btnViewLibraryInfo);
            this.panel3.Controls.Add(this.btnViewCourseInfo);
            this.panel3.Location = new System.Drawing.Point(14, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 422);
            this.panel3.TabIndex = 3;
            // 
            // btnlogout
            // 
            this.btnlogout.BackgroundImage = global::Project.UMS.Properties.Resources.icons8_logout_rounded_left_64px;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Location = new System.Drawing.Point(47, 358);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(67, 51);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // btnViewClubInfo
            // 
            this.btnViewClubInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViewClubInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnViewClubInfo.Location = new System.Drawing.Point(0, 224);
            this.btnViewClubInfo.Name = "btnViewClubInfo";
            this.btnViewClubInfo.Size = new System.Drawing.Size(174, 50);
            this.btnViewClubInfo.TabIndex = 5;
            this.btnViewClubInfo.Text = "Club Info";
            this.btnViewClubInfo.UseVisualStyleBackColor = false;
            this.btnViewClubInfo.Click += new System.EventHandler(this.btnViewClubInfo_Click);
            // 
            // btnViewLibraryInfo
            // 
            this.btnViewLibraryInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViewLibraryInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnViewLibraryInfo.Location = new System.Drawing.Point(0, 110);
            this.btnViewLibraryInfo.Name = "btnViewLibraryInfo";
            this.btnViewLibraryInfo.Size = new System.Drawing.Size(174, 50);
            this.btnViewLibraryInfo.TabIndex = 3;
            this.btnViewLibraryInfo.Text = "Book Info";
            this.btnViewLibraryInfo.UseVisualStyleBackColor = false;
            this.btnViewLibraryInfo.Click += new System.EventHandler(this.btnViewLibraryInfo_Click);
            // 
            // btnViewCourseInfo
            // 
            this.btnViewCourseInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViewCourseInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnViewCourseInfo.Location = new System.Drawing.Point(0, 167);
            this.btnViewCourseInfo.Name = "btnViewCourseInfo";
            this.btnViewCourseInfo.Size = new System.Drawing.Size(174, 50);
            this.btnViewCourseInfo.TabIndex = 4;
            this.btnViewCourseInfo.Text = "Course Info";
            this.btnViewCourseInfo.UseVisualStyleBackColor = false;
            this.btnViewCourseInfo.Click += new System.EventHandler(this.btnViewCourseInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucViewLibraryInfo1);
            this.panel2.Controls.Add(this.ucViewCourseInfo1);
            this.panel2.Controls.Add(this.ucViewClubInfo1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 539);
            this.panel2.TabIndex = 1;
            // 
            // ucViewLibraryInfo1
            // 
            this.ucViewLibraryInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewLibraryInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucViewLibraryInfo1.Name = "ucViewLibraryInfo1";
            this.ucViewLibraryInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucViewLibraryInfo1.TabIndex = 2;
            // 
            // ucViewCourseInfo1
            // 
            this.ucViewCourseInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewCourseInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucViewCourseInfo1.Name = "ucViewCourseInfo1";
            this.ucViewCourseInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucViewCourseInfo1.TabIndex = 1;
            // 
            // ucViewClubInfo1
            // 
            this.ucViewClubInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewClubInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucViewClubInfo1.Name = "ucViewClubInfo1";
            this.ucViewClubInfo1.Size = new System.Drawing.Size(1020, 539);
            this.ucViewClubInfo1.TabIndex = 0;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentDashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewClubInfo;
        private System.Windows.Forms.Button btnViewCourseInfo;
        private System.Windows.Forms.Button btnViewLibraryInfo;
        private ucViewLibraryInfo ucViewLibraryInfo1;
        private ucViewCourseInfo ucViewCourseInfo1;
        private ucViewClubInfo ucViewClubInfo1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
    }
}