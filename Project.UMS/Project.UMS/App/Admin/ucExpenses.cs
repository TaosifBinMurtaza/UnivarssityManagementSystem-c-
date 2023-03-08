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
    public partial class ucExpenses : UserControl
    {
        private DataAccess Da { get; set; }
        public ucExpenses()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoId();
        }

        private void ucExpenses_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
        private void AutoId()
        {
            var sql = "Select SerialNo from ExpensesInfo order by SerialNo desc;";
            DataTable dt = this.Da.ExecuteTableQuery(sql);
            String oldId = dt.Rows[0]["SerialNo"].ToString();
            int num = Convert.ToInt32(oldId);
            this.txtSerialNo.Text = (num + 1).ToString();
        }
        void populateGridView(String sql = "select* from ExpensesInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvExpenses.AutoGenerateColumns = false;
            this.dgvExpenses.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
        }
        public void ClearAll()
        {
            this.txtSerialNo.Clear();
            this.txtYear.Clear();
            this.cmbMonth.SelectedIndex=-1;
            this.txtIncome.Clear();
            this.txtExpenditure.Clear();
            this.txtSearchByMonth.Clear();
            this.AutoId();
        }

        private void txtSearchByMonth_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from ExpensesInfo where Month Like '" + this.txtSearchByMonth.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbMonth.Text == "<<Select>>")
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into ExpensesInfo values(" + this.txtSerialNo.Text + "," + this.txtYear.Text + ",'" + this.cmbMonth.Text + "'," + this.txtIncome.Text + "," + this.txtExpenditure.Text + ");";
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
                var  serial= this.dgvExpenses.CurrentRow.Cells["SerialNo"].Value.ToString();
                var sql = "Delete from ExpensesInfo where SerialNo='" + serial + "';";

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

        private void dgvExpenses_DoubleClick(object sender, EventArgs e)
        {
            this.txtSerialNo.Text = this.dgvExpenses.CurrentRow.Cells["SerialNo"].Value.ToString();
            this.txtYear.Text = this.dgvExpenses.CurrentRow.Cells["Year"].Value.ToString();
            this.cmbMonth.Text = this.dgvExpenses.CurrentRow.Cells["Month"].Value.ToString();
            this.txtIncome.Text = this.dgvExpenses.CurrentRow.Cells["Income"].Value.ToString();
            this.txtExpenditure.Text = this.dgvExpenses.CurrentRow.Cells["Expenditure"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "Select* from ExpensesInfo where SerialNo= '" + this.txtSerialNo.Text + "' ;";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = " Update ExpensesInfo set Year=" + this.txtYear.Text + ",Month='" + this.cmbMonth.Text + "',Income='" + this.txtIncome.Text + "',Expenditure=" + this.txtExpenditure.Text + " where SerialNo= "+this.txtSerialNo.Text+"; ";
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
