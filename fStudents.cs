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
        private Student prev;
        private Student next;

        private bool tbsEnable
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
            предыдущийToolStripMenuItem.Enabled = следующийToolStripMenuItem.Enabled = btNext.Enabled = btPrev.Enabled = false;

            tbsEnable = false;
            gbDiploma.Visible = true;
            btToPostgrStud.Visible = false;
            предыдущийToolStripMenuItem.Enabled = следующийToolStripMenuItem.Enabled = btNext.Enabled = btPrev.Enabled = false;
            cbSearch.Enabled = false;
            tbSearch.Enabled = false;
            удалитьТекущегоСтудентаToolStripMenuItem.Enabled = false;

            cbSearch.Items.Add("Имя");
            cbSearch.SelectedIndex = 0;
            cbSearch.Items.Add("Фамилия");
            cbSearch.Items.Add("Факультет");
            cbSearch.Items.Add("Диплом");
        }

        public void RefreshTBData()
        {
            curStudent = studentHandler.CurStudent();
            tbSearch.Enabled = cbSearch.Enabled = studentHandler.haveStudens;
            gbDiploma.Visible = true;
            btToPostgrStud.Visible = false;

            if (curStudent == null)
            {
                tbFirstName.Text = "";
                tbSecondName.Text = "";
                tbFaculty.Text = "";
                tbDiploma.Text = "";
                tbsEnable = false;
                предыдущийToolStripMenuItem.Enabled = следующийToolStripMenuItem.Enabled = btNext.Enabled = btPrev.Enabled = false;
                удалитьТекущегоСтудентаToolStripMenuItem.Enabled = false;
                return;
            }
            
            удалитьТекущегоСтудентаToolStripMenuItem.Enabled = true;
            tbsEnable = true;
            next = studentHandler.Next();
            prev = studentHandler.Prev();
            следующийToolStripMenuItem.Enabled = btNext.Enabled = next != null;
            предыдущийToolStripMenuItem.Enabled = btPrev.Enabled = prev != null;

            tbFirstName.Text = curStudent.firstName;
            tbSecondName.Text = curStudent.secondName;
            tbFaculty.Text = curStudent.faculty;
            if (curStudent is PostcgraduateStudent)
            {
                tbDiploma.Text = ((PostcgraduateStudent)curStudent).diploma;
            }
            else
            {
                tbDiploma.Text = "";
                gbDiploma.Visible = false;
                btToPostgrStud.Visible = true;
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (curStudent == null) return;
            curStudent.firstName = tbFirstName.Text;
        }
        private void tbSecondName_TextChanged(object sender, EventArgs e)
        {
            if (curStudent == null) return;
            curStudent.secondName = tbSecondName.Text;
        }
        private void tbFaculty_TextChanged(object sender, EventArgs e)
        {
            if (curStudent == null) return;
            curStudent.faculty = tbFaculty.Text;
        }
        private void tbDiploma_TextChanged(object sender, EventArgs e)
        {
            if (curStudent == null) return;
            if (curStudent is PostcgraduateStudent)
            {
                ((PostcgraduateStudent)curStudent).diploma = tbDiploma.Text;
            }
        }

        private void добавитьБакалавраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.CreateNewUnGrStudent();
            RefreshTBData();
            tbSearch.Text = "";
        }
        private void добавитьМагистраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.CreateNewPsGrStudent();
            RefreshTBData();
            tbSearch.Text = "";
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "xml files (*.xml)|*.xml";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentHandler.WriteToFileList(saveFileDialog.FileName);
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    studentHandler.ReadFileToList(openFileDialog.FileName);
                    studentHandler.TryFind();
                    RefreshTBData();
                }
            }
        }
        private void создатьНовыйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.CreateNewList();
            RefreshTBData();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void следующийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.MoveNext();
            RefreshTBData();
        }
        private void предыдущийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.MoveBack();
            RefreshTBData();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch_TextChanged(null, null);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text.Trim() == "")
            {
                studentHandler.SetFilter(TypesOfFilter.NoFilter());
            }
            else
            {

                switch (cbSearch.SelectedItem)
                {
                    case "Имя":
                        studentHandler.SetFilter(TypesOfFilter.FirstName(tbSearch.Text.Trim()));
                        break;
                    case "Фамилия":
                        studentHandler.SetFilter(TypesOfFilter.SecondName(tbSearch.Text.Trim()));
                        break;
                    case "Факультет":
                        studentHandler.SetFilter(TypesOfFilter.Faculty(tbSearch.Text.Trim()));
                        break;
                    case "Диплом":
                        studentHandler.SetFilter(TypesOfFilter.Diploma(tbSearch.Text.Trim()));
                        break;
                    default:
                        MessageBox.Show("Баг");
                        break;
                }
            }

            RefreshTBData();
        }

        private void btToPostgrStud_Click(object sender, EventArgs e)
        {
            if (curStudent == null) return;

            studentHandler.CurStudentToPostr();
            RefreshTBData();
        }

        private void удалитьТекущегоСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentHandler.DeletCurStud();
            RefreshTBData();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
