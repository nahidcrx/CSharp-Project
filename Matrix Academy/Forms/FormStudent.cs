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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();
            
            Student s = con.Students.SingleOrDefault(x => x.sName == txtName.Text);

            if (s != null)
            {
                s.sName = txtName.Text;
                s.sFatherName = txtFather.Text;
                s.sMotherName = txtMother.Text;
                s.sContactNo = txtContact.Text;
                s.sAdress = txtAddress.Text;
                s.sSchool = txtSchools.Text;
                s.sClass = txtClass.Text;
                s.sSection = txtsection.Text;
                s.sFees = int.Parse(txtFees.Text);

                con.SubmitChanges();
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("Not Update");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            Student s = con.Students.SingleOrDefault(x => x.sName == txtName.Text);

            if (s != null)
            {
                con.Students.DeleteOnSubmit(s);
                con.SubmitChanges();
                MessageBox.Show(" Deleted");
            }
            else
            {
                MessageBox.Show(" Not Found");
            }

        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            MatrixLinQDataContext con = new MatrixLinQDataContext();
            string temp = searchBox.GetItemText(searchBox.SelectedItem);
            Student s = con.Students.SingleOrDefault( x => x.sName == temp);

            if (s != null)
            {
                txtName.Text = s.sName;
                txtFather.Text = s.sFatherName;
                txtMother.Text = s.sMotherName;
                txtContact.Text = s.sContactNo;
                txtAddress.Text = s.sAdress;
                txtSchools.Text = s.sSchool;
                txtClass.Text= s.sClass;
                txtsection.Text = s.sSection;
                txtFees.Text = s.sFees.ToString();
             
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            var ob = con.Students.Where(x => x.sName.StartsWith(searchBox.Text));
            searchBox.DataSource = ob.ToList();
            searchBox.DisplayMember = "sName";

            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
