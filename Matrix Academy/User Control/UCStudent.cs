using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix_Academy.Connection;
using Matrix_Academy.Forms;

namespace Matrix_Academy.User_Control
{
    public partial class UCStudent : UserControl
    {
        public UCStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            s fas = new s();
            fas.Show();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.lblTitle.Text = "Update";
            fs.btnSubmit.Visible = true;
            fs.Show();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.lblTitle.Text = "Delete";
            fs.btnDelete.Visible = true;
            fs.Show();
        }
    }
}
