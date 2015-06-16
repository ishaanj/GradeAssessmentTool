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

        public int StudentID { get; set;}
        private int datacount = 0;

        public StudentCompetencyEditForm()
        {
            InitializeComponent();
        }

        private void studentCompentencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentCompentencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);
            Console.WriteLine("Writing Data");
        }

        private void StudentCompetencyEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.StudentCompentency' table. You can move, or remove it, as needed.
            this.studentCompentencyTableAdapter.FillByStudentID(this.mathsToolDatabaseDataSet.StudentCompentency, StudentID);
            //studentCompentencyBindingSource.DataSource = studentCompentencyTableAdapter.GetDataByStudentID(StudentID);
            this.datacount = mathsToolDatabaseDataSet.StudentCompentency.Count;
        }

        private void returnToStudentButton_Click(object sender, EventArgs e)
        {
            StudentDetailsForm sc = new StudentDetailsForm();
            sc.Show();
            this.Hide();
        }


        private void studentCompentencyDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == studentCompentencyDataGridView.Columns[2].Index)
            {
                if (datacount > 0)
                {
                    int compID = Convert.ToInt32(studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    var rows = competencyTableAdapter1.GetCompetencyNameByID(compID).Rows;
                    if(rows.Count == 1)
                    {
                        String compName = Convert.ToString(rows[0]["CompetencyName"]);

                        var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cells.ToolTipText = compName;
                    }
                    
                }
            }
            else if (e.ColumnIndex == studentCompentencyDataGridView.Columns[1].Index)
            {
                var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cells.Value = StudentID;
            }
            
        }
    }
}

/*
 if (e.ColumnIndex == studentCompentencyDataGridView.Columns[2].Index)
            {
                if (datacount > 0)
                {
                    int compID = Convert.ToInt32(studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    Console.WriteLine("CompID = " + compID);
                    var rows = competencyTableAdapter1.GetCompetencyNameByID(compID).Rows;
                    if(rows.Count == 1)
                    {
                        String compName = Convert.ToString(rows[0]["CompetencyName"]);
                        Console.WriteLine("compName = " + compName);

                        var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cells.ToolTipText = compName;
                    }
                    
                }
            }
            else if (e.ColumnIndex == studentCompentencyDataGridView.Columns[1].Index)
            {
                var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cells.Value = StudentID;
            }
 */
