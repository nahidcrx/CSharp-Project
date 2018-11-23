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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            this.Loading.Value = this.Loading.Value + 4;
            if (this.Loading.Value == 10)
            {
                label3.Text = "Reading modules..";
            }
            else if (this.Loading.Value == 20)
            {
                label3.Text = "Turning on modules..";
            }
            else if (this.Loading.Value == 40)
            {
                label3.Text = "Starting modules..";
            }
            else if (this.Loading.Value == 60)
            {
                label3.Text = "Loading modules..";
            }
            else if (this.Loading.Value == 80)
            {
                label3.Text = "Done Loading modules..";
            }
            else if (this.Loading.Value == 100)
            {
                FormLogin formLogin = new FormLogin();
                LoadingTimer.Enabled = false;
                formLogin.Show();
                this.Hide();
            }
        }
    }
}
