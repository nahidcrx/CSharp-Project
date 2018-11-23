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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (Utility.isLoginVisible)
            {
                this.Visible = Utility.isLoginVisible;
            }
        }

        private void UserID_TextChanged(object sender, EventArgs e)
        {
            if (UserID.Text != "")
            {
                a.Hide();
            }
            else
            {
                a.Show();
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != "")
            {
                upass.Hide();
            }
            else
            {
                upass.Show();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!isFieldEmpty())
            {
                if (isUserValid())
                {
                    Utility.UserName = UserID.Text;
                    this.UserID.Text = "";
                    this.Password.Text = "";
                    FormDashBoard fdb = new FormDashBoard();
                    Utility.isLoginVisible = false;
                    this.Visible = Utility.isLoginVisible;
                    fdb.Visible = !Utility.isLoginVisible;
                }
                else
                {
                    MessageBox.Show("Wrong name/password");
                }
            }
            
        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("mail one's password to his/her mail account");
        }
        private bool isFieldEmpty()
        {
            if(UserID.Text.Length == 0 || Password.Text.Length == 0)
            {
                MessageBox.Show("Field Empty!!");
                return true;
            }
            return false;
        }
        //connect with linQ
        private bool isUserValid()
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();
            var ob = from f in con.user_logins
                     where f.uName == UserID.Text
                     && f.uPassword == Password.Text
                     select f;
            if (ob.Any())
            {
                return true;
            }
            return false;
        }
    }
}
