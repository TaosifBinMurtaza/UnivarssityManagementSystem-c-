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
    public partial class AdminDashboard : Form
    {
        private LogIn F1 { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
        }
        public AdminDashboard(LogIn f1, String info)
        {
            InitializeComponent();
            this.F1 = f1;
            this.lblInfo.Text = info;
            
        }
        public void SetActivePanelAdmin(UserControl control)
        {
            ucStudentInfo1.Visible = false;
            ucFaluctyInfo1.Visible = false;
            ucEmp1.Visible = false;
            ucCourseDetails1.Visible = false;
            ucLibraryInfo1.Visible = false;
            ucClubInfo1.Visible = false;
            ucExpenses1.Visible = false;
            control.Visible = true;

        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucStudentInfo1);
        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucStudentInfo1);
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucFaluctyInfo1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucEmp1);
        }

        private void btnCourseDetails_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucCourseDetails1);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucLibraryInfo1);
        }

        private void btnClubInfo_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucClubInfo1);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucExpenses1);
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }
    }
}
