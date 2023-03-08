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
    public partial class ucEmp : UserControl
    {
        private DataAccess Da { get; set; }
        public ucEmp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoId();
        }
        private void AutoId()
        {
            var sql = "Select ID from EmpInfo order by ID desc;";
            DataTable dt = this.Da.ExecuteTableQuery(sql);
            string odlId = dt.Rows[0]["ID"].ToString();
            string[] temp = odlId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "e-" + ((++num).ToString("d4"));
            this.txtEID.Text = newId;
        }


        private void ucEmp_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }
        void populateGridView(String sql = "select* from EmpInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvEmpInfo.AutoGenerateColumns = false;
            this.dgvEmpInfo.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
        }
        public void ClearAll()
        {
            this.txtEID.Clear();
            this.txtEname.Clear();
            this.txtEFatherName.Clear();
            this.dtpEDob.Text = "";
            this.dtpEJdate.Text = "";
            this.cmbEGender.SelectedIndex = -1;
            this.cmbEPosition.SelectedIndex = -1;
            this.txtESalery.Clear();
            this.txtEPass.Clear();
            this.txtSearchById.Clear();
            this.AutoId();

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int len = 6;
            const string validchar = "0123456789";
            StringBuilder result = new StringBuilder();
            Random rad = new Random();
            while (0 < len--)
            {
                result.Append(validchar[rad.Next(validchar.Length)]);
            }
            this.txtEPass.Text = result.ToString();
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from EmpInfo where ID Like '" + this.txtSearchById.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbEGender.Text == "<<Select>>" || this.cmbEPosition.Text == "<<Select>>")
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into EmpInfo values('" + this.txtEID.Text + "','" + this.txtEname.Text + "','" + this.txtEFatherName.Text + "','" + this.dtpEDob.Text.ToString() + "','" + this.dtpEJdate.Text.ToString() + "','" + this.cmbEGender.Text + "','" + this.cmbEPosition.Text + "', " + this.txtESalery.Text + ",'" + this.txtEPass.Text + "');";
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
                var id = this.dgvEmpInfo.CurrentRow.Cells["ID"].Value.ToString();
                var sql = "Delete from EmpInfo where ID='" + id + "';";

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

        private void dgvEmpInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtEID.Text = this.dgvEmpInfo.CurrentRow.Cells["ID"].Value.ToString();
            this.txtEname.Text = this.dgvEmpInfo.CurrentRow.Cells["EmpName"].Value.ToString();
            this.txtEFatherName.Text = this.dgvEmpInfo.CurrentRow.Cells["FatherName"].Value.ToString();
            this.dtpEDob.Text = this.dgvEmpInfo.CurrentRow.Cells["BirthDate"].Value.ToString();
            this.dtpEJdate.Text = this.dgvEmpInfo.CurrentRow.Cells["joiningDate"].Value.ToString();
            this.cmbEGender.Text = this.dgvEmpInfo.CurrentRow.Cells["Gender"].Value.ToString();         
            this.cmbEPosition.Text = this.dgvEmpInfo.CurrentRow.Cells["Position"].Value.ToString();
            this.txtESalery.Text = this.dgvEmpInfo.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtEPass.Text = this.dgvEmpInfo.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "Select* from EmpInfo where ID= '" + this.txtEID.Text + "' ;";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = " Update EmpInfo set EmpName='" + this.txtEname.Text + "',FatherName='" + this.txtEFatherName.Text + "',BirthDate='" + this.dtpEDob.Text + "',JoiningDate='" + this.dtpEJdate.Text + "',Gender='" + this.cmbEGender.Text + "',Position='" + this.cmbEPosition.Text + "',Salary='" + this.txtESalery.Text + "',Password='" + this.txtEPass.Text + "' where ID='" + this.txtEID.Text + "';";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
