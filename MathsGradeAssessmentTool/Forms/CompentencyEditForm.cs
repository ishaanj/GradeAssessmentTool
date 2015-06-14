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
    public partial class CompentencyEditForm : Form
    {
        public CompentencyEditForm()
        {
            InitializeComponent();
        }

        private void competencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.competencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void CompentencyEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Competency' table. You can move, or remove it, as needed.
            this.competencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.Competency);

        }
    }
}
