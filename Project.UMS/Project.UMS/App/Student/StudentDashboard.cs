using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UMS.App.Student
{
    public partial class StudentDashboard : Form
    {
        private LogIn F1 { get; set; }
        public StudentDashboard()
        {
            InitializeComponent();
        }
        public StudentDashboard(LogIn f1,String info)
        {
            InitializeComponent();
            this.F1 = f1;
            this.label1.Text = info;
        }
        public void SetActivePanelAdmin(UserControl control)
        {
            ucViewClubInfo1.Visible = false;
            ucViewCourseInfo1.Visible = false;
            ucViewLibraryInfo1.Visible = false;
            control.Visible = true;

        }

        private void btnViewLibraryInfo_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucViewLibraryInfo1);
        }

        private void btnViewCourseInfo_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucViewCourseInfo1);
        }

        private void btnViewClubInfo_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucViewClubInfo1);
        }

        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
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
