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
    public partial class ucViewLibraryInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public ucViewLibraryInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ucViewLibraryInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
        void populateGridView(String sql = "select* from BookInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvLibraryInfo.AutoGenerateColumns = false;
            this.dgvLibraryInfo.DataSource = ds.Tables[0];
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from BookInfo where BookName Like '" + this.txtSearchByName.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.txtSearchByName.Clear();
            this.txtsearchByAutherName.Clear();
        }

        private void txtsearchByAutherName_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from BookInfo where AutherName Like '" + this.txtsearchByAutherName.Text + "%'; ";
            this.populateGridView(sql);
        }
    }
}
