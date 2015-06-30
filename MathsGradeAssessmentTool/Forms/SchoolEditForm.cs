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
    public partial class SchoolEditForm : Form
    {
        public SchoolEditForm()
        {
            InitializeComponent();
        }

        private void schoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schoolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void SchoolEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.mathsToolDatabaseDataSet.School);

        }

        private void ReturnToMainScreen_Click(object sender, EventArgs e)
        {
            StartTeacherForm sf = new StartTeacherForm();
            sf.Show();
            this.Hide();
        }
    }
}
