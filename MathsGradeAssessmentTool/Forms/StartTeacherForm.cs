using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MathsGradeAssessmentTool.Forms
{
    public partial class StartTeacherForm : Form
    {
        private int[] teacherIDS;

        public StartTeacherForm()
        {
            InitializeComponent();
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void teacherBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void StartTeacherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.StudentCompentency' table. You can move, or remove it, as needed.
            this.studentCompentencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.StudentCompentency);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.mathsToolDatabaseDataSet.Teacher);

            int count = teacherTableAdapter.GetData().Count;
            teacherIDS = new int[count];

            DataRowCollection rows = teacherTableAdapter.GetData().Rows;

            for(int i = 0; i < count; i++) {
                teacherIDS[i] =  Convert.ToInt32(rows[i]["TeacherID"]);
            }

        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            TeacherDetailsForm tdf = new TeacherDetailsForm();
            tdf.Show();
            this.Hide();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            StudentDetailsForm sdf = new StudentDetailsForm();
            sdf.Show();
            this.Hide();
        }

        private void AddCompetency_Click(object sender, EventArgs e)
        {
            CompentencyEditForm cef = new CompentencyEditForm();
            cef.Show();
            this.Hide();
        }

        private void AddSubjectClicked_Clicked(object sender, EventArgs e)
        {
            SubjectEditForm sef = new SubjectEditForm();
            sef.Show();
            this.Hide();
        }

        private void onSelectedIndexChange(object sender, EventArgs e)
        {
            String name = teacherNameComboBox.Text;
            int position = teacherNameComboBox.SelectedIndex;
            if (position >= 0)
            {
                int teacherID = teacherIDS[position];
                fKStudentToTeacherBindingSource.DataSource = studentTableAdapter.GetDataByTeacherID(teacherID);
            }
        }


        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gTotalWeightedTextBox.Text = "";
            gradeEquivalentTextBox.Text = "";
            if (e.RowIndex >= 0)
            {
                int id = (int)studentDataGridView.Rows[e.RowIndex].Cells[0].Value;
                var data = studentCompentencyTableAdapter.GetDataByStudentID(id);

                if (data.Rows.Count > 0)
                {
                    int sumTotal = 0, sumGrade = 0;
                    foreach (DataRow r in data.Rows) {
                        sumTotal += Convert.ToInt32(r["GTotalWeighted"]);
                        sumGrade += Convert.ToInt32(r["GradeEquivalent"]);
                    }
                    gTotalWeightedTextBox.Text = sumTotal + "";
                    gradeEquivalentTextBox.Text = sumGrade + "";
                }
            }
        }

    }
}
