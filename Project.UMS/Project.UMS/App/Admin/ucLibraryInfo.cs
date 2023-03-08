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
    public partial class ucLibraryInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public ucLibraryInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoId();
        }

        private void ucLibraryInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
        private void AutoId()
        {
            var sql = "Select BookID from BookInfo order by BookID desc;";
            DataTable dt = this.Da.ExecuteTableQuery(sql);
            String oldId = dt.Rows[0]["BookID"].ToString();
            int num = Convert.ToInt32(oldId);
            this.txtBookId.Text =(num+1).ToString();
        }
        void populateGridView(String sql = "select* from BookInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvLibraryInfo.AutoGenerateColumns = false;
            this.dgvLibraryInfo.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
        }
        public void ClearAll()
        {
            this.txtBookId.Clear();
            this.txtBookName.Clear();
            this.txtAutherName.Clear();
            this.txtbookCopies.Clear();
            this.dtpBook.Text = "";
            this.txtBookself.Clear();
            this.txtSearchByName.Clear();
            this.AutoId();
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from BookInfo where BookName Like '" + this.txtSearchByName.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "insert into BookInfo values(" + this.txtBookId.Text + ",'" + this.txtBookName.Text + "','" + this.txtAutherName.Text + "',"+this.txtbookCopies.Text+",'"+this.dtpBook.Text +"','"+this.txtBookself.Text+"');";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvLibraryInfo.CurrentRow.Cells["BookID"].Value.ToString();
                var sql = "Delete from BookInfo where BookID='" + id + "';";

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

        private void dgvLibraryInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtBookId.Text = this.dgvLibraryInfo.CurrentRow.Cells["BookID"].Value.ToString();
            this.txtBookName.Text = this.dgvLibraryInfo.CurrentRow.Cells["BookName"].Value.ToString();
            this.txtAutherName.Text = this.dgvLibraryInfo.CurrentRow.Cells["AutherName"].Value.ToString();
            this.txtbookCopies.Text= this.dgvLibraryInfo.CurrentRow.Cells["Copies"].Value.ToString();
            this.dtpBook.Text= this.dgvLibraryInfo.CurrentRow.Cells["Date"].Value.ToString();
            this.txtBookself.Text= this.dgvLibraryInfo.CurrentRow.Cells["Bookself"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "Select* from BookInfo where BookID= '" + this.txtBookId.Text + "' ;";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = " Update BookInfo set BookName='" + this.txtBookName.Text + "',AutherName='" + this.txtAutherName.Text + "',Date='" + this.dtpBook.Text.ToString() + "',Copies="+this.txtbookCopies.Text+",Bookself='"+this.txtBookself.Text+"' where BookID='" + this.txtBookId.Text + "';";
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
    }
}
