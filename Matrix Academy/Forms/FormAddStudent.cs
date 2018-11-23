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
    public partial class s : Form
    {
        public s()
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
                Student s = new Student();
                s.sName = txtName.Text;
                s.sFatherName = txtFather.Text;
                s.sMotherName = txtMother.Text;
                s.sContactNo = txtContact.Text;
                s.sGender = gender.SelectedItem.ToString();
                s.sAdress = txtAddress.Text;
                s.sDateOfBirth = DoB.Value.ToString("dd/MM/yyyy");
                s.sJoiningDate = JoiningDate.Value.ToString("dd/MM/yyyy");
                s.sSchool = txtSchools.Text;
                s.sClass = ClassBox.SelectedItem.ToString();
                s.sSection = SectionBox.GetItemText(SectionBox.SelectedItem);
                s.sFees = int.Parse(txtFees.Text);

                con.Students.InsertOnSubmit(s);
                con.SubmitChanges();
                MessageBox.Show("New Student Added");


            }
        }

        private bool isFieldEmpty()
        {
            if (txtName.Text.Length == 0 || txtFather.Text.Length == 0
                || txtMother.Text.Length == 0 || txtContact.Text.Length == 0
                || gender.SelectedIndex == -1 || txtAddress.Text.Length == 0
                || txtSchools.Text.Length == 0 || ClassBox.SelectedIndex == -1
                || SectionBox.SelectedIndex == -1 || txtFees.Text.Length == 0)
            {
                MessageBox.Show("Field Empty");
                return true;
            }
            return false;
        
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            MatrixLinQDataContext con = new MatrixLinQDataContext();

            var ob = from f in con.sections
                     select f;
            if (ob.Any())
            {
                SectionBox.DataSource = ob.ToList();
                SectionBox.DisplayMember = "sectionName";
            }
        }
    }
}
