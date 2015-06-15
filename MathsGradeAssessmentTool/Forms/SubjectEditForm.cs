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
    public partial class SubjectEditForm : Form
    {
        public SubjectEditForm()
        {
            InitializeComponent();
        }

        private void subjectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void SubjectEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.mathsToolDatabaseDataSet.Subject);

        }

        private void onReturnToMainScreen(object sender, EventArgs e)
        {
            StartTeacherForm stf = new StartTeacherForm();
            stf.Show();
            this.Hide();
        }
    }
}
