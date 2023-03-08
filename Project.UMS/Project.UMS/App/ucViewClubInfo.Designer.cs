
namespace Project.UMS.App
{
    partial class ucViewClubInfo
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
            this.dgvViewClub = new System.Windows.Forms.DataGridView();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubPresident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Establishment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClub)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvViewClub);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 334);
            this.panel1.TabIndex = 0;
            // 
            // dgvViewClub
            // 
            this.dgvViewClub.AllowUserToAddRows = false;
            this.dgvViewClub.AllowUserToDeleteRows = false;
            this.dgvViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClubName,
            this.ClubPresident,
            this.Establishment,
            this.RoomNo});
            this.dgvViewClub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewClub.Location = new System.Drawing.Point(0, 0);
            this.dgvViewClub.Name = "dgvViewClub";
            this.dgvViewClub.ReadOnly = true;
            this.dgvViewClub.RowHeadersWidth = 51;
            this.dgvViewClub.RowTemplate.Height = 24;
            this.dgvViewClub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewClub.Size = new System.Drawing.Size(1020, 334);
            this.dgvViewClub.TabIndex = 1;
            // 
            // ClubName
            // 
            this.ClubName.DataPropertyName = "ClubName";
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.MinimumWidth = 6;
            this.ClubName.Name = "ClubName";
            this.ClubName.ReadOnly = true;
            this.ClubName.Width = 125;
            // 
            // ClubPresident
            // 
            this.ClubPresident.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClubPresident.DataPropertyName = "ClubPresident";
            this.ClubPresident.HeaderText = "Club President";
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
            this.RoomNo.HeaderText = "Room No";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.txtSearchByName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 205);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 133;
            this.label1.Text = "By Club Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Club Information";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.BackgroundImage = global::Project.UMS.Properties.Resources.icons8_refresh_30px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(917, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(338, 155);
            this.txtSearchByName.Multiline = true;
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(317, 32);
            this.txtSearchByName.TabIndex = 4;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // ucViewClubInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucViewClubInfo";
            this.Size = new System.Drawing.Size(1020, 539);
            this.Load += new System.EventHandler(this.ucViewClubInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewClub)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvViewClub;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubPresident;
        private System.Windows.Forms.DataGridViewTextBoxColumn Establishment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
