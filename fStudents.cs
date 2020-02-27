using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsХml
{
    public partial class fStudents : Form
    {
        private StudentHandler studentHandler = new StudentHandler();
        private Student curStudent = null;

        private bool tbEnable
        {
            set
            {
                tbFirstName.Enabled = value;
                tbSecondName.Enabled = value;
                tbFaculty.Enabled = value;
                tbDiploma.Enabled = value;
            }
        }

        public fStudents()
        {
            InitializeComponent();            
        }

        private void fStudents_Load(object sender, EventArgs e)
        {
            studentHandler.CreateNewList();
            tbEnable = false;
        }

        private void RefreshCurStud()
        {
            curStudent.firstName = tbFirstName.Text;
            curStudent.secondName = tbSecondName.Text;
            curStudent.faculty = tbFaculty.Text;
            if (curStudent is PostcgraduateStudent)
            {
                ((PostcgraduateStudent)curStudent).diploma = tbDiploma.Text;
            }
        }

        public void RefreshTBData()
        {
            if (curStudent == null)
            {
                tbFirstName.Text = "";
                tbSecondName.Text = "";
                tbFaculty.Text = "";
                tbDiploma.Text = "";
            }
            else
            {
                tbFirstName.Text = curStudent.firstName;
                tbSecondName.Text = curStudent.secondName;
                tbFaculty.Text = curStudent.faculty;
                if (curStudent is PostcgraduateStudent)
                {
                    tbDiploma.Text = ((PostcgraduateStudent)curStudent).diploma;
                    btToPostgrStud.Visible = false;
                    tbDiploma.Visible = true;
                }
                else
                {
                    tbDiploma.Text = "";
                    tbDiploma.Visible = false;
                    btToPostgrStud.Visible = true;
                }
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            curStudent.firstName = tbFirstName.Text;
        }

        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {
            curStudent.secondName = tbSecondName.Text;
        }

        private void tbFaculty_TextChanged(object sender, EventArgs e)
        {
            curStudent.faculty = tbFaculty.Text;
        }

        private void tbDiploma_TextChanged(object sender, EventArgs e)
        {
            if (curStudent is PostcgraduateStudent)
            {
                ((PostcgraduateStudent)curStudent).diploma = tbDiploma.Text;
            }
        }

        private void btPrev_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void добавитьБакалавраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.CreateNewUnGrStudent();
            curStudent = studentHandler.GetCurStudent();
            RefreshTBData();
            tbEnable = true;
        }

        private void добавитьМагистраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.CreateNewPsGrStudent();
            curStudent = studentHandler.GetCurStudent();
            RefreshTBData();
            tbEnable = true;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.WriteToFileList(null);
        }
    }
}
