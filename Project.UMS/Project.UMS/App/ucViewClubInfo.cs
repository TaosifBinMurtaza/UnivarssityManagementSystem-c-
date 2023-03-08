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
    public partial class ucViewClubInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public ucViewClubInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ucViewClubInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
        void populateGridView(String sql = "select* from ClubInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvViewClub.AutoGenerateColumns = false;
            this.dgvViewClub.DataSource = ds.Tables[0];
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from ClubInfo where ClubName Like '" + this.txtSearchByName.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.txtSearchByName.Clear();
        }
    }
}
