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
    public partial class ucCourseDetails : UserControl
    {
        private DataAccess Da { get; set; }
        public ucCourseDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           
        }
        
        void populateGridView(String sql = "select* from CourseInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvCourseInfo.AutoGenerateColumns = false;
            this.dgvCourseInfo.DataSource = ds.Tables[0];
        }

        private void ucCourseDetails_Load_1(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
        }
        public void ClearAll()
        {
            this.txtCourseID.Clear();
            this.txtCourseName.Clear();
            this.txtSearchById.Clear();
            this.cmbCourseDep.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveData() || this.cmbCourseDep.Text == "<<Select>>")
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into CourseInfo values('"+this.txtCourseID.Text+"','"+this.txtCourseName.Text+"','"+this.cmbCourseDep.Text+"');";
                this.Da.ExecuteDMLQuery(sql);
                MessageBox.Show("Successful");
                this.populateGridView();
                this.ClearAll();
            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from CourseInfo where CourseID Like '" + this.txtSearchById.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvCourseInfo.CurrentRow.Cells["CourseID"].Value.ToString();
                var sql = "Delete from CourseInfo where CourseID='" + id + "';";

                int count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("Delete Successful");
                    this.populateGridView();
                    this.ClearAll();
                }
                else
                    MessageBox.Show("Failed");
            }
            catch (Exception)
            {
                MessageBox.Show("You must provide All Information");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "Select* from CourseInfo where CourseID= '" + this.txtCourseID.Text + "' ;";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = " Update CourseInfo set CourseName='" + this.txtCourseName.Text + "',Department='" + this.cmbCourseDep.Text + "' where CourseID='" + this.txtCourseID.Text + "';";
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

        private void dgvCourseInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtCourseID.Text = this.dgvCourseInfo.CurrentRow.Cells["CourseID"].Value.ToString();
            this.txtCourseName.Text = this.dgvCourseInfo.CurrentRow.Cells["CourseName"].Value.ToString();          
            this.cmbCourseDep.Text = this.dgvCourseInfo.CurrentRow.Cells["Department"].Value.ToString();
        
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtCourseID.Text) || String.IsNullOrEmpty(this.txtCourseName.Text) )
            {
                return true;
            }
            else
                return false;
        }
    }
}
