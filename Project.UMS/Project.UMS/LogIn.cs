using Project.UMS.App.Admin;
using Project.UMS.App.Faculty;
using Project.UMS.App.Student;
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

namespace Project.UMS
{
    public partial class LogIn : Form
    {
        private DataAccess Da { get; set; }
        public LogIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = this.txtLoginID.Text;
            if (id.Contains("e"))
            {
                try
                {
                    string sql = "Select* from EmpInfo where ID='" + this.txtLoginID.Text + "'and Password='" + this.txtloginPass.Text + "'and Position='Admin';";
                    var ds = this.Da.ExecuteQuery(sql);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        string info = this.txtLoginID.Text;
                        AdminDashboard st = new AdminDashboard(this, info);
                        st.Show();
                        this.Hide();
                        //new AdminDashboard().Show();                
                    }
                    else
                        MessageBox.Show("Incorrect Information!!Please,provide correct information");
                }
                catch (Exception)
                {
                    MessageBox.Show("You must provide All Information");
                }
            }

            else if (id.Contains("f"))
            {
                try
                {
                    string sql = "Select* from FacultyInfo where ID='" + this.txtLoginID.Text + "'and Password='" + this.txtloginPass.Text + "';";
                    var ds = this.Da.ExecuteQuery(sql);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        string info = this.txtLoginID.Text;
                        FacultyDashboard ft = new FacultyDashboard(this, info);
                        ft.Show();
                        this.Hide();
                        //new FacultyDashboard().Show();
                    }
                    else
                        MessageBox.Show("Incorrect Information!!Please,provide correct information");
                }
                catch (Exception)
                {
                    MessageBox.Show("You must provide All Information");
                }
            }
            else if (id.Contains("s"))
            {
                try
                {
                    string sql = "Select* from StudentInfo where ID='" + this.txtLoginID.Text + "'and Password='" + this.txtloginPass.Text + "';";
                    var ds = this.Da.ExecuteQuery(sql);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        string info = this.txtLoginID.Text;
                        StudentDashboard st = new StudentDashboard(this, info);
                        st.Show();
                        this.Hide();
                        //this.Hide();
                        //new StudentDashboard().Show();
                    }
                    else
                        MessageBox.Show("Incorrect Information!!Please,provide correct information");
                }
                catch (Exception)
                {
                    MessageBox.Show("You must provide All Information");
                }
            }
            else
                MessageBox.Show("You must provide All Information");
            this.txtLoginID.Clear();
            this.txtloginPass.Clear();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtLoginID.Clear();
            this.txtloginPass.Clear();

        }
    }
}
