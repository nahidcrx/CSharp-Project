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

namespace Matrix_Academy.User_Control
{
    public partial class UCSetUp : UserControl
    {
        public UCSetUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCourse.Text.Length != 0)
            {
                MatrixLinQDataContext con = new MatrixLinQDataContext();

                section s = new section();

                s.sectionName = this.txtCourse.Text;

                con.sections.InsertOnSubmit(s);
                con.SubmitChanges();
                MessageBox.Show("New Section Added");
                txtCourse.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    
    }
}
