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
    public partial class ucFaluctyInfo : UserControl
    {
        private DataAccess Da { get; set; }
        public ucFaluctyInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoId();
        }
        private void AutoId()
        {
            var sql = "Select ID from FacultyInfo order by ID desc;";
            DataTable dt = this.Da.ExecuteTableQuery(sql);
            string odlId = dt.Rows[0]["ID"].ToString();
            string[] temp = odlId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "f-" + ((++num).ToString("d4"));
            this.txtFID.Text = newId;
        }

        private void ucFaluctyInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void populateGridView(String sql = "select* from FacultyInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvFacultyInfo.AutoGenerateColumns = false;
            this.dgvFacultyInfo.DataSource = ds.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
        }
        public void ClearAll()
        {
            this.txtFID.Clear();
            this.txtFname.Clear();
            this.txtFFatherName.Clear();
            this.dtpFDob.Text = "";
            this.dtpFJdate.Text = "";
            this.cmbFDepartment.SelectedIndex = -1;
            this.cmbFGender.SelectedIndex = -1;
            this.cmbFPosition.SelectedIndex = -1;
            this.txtFSalery.Clear();
            this.txtFPass.Clear();
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
            txtFPass.Text = result.ToString();
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from FacultyInfo where ID Like '" + this.txtSearchById.Text + "%'; ";
            this.populateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbFDepartment.Text == "<<Select>>" || this.cmbFGender.Text == "<<Select>>" || this.cmbFPosition.Text == "<<Select>>")
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into FacultyInfo values('" + this.txtFID.Text + "','" + this.txtFname.Text + "','" + this.txtFFatherName.Text + "','" + this.dtpFDob.Text.ToString() + "','" + this.dtpFJdate.Text.ToString() + "','" + this.cmbFGender.Text + "','" + this.cmbFDepartment.Text + "','" + this.cmbFPosition.Text + "', "+ this.txtFSalery.Text + ",'"+this.txtFPass.Text +"');";
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
                var id = this.dgvFacultyInfo.CurrentRow.Cells["ID"].Value.ToString();
                var sql = "Delete from FacultyInfo where ID='" + id + "';";

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

        private void dgvFacultyInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtFID.Text= this.dgvFacultyInfo.CurrentRow.Cells["ID"].Value.ToString();
            this.txtFname.Text= this.dgvFacultyInfo.CurrentRow.Cells["FacultyName"].Value.ToString();
            this.txtFFatherName.Text= this.dgvFacultyInfo.CurrentRow.Cells["FatherName"].Value.ToString();
            this.dtpFDob.Text= this.dgvFacultyInfo.CurrentRow.Cells["BirthDate"].Value.ToString();
            this.dtpFJdate.Text= this.dgvFacultyInfo.CurrentRow.Cells["joiningDate"].Value.ToString();
            this.cmbFGender.Text= this.dgvFacultyInfo.CurrentRow.Cells["Gender"].Value.ToString();
            this.cmbFDepartment.Text= this.dgvFacultyInfo.CurrentRow.Cells["Department"].Value.ToString();
            this.cmbFPosition.Text= this.dgvFacultyInfo.CurrentRow.Cells["Position"].Value.ToString();
            this.txtFSalery.Text= this.dgvFacultyInfo.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtFPass.Text= this.dgvFacultyInfo.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "Select* from FacultyInfo where ID= '" + this.txtFID.Text + "' ;";
                var ds = this.Da.ExecuteQuery(query);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = " Update facultyInfo set FacultyName='" + this.txtFname.Text + "',FatherName='" + this.txtFFatherName.Text + "',BirthDate='" + this.dtpFDob.Text + "',JoiningDate='" + this.dtpFJdate.Text + "',Gender='" + this.cmbFGender.Text + "',Department='" + this.cmbFDepartment.Text + "',Position='" + this.cmbFPosition.Text + "',Salary='"+this.txtFSalery.Text+"',Password='"+this.txtFPass.Text+"' where ID='" + this.txtFID.Text + "';";
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
