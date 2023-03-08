using Project.UMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UMS.App.Admin
{
    public partial class ucClubInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public ucClubInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ucClubInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
        void populateGridView(String sql = "select* from ClubInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvClubInfo.AutoGenerateColumns = false;
            this.dgvClubInfo.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
        }
        public void ClearAll()
        {
            this.txtClubName.Clear();
            this.txtPresidentName.Clear();
            this.txtClubRoom.Clear();
            this.dtpClub.Text = "";
            this.txtSearchByName.Clear();

        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from ClubInfo where ClubName Like '" + this.txtSearchByName.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveData())
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into ClubInfo values('" + this.txtClubName.Text + "','" + this.txtPresidentName.Text + "','" + this.dtpClub.Text + "','" + this.txtClubRoom.Text + "');";
                this.Da.ExecuteDMLQuery(sql);
                MessageBox.Show("Data insesation successful");
                this.populateGridView();
                this.ClearAll();
            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var name = this.dgvClubInfo.CurrentRow.Cells["ClubName"].Value.ToString();
                var sql = "Delete from ClubInfo where ClubName='" + name + "';";

                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Delete Successful");
                    this.populateGridView();
                    this.ClearAll();
                }
                else
                    MessageBox.Show("Data deleted Failed");
            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }

        private void dgvClubInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtClubName.Text = this.dgvClubInfo.CurrentRow.Cells["ClubName"].Value.ToString();
            this.txtPresidentName.Text = this.dgvClubInfo.CurrentRow.Cells["ClubPresident"].Value.ToString();
            this.dtpClub.Text = this.dgvClubInfo.CurrentRow.Cells["Establishment"].Value.ToString();
            this.txtClubRoom.Text = this.dgvClubInfo.CurrentRow.Cells["RoomNo"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "Select* from ClubInfo where ClubName= '" + this.txtClubName.Text + "' ;";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = " Update ClubInfo set ClubPresident='" + this.txtPresidentName.Text + "',Establishment='" + this.dtpClub.Text.ToString() + "',RoomNo='" + this.txtClubRoom.Text + "' where ClubName='" + this.txtClubName.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Update Successful");
                        this.populateGridView();
                        this.ClearAll();
                    }
                    else
                        MessageBox.Show("Failed");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtClubName.Text) || String.IsNullOrEmpty(this.txtClubRoom.Text) ||
                String.IsNullOrEmpty(this.txtPresidentName.Text))
            {
                return true;
            }
            else
                return false;


        }
    }
}
