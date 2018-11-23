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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            teacher t = con.teachers.SingleOrDefault(x => x.teacherName == txtName.Text);

            if (t != null)
            {

                t.teacherName= txtName.Text ;
                t.teacherEmail=txtMail.Text  ;
                t.teacherContactNo=txtContactNo.Text  ;

                t.teacherAddress=txtAddress.Text ;

                t.teacherDesignation= txtDesignation.Text  ;
                t.teacherPayPerClass=int.Parse(txtPayment.Text);

                con.SubmitChanges();
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("Not Update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            teacher t = con.teachers.SingleOrDefault(x => x.teacherName == txtName.Text);

            if (t != null)
            {
                con.teachers.DeleteOnSubmit(t);
                con.SubmitChanges();
                MessageBox.Show(" Deleted");
            }
            else
            {
                MessageBox.Show(" Not Found");
            }

        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            var ob = con.teachers.Where(x => x.teacherName.StartsWith(searchBox.Text));
            searchBox.DataSource = ob.ToList();
            searchBox.DisplayMember = "teacherName";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();
            string temp = searchBox.GetItemText(searchBox.SelectedItem);
            teacher t= con.teachers.SingleOrDefault(x => x.teacherName == temp);

            if (t != null)
            {
                txtName.Text = t.teacherName;
                txtMail.Text = t.teacherEmail;
                txtContactNo.Text = t.teacherContactNo;
                
                txtAddress.Text = t.teacherAddress;

                txtDesignation.Text = t.teacherDesignation;
                txtPayment.Text= t.teacherPayPerClass.ToString();

                

            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
