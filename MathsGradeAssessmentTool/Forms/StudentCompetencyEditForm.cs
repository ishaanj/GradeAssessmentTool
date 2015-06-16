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
            
        }

        private void onCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = 3;
            int sum = 0;

            //Calculate Weighted Score
            if (studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] == studentCompentencyDataGridView.Rows[e.RowIndex].Cells[10])
            {
                for (; i < 11; i++)
                {

                    if (i == 3 || i == 5)
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value) * (i - 2);

                    else if (i == 4 || i == 6)
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 2) * (i - 2);

                    else if (i == 7 || i == 9 || i == 10)
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 3) * (i - 2);

                    else if (i == 8)
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 4) * (i - 2);

                }

                studentCompentencyDataGridView.Rows[e.RowIndex].Cells[11].Value = sum;

                //Calculate Grade Equivalent from weighted score
                int temp = (int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[11].Value;
                double temp2;
                int j = 0;
                int[] gradeEq = { 0, 4, 12, 24, 40, 60, 84, 112, 144, 180 };

                for (j = 0; j < 9; j++)
                {
                    if (gradeEq[j] > temp)
                        break;
                }

                j--;
                temp = temp - gradeEq[j];
                temp2 = (double)temp / (gradeEq[j + 1] - gradeEq[j]);
                temp2 += j;

                studentCompentencyDataGridView.Rows[e.RowIndex].Cells[12].Value = temp2;
            }
          }

            
 

    }
}
