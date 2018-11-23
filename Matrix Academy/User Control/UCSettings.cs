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
using Matrix_Academy.Connection;

namespace Matrix_Academy.User_Control
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();
            this.lblName.Text = Utility.UserName;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ShoW the System Log");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword cp = new FormChangePassword();
            cp.Show();
        }
    }
}
