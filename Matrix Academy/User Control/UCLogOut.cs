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
    public partial class UCLogOut : UserControl
    {
        public UCLogOut()
        {
            InitializeComponent();
        }

        private void btnLOE_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLO_Click(object sender, EventArgs e)
        {
            Utility.isLoginVisible = true;
            Utility.UserName = "root";
        }
    }
}
