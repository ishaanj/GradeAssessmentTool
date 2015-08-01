using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGradeAssessmentTool.Forms
{
    public partial class StudentDetailsForm : Form
    {
        public StudentDetailsForm()
        {
            InitializeComponent();
            if ((bool)MathsGradeAssessmentTool.Properties.Settings.Default["isLockedSet"] == true)
            {
                studentBindingNavigator.Hide();
                studentDataGridView.Hide();
            }
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartTeacherForm stf = new StartTeacherForm();
            stf.Show();
            this.Hide();
        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }
        

        private void selectStudentAndSeeCompetencies_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = studentDataGridView.SelectedCells[0].RowIndex;
                int studentID = Convert.ToInt32(studentTableAdapter.GetData().Rows[rowindex]["StudentID"]);

                StudentCompetencyEditForm scef = new StudentCompetencyEditForm();
                scef.StudentID = studentID;
                scef.Show();
                this.Hide();
            }
            catch (Exception ex) { }
           
        }
    }
}
