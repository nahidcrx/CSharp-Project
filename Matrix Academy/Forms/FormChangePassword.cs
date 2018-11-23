using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matrix_Academy.Connection;

namespace Matrix_Academy.Forms
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void rePass_TextChanged_1(object sender, EventArgs e)
        {
            if (rePass.Text != newPass.Text)
            {
                rePass.ForeColor = Color.Red;
            }
            else
            {
                rePass.ForeColor = Color.Black;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            user_login uc = con.user_logins.SingleOrDefault(x => x.uName == Utility.UserName && 
                x.uPassword == this.txtCurrentPassword.Text);

            if (uc != null)
            {
                uc.uPassword = newPass.Text;
                con.SubmitChanges();
                this.Dispose();
                MessageBox.Show("Password Changed");
            }
            else
            {
                MessageBox.Show("Error");
                txtCurrentPassword.Text = "";
                newPass.Text = "";
                rePass.Text = "";
            }

        }
    }
}
