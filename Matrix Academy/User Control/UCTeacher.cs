using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix_Academy.Forms;

namespace Matrix_Academy.User_Control
{
    public partial class UCTeacher : UserControl
    {
        public UCTeacher()
        {
            InitializeComponent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FormAddTeacher addT = new FormAddTeacher();
            addT.Show();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher obj = new FormTeacher();
            obj.btnSubmit.Visible = true;
            obj.lblTitle.Text = "Update";
            obj.Show();

        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher obj = new FormTeacher();
            obj.btnDelete.Visible = true;
            obj.lblTitle.Text = "Delete";
            obj.Show();

        }
    }
}
