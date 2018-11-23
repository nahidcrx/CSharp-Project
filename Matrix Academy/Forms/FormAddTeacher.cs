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
    public partial class FormAddTeacher : Form
    {
        public FormAddTeacher()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!isFieldEmpty())
            {
                MatrixLinQDataContext con = new MatrixLinQDataContext();
                teacher t = new teacher();
                t.teacherName = txtName.Text;
                t.teacherEmail = txtMail.Text;
                t.teacherContactNo = txtContactNo.Text;
                t.teacherBloodGroup = bloodGroup.SelectedItem.ToString();
                t.teacherReligion = religion.SelectedItem.ToString();
                t.teacherAddress = txtAddress.Text;
                t.teacherJoinDate = joinDate.Value.ToString("dd/MM/yyyy");
                t.teacherDesignation = txtDesignation.Text;
                t.teacherPayPerClass = Convert.ToInt32(txtPayment.Text);

                con.teachers.InsertOnSubmit(t);
                con.SubmitChanges();
                MessageBox.Show("New User Added");
            }
        }
        private bool isFieldEmpty()
        {
            if(txtName.Text.Length == 0 || txtMail.Text.Length == 0 || txtContactNo.Text.Length == 0
                || bloodGroup.SelectedIndex == -1 || religion.SelectedIndex == -1
                || txtAddress.Text.Length == 0 || txtDesignation.Text.Length == 0
                || txtPayment.Text.Length == 0)
            {
                MessageBox.Show("Field Empty");
                return true;
            }
            return false;
        }
    }
}
