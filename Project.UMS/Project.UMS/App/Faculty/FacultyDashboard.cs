using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UMS.App.Faculty
{
    public partial class FacultyDashboard : Form
    {
        private LogIn F1 { get; set; }
        public FacultyDashboard()
        {
            InitializeComponent();
        }
        public FacultyDashboard(LogIn f1, String info)
        {
            InitializeComponent();
            this.F1 = f1;
            this.lblInfo.Text = info;
        }
        public void SetActivePanelAdmin(UserControl control)
        {
            ucAddResult1.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SetActivePanelAdmin(ucAddResult1);
        }

        private void FacultyDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }
    }
}
