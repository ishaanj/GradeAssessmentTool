using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGradeAssessmentTool.Forms
{
    public partial class TeacherDetailsForm : Form
    {
        public TeacherDetailsForm()
        {
            InitializeComponent();
            if((bool)MathsGradeAssessmentTool.Properties.Settings.Default["isLockedSet"] == true)
            {
                teacherDataGridView.Columns[3].Visible = false;
            }
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void TeacherDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.mathsToolDatabaseDataSet.School);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.mathsToolDatabaseDataSet.School);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.mathsToolDatabaseDataSet.School);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.mathsToolDatabaseDataSet.Teacher);
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartTeacherForm stf = new StartTeacherForm();
            stf.Show();
            this.Hide();
        }

        private void teacherBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void teacherBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }
    }
}
