using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Academy.Forms
{
    public partial class FormDashBoard : Form
    {
        public FormDashBoard()
        {
            InitializeComponent();
            this.lblName.Text = Utility.UserName;
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (Utility.isLoginVisible)
            {
                this.Visible = !Utility.isLoginVisible;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            HideUC();
            ucDashBoard.Show();
            lblTitle.Text = "DashBoard";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            HideUC();
            ucPayment.Show();
            lblTitle.Text = "Payment";
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            HideUC();
            lblTitle.Text = "Teacher";
            ucTeacher.Show();
        }

        private void btnStudnent_Click(object sender, EventArgs e)
        {
            HideUC();
            lblTitle.Text = "Student";
            ucStudent.Show();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            HideUC();
            ucAttendence.Show();
            lblTitle.Text = "Attendence";
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Exam";
        }

        private void btnSetUp_Click(object sender, EventArgs e)
        {
            HideUC();
            ucSetUp.Show();
            lblTitle.Text = "SetUp";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideUC();
            lblTitle.Text = "Settings";
            ucSettings.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HideUC();
            lblTitle.Text = "LogOut??";
            ucLogOut.Show();
        }
        private void HideUC()
        {
            ucSetUp.Hide();
            ucDashBoard.Hide();
            ucPayment.Hide();
            ucTeacher.Hide();
            ucStudent.Hide();
            ucAttendence.Hide();
            ucSettings.Hide();
            ucLogOut.Hide();
        }

        private void FormDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
