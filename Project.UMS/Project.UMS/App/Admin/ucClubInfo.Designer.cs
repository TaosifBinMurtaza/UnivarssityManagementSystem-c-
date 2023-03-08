
namespace Project.UMS.App.Admin
{
    partial class ucClubInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.dtpClub = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClubRoom = new System.Windows.Forms.TextBox();
            this.txtPresidentName = new System.Windows.Forms.TextBox();
            this.txtClubName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClubInfo = new System.Windows.Forms.DataGridView();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubPresident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establishment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSearchByName);
            this.panel1.Controls.Add(this.dtpClub);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtClubRoom);
            this.panel1.Controls.Add(this.txtPresidentName);
            this.panel1.Controls.Add(this.txtClubName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 310);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 131;
            this.label4.Text = "By Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.UMS.Properties.Resources.icons8_search_40px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.BackgroundImage = global::Project.UMS.Properties.Resources.icons8_refresh_30px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(943, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 53);
            this.btnRefresh.TabIndex = 129;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Project.UMS.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(942, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 128;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(698, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 39);
            this.btnUpdate.TabIndex = 127;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(511, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 39);
            this.btnSave.TabIndex = 126;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(45, 273);
            this.txtSearchByName.Multiline = true;
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(276, 31);
            this.txtSearchByName.TabIndex = 125;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // dtpClub
            // 
            this.dtpClub.CustomFormat = "yyyy-MM-dd";
            this.dtpClub.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClub.Location = new System.Drawing.Point(399, 151);
            this.dtpClub.Name = "dtpClub";
            this.dtpClub.Size = new System.Drawing.Size(186, 22);
            this.dtpClub.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 123;
            this.label5.Text = "Date";
            // 
            // txtClubRoom
            // 
            this.txtClubRoom.Location = new System.Drawing.Point(399, 197);
            this.txtClubRoom.Name = "txtClubRoom";
            this.txtClubRoom.Size = new System.Drawing.Size(186, 22);
            this.txtClubRoom.TabIndex = 120;
            // 
            // txtPresidentName
            // 
            this.txtPresidentName.Location = new System.Drawing.Point(399, 107);
            this.txtPresidentName.Name = "txtPresidentName";
            this.txtPresidentName.Size = new System.Drawing.Size(314, 22);
            this.txtPresidentName.TabIndex = 119;
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(399, 71);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(314, 22);
            this.txtClubName.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 113;
            this.label3.Text = "Room No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "Club President name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "Club Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 29);
            this.label10.TabIndex = 110;
            this.label10.Text = "Add Club Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvClubInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 229);
            this.panel2.TabIndex = 1;
            // 
            // dgvClubInfo
            // 
            this.dgvClubInfo.AllowUserToAddRows = false;
            this.dgvClubInfo.AllowUserToDeleteRows = false;
            this.dgvClubInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClubInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClubName,
            this.ClubPresident,
            this.Establishment,
            this.RoomNo});
            this.dgvClubInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClubInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvClubInfo.Name = "dgvClubInfo";
            this.dgvClubInfo.ReadOnly = true;
            this.dgvClubInfo.RowHeadersWidth = 51;
            this.dgvClubInfo.RowTemplate.Height = 24;
            this.dgvClubInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClubInfo.Size = new System.Drawing.Size(1020, 229);
            this.dgvClubInfo.TabIndex = 0;
            this.dgvClubInfo.DoubleClick += new System.EventHandler(this.dgvClubInfo_DoubleClick);
            // 
            // ClubName
            // 
            this.ClubName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClubName.DataPropertyName = "ClubName";
            this.ClubName.HeaderText = "ClubName";
            this.ClubName.MinimumWidth = 6;
            this.ClubName.Name = "ClubName";
            this.ClubName.ReadOnly = true;
            // 
            // ClubPresident
            // 
            this.ClubPresident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClubPresident.DataPropertyName = "ClubPresident";
            this.ClubPresident.HeaderText = "ClubPresident";
            this.ClubPresident.MinimumWidth = 6;
            this.ClubPresident.Name = "ClubPresident";
            this.ClubPresident.ReadOnly = true;
            // 
            // Establishment
            // 
            this.Establishment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Establishment.DataPropertyName = "Establishment";
            this.Establishment.HeaderText = "Establishment Date";
            this.Establishment.MinimumWidth = 6;
            this.Establishment.Name = "Establishment";
            this.Establishment.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // ucClubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucClubInfo";
            this.Size = new System.Drawing.Size(1020, 539);
            this.Load += new System.EventHandler(this.ucClubInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClubInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtClubRoom;
        private System.Windows.Forms.TextBox txtPresidentName;
        private System.Windows.Forms.TextBox txtClubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvClubInfo;
        private System.Windows.Forms.DateTimePicker dtpClub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubPresident;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establishment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}
