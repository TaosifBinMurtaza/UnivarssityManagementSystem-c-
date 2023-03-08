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
    public partial class ucStudentInfo : UserControl
    {       
        private DataAccess Da { get; set; }
        public ucStudentInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoId();
        }
        void populateGridView(String sql="select* from StudentInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvStudentInfo.AutoGenerateColumns = false;
            this.dgvStudentInfo.DataSource = ds.Tables[0];       
         }

        private void ucStudentInfo_Load(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.populateGridView();
            this.ClearAll();
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
            txtSPass.Text = result.ToString();
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            var sql = " Select* from StudentInfo where ID Like '" +this.txtSearchById.Text+"%'; ";
            this.populateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveData() || this.cmbGender.Text=="<<Select>>"||this.cmbSDepartment.Text=="<<Select>>" || this.cmbSProgram.Text == "<<Select>>")
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var sql = "insert into StudentInfo values('"+this.txtID.Text+"','"+this.txtSname.Text+"','"+this.txtSFatherName.Text+"','"+this.txtSMotherName.Text+"','"+this.cmbGender.Text+"','"+this.dtpSDob.Text.ToString()+"','"+this.cmbSProgram.Text+"','"+this.cmbSDepartment.Text+"','"+this.txtSPass.Text+"');";
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
        public void ClearAll()
        {
            this.txtID.Clear();
            this.txtSname.Clear();
            this.txtSFatherName.Clear();
            this.txtSMotherName.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.dtpSDob.Text = "";
            this.cmbSDepartment.SelectedIndex = -1;
            this.cmbSProgram.SelectedIndex = -1;
            this.txtSPass.Clear();
            this.txtSearchById.Clear();
            this.AutoId();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvStudentInfo.CurrentRow.Cells["ID"].Value.ToString();
                var sql = "Delete from StudentInfo where ID='" + id + "';";

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

        private void dgvStudentInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudentInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text= this.dgvStudentInfo.CurrentRow.Cells["ID"].Value.ToString();
            this.txtSname.Text= this.dgvStudentInfo.CurrentRow.Cells["StudentName"].Value.ToString();
            this.txtSFatherName.Text = this.dgvStudentInfo.CurrentRow.Cells["FatherName"].Value.ToString();
            this.txtSMotherName.Text = this.dgvStudentInfo.CurrentRow.Cells["MotherName"].Value.ToString();
            this.cmbGender.Text = this.dgvStudentInfo.CurrentRow.Cells["Gender"].Value.ToString();
            this.dtpSDob.Text = this.dgvStudentInfo.CurrentRow.Cells["BirthDate"].Value.ToString();
            this.cmbSDepartment.Text = this.dgvStudentInfo.CurrentRow.Cells["Department"].Value.ToString();
            this.cmbSProgram.Text = this.dgvStudentInfo.CurrentRow.Cells["Program"].Value.ToString();
            this.txtSPass.Text = this.dgvStudentInfo.CurrentRow.Cells["Password"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveData())
                {
                    MessageBox.Show("You must provide All Information");
                    return;
                }
                var query = "Select* from StudentInfo where ID= '"+this.txtID.Text+"' ;";
                var ds=this.Da.ExecuteQuery(query);
                if(ds.Tables[0].Rows.Count==1)
                {
                    var sql = " Update StudentInfo set StudentName='"+this.txtSname.Text+"',FatherName='"+this.txtSFatherName.Text+"',MotherName='"+this.txtSMotherName.Text+"',Gender='"+this.cmbGender.Text+"',BirthDate='"+this.dtpSDob.Text+"',Program='"+this.cmbSProgram.Text+"',Department='"+this.cmbSDepartment.Text+"' where ID='"+this.txtID.Text+"';";
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
        private void AutoId()
        {
            var sql = "Select ID from StudentInfo order by ID desc;";
            DataTable dt = this.Da.ExecuteTableQuery(sql);
            string odlId = dt.Rows[0]["ID"].ToString();
            string[] temp = odlId.Split('-');
            int num = Convert.ToInt32(temp[1]);
            string newId = "s-" +((++num).ToString("d5"));
            this.txtID.Text = newId;
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtSname.Text) ||
                String.IsNullOrEmpty(this.txtSFatherName.Text) || String.IsNullOrEmpty(this.txtSMotherName.Text) ||
                String.IsNullOrEmpty(this.cmbGender.Text) || String.IsNullOrEmpty(this.cmbSProgram.Text) || String.IsNullOrEmpty(this.txtSPass.Text)|| String.IsNullOrEmpty(this.cmbSProgram.Text))
            {
                return true;
            }
            else
                return false;
        }

    }
}
