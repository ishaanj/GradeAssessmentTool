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
    public partial class StudentCompetencyEditForm : Form
    {

        private int StudentID { get; set;}
        private int CompetencyID {get; set;}

        public StudentCompetencyEditForm()
        {
            InitializeComponent();
        }

        private void studentCompentencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentCompentencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void StudentCompetencyEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.StudentCompentency' table. You can move, or remove it, as needed.
            this.studentCompentencyTableAdapter.FillWithStudentCompentencyDataOfStudent(this.mathsToolDatabaseDataSet.StudentCompentency, CompetencyID, StudentID);

        }

        private void returnToStudentButton_Click(object sender, EventArgs e)
        {
            StudentCompentency sc = new StudentCompentency();
            sc.Show();
            this.Hide();
        }
    }
}
