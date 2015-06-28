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
    public partial class StudentCompetencyEditForm : Form
    {

        public int StudentID { get; set; }
        private int datacount = 0;

        public StudentCompetencyEditForm()
        {
            InitializeComponent();
        }

        private void StudentCompetencyEditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.StudentCompentency' table. You can move, or remove it, as needed.
            this.studentCompentencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.StudentCompentency);
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

        private void studentCompentencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentCompentencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

         private void studentCompentencyDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[2];
            cells.Value = StudentID;
            var row = studentTableAdapter.GetDataByStudentID((int)cells.Value);
            studentCompentencyDataGridView.Rows[e.RowIndex].Cells[3].Value = row[0].CurrentGrade;
        }

         private void onCellEndEdit(object sender, DataGridViewCellEventArgs e)
         {
             int i = 4;
             int sum = 0;

             for (; i < 12; i++)
             {
                 if (i == 4 || i == 6)
                     try
                     {
                         sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value) * (i - 3);
                     }
                     catch (Exception ex) { }

                 else if (i == 5 || i == 7)
                     try
                     {
                         sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 2) * (i - 3);
                     }
                     catch (Exception ex) { }

                 else if (i == 8 || i == 10 || i == 11)
                     try
                     {
                         sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 3) * (i - 3);
                     }
                     catch (Exception ex) { }

                 else if (i == 9)
                     try
                     {
                         sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 4) * (i - 3);
                     }
                     catch (Exception ex) {
                         Console.WriteLine(ex.ToString());
                     }
             }

             studentCompentencyDataGridView.Rows[e.RowIndex].Cells[12].Value = sum;

             //Calculate Grade Equivalent from weighted score
             float temp = (float)sum;
             float temp2;
             int j = 0;
             float[] gradeEq = { 0, 4, 12, 24, 40, 60, 84, 112, 144, 180 };

             for (j = 0; j < 9; j++)
             {
                 if (gradeEq[j] > temp)
                     break;
             }

             j--;
             temp = temp - gradeEq[j];
             temp2 = temp / (gradeEq[j + 1] - gradeEq[j]);
             temp2 += (float)j;

             Console.WriteLine(temp2);

             studentCompentencyDataGridView.Rows[e.RowIndex].Cells[13].Value = temp2 + "";
         }

         private void ToeXcel(DataGridView dGV, string filename)
         {
             string stOutput = "";
             // Export titles:
             string sHeaders = "";

             for (int j = 0; j < dGV.Columns.Count; j++)
                 sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
             stOutput += sHeaders + "\r\n";
             // Export data.
             for (int i = 0; i < dGV.RowCount - 1; i++)
             {
                 string stLine = "";
                 for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                     stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                 stOutput += stLine + "\r\n";
             }
             Encoding utf16 = Encoding.UTF8;
             byte[] output = utf16.GetBytes(stOutput);
             FileStream fs = new FileStream(filename, FileMode.Create);
             BinaryWriter bw = new BinaryWriter(fs);
             bw.Write(output, 0, output.Length); //write the encoded file
             bw.Flush();
             bw.Close();
             fs.Close();
         }

         private void ExportToExcelButton_Click(object sender, EventArgs e)
         {
             String name = studentTableAdapter.GetDataByStudentID(StudentID)[0].StudentName;
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "Excel Documents (2003)|*.xls|Excel Document (2007)|*.xlsx";
             sfd.FileName = name + " " +StudentID + ".xls";
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 ToeXcel(studentCompentencyDataGridView, sfd.FileName); 
             }  
         }  

    }
}

/*private void studentCompentencyDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == studentCompentencyDataGridView.Columns[1].Index)
            {
                this.datacount = mathsToolDatabaseDataSet.StudentCompentency.Count;
                if (datacount > 0)
                {
                    int compID = 0;
                    try
                    {
                         compID = Convert.ToInt32(studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;);
                    }
                    catch (Exception ex)
                    {
                        compID = -1;
                    }
                    if (compID > 0)
                    {
                        var rows = competencyTableAdapter1.GetCompetencyNameByID(compID).Rows;
                        if (rows.Count == 1)
                        {
                            String compName = Convert.ToString(rows[0]["CompetencyName"]);

                            var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cells.ToolTipText = compName;
                        }
                    }
                    
                    
                }
            }
              
          
        }
/*
  private void studentCompentencyDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[2];
            cells.Value = StudentID;

            /*int primaryKey = Convert.ToInt32(studentCompentencyTableAdapter.GetMaxPrimaryKey()) + 1;
            cells = studentCompentencyDataGridView.Rows[e.RowIndex].Cells[0];
            if(cells.Value == null || cells.Value == DBNull.Value)
                cells.Value = primaryKey + "";
            
        }
*/

/*
private void onCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = 3;
            int sum = 0;

            for (; i < 11; i++)
            {
                if (i == 3 || i == 5)
                    try
                    {
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value) * (i - 2);
                    }
                    catch (Exception ex) { }

                else if (i == 4 || i == 6)
                    try
                    {
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 2) * (i - 2);
                    }
                    catch (Exception ex) { }

                else if (i == 7 || i == 9 || i == 10)
                    try
                    {
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 3) * (i - 2);
                    }
                    catch (Exception ex) { }

                else if (i == 8)
                    try
                    {
                        sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value / 4) * (i - 2);
                    }
                    catch (Exception ex) { }
            }

            studentCompentencyDataGridView.Rows[e.RowIndex].Cells[11].Value = sum;

            //Calculate Grade Equivalent from weighted score
            float temp = (float)sum;
            float temp2;
            int j = 0;
            float[] gradeEq = { 0, 4, 12, 24, 40, 60, 84, 112, 144, 180 };

            for (j = 0; j < 9; j++)
            {
                if (gradeEq[j] > temp)
                    break;
            }

            j--;
            temp = temp - gradeEq[j];
            temp2 = temp / (gradeEq[j + 1] - gradeEq[j]);
            temp2 += (float)j;

            Console.WriteLine(temp2);

            studentCompentencyDataGridView.Rows[e.RowIndex].Cells[12].Value = temp2 + "";
        }
*/