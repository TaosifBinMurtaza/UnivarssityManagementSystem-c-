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

namespace Project.UMS.App.Faculty
{
    public partial class ucAddResult : UserControl
    {
        private DataAccess Da { get; set; }
        public ucAddResult()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        void populateGridView(String sql = "select* from ResultInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvAddResult.AutoGenerateColumns = false;
            this.dgvAddResult.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveData() || this.cmbResult.Text == "<<Select>>" || this.cmbSemister.Text == "<<Select>>" )
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into ResultInfo values('" + this.txtStudentID.Text + "','" + this.txtCourseName.Text + "','" + this.cmbResult.Text + "','" + this.cmbResult.Text + "','" + this.txtYear.Text + "');";
                this.Da.ExecuteDMLQuery(sql);
                MessageBox.Show("Successful");
                this.populateGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.txtCourseName.Clear();
            this.txtStudentID.Clear();
            this.txtYear.Clear();
            this.txtSearchByID.Clear();
            this.cmbResult.SelectedIndex = -1;
            this.cmbSemister.SelectedIndex = -1;
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from ResultInfo where StudentID Like '" + this.txtSearchByID.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvAddResult.CurrentRow.Cells["StudentID"].Value.ToString();
                var cname= this.dgvAddResult.CurrentRow.Cells["CourseName"].Value.ToString();
                var sql = "Delete from ResultInfo where StudentID='" + id + "'and CourseName='"+cname+"';";

                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Delete Successful");
                    this.populateGridView();
                }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtCourseName.Text) || String.IsNullOrEmpty(this.txtStudentID.Text))
            {
                return true;
            }
            else
                return false;
        }
    }
}
