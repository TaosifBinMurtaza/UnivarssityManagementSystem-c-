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

namespace Project.UMS.App
{
    public partial class ucViewCourseInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public ucViewCourseInfo()
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

        private void ucViewCourseInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        private void txtSearchByDep_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from CourseInfo where Department Like ' "+this.txtSearchByDep.Text +" %'; ";
            this.populateGridView(sql);
        }

        private void txtSearchbyname_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from CourseInfo where CourseName Like ' " + this.txtSearchbyname.Text + " %'; ";
            this.populateGridView(sql);
        }

        private void txtsearchbyCourseId_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from CourseInfo where CourseID Like ' " + this.txtsearchbyCourseId.Text + " %'; ";
            this.populateGridView(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.txtsearchbyCourseId.Clear();
            this.txtSearchByDep.Clear();
            this.txtSearchbyname.Clear();
        }
    }
}
