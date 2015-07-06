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
             int i = 4,sum = 0;
             int[] compw = new int[8];

             MathsGradeAssessmentTool.MathsToolDatabaseDataSet.CompetencyRow comp = null;
             int cid = 0;
             try
             {
                 cid = Convert.ToInt32(studentCompentencyDataGridView.Rows[e.RowIndex].Cells[1].Value);
                 var x = competencyTableAdapter1.GetData();
                 foreach (MathsGradeAssessmentTool.MathsToolDatabaseDataSet.CompetencyRow row in x)
                 {
                     if (row.CompetencyID == cid)
                     {
                         comp = row;
                         break;
                     }
                 }
             }
             catch (Exception ex)
             {

             }

             if (comp == null)
             {
                 DialogResult r = MessageBox.Show("The Competency with ID " + cid + " was not found. Add Competency?", "Competency Not Found", MessageBoxButtons.OK);
                 if (r == DialogResult.OK)
                 {
                     CompentencyEditForm cef = new CompentencyEditForm();
                     cef.Show();
                     this.Hide();
                     return;
                 }
                 
             }

             compw[0] = comp.MG1;
             compw[1] = comp.MG2;
             compw[2] = comp.MG3;
             compw[3] = comp.MG4;
             compw[4] = comp.MG5;
             compw[5] = comp.MG6;
             compw[6] = comp.MG7;
             compw[7] = comp.MG8;

                 for (; i < 12; i++)
                 {
                     try
                     {
                         sum += ((int)studentCompentencyDataGridView.Rows[e.RowIndex].Cells[i].Value * 4 / compw[i-4]) * (i - 3);
                     }
                     catch (Exception ex)
                     {
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


             studentCompentencyDataGridView.Rows[e.RowIndex].Cells[13].Value = temp2 + "";
         }

         private void ToeXcel(DataGridView dGV, string filename, MathsGradeAssessmentTool.MathsToolDatabaseDataSet.StudentRow studentData)
         {
             string stOutput = "Name : \t" + studentData.StudentName + "\r\n";
             stOutput += "ID : \t" + studentData.StudentId + "\tGrade : \t" + studentData.CurrentGrade + "\r\n";

             // Export titles:
             string sHeaders = "";

             for (int j = 0; j < dGV.Columns.Count; j++)
             {
                 if(j != 1)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                 else
                 {
                     sHeaders = sHeaders.ToString() + "Competency Name" + "\t" + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                 }
             }
                 
             stOutput += sHeaders + "\r\n";
             // Export data.
             for (int i = 0; i < dGV.RowCount - 1; i++)
             {
                 string stLine = "";
                 for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                 {
                     if (j != 1)
                     {
                         stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                     }
                     else
                     {
                         String competencyName = "";
                         try
                         {
                             var row = competencyTableAdapter1.GetCompetencyNameByID(Convert.ToInt32(dGV.Rows[i].Cells[j].Value))[0];
                             competencyName = row.CompetencyName;
                         }
                         catch (Exception ex)
                         {
                             competencyName = "Competency " + Convert.ToString(dGV.Rows[i].Cells[j].Value);
                         }

                         stLine = stLine.ToString() + competencyName + "\t" + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                     }
                 }
                 
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
             var studentData = studentTableAdapter.GetDataByStudentID(StudentID)[0];
             string StudentName = studentData.StudentName;
             String name = "Student " + StudentName;
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "Excel Documents (2003)|*.xls|Excel Document (2007)|*.xlsx";
             sfd.FileName = name + " ID - " +StudentID + ".xls";
             if (sfd.ShowDialog() == DialogResult.OK)
             {
                 ToeXcel(studentCompentencyDataGridView, sfd.FileName, studentData); 
             }  
         }

         private void ImportFromExcelButton_Click(object sender, EventArgs e)
         {
             Stream myStream = null;
             OpenFileDialog openFileDialog1 = new OpenFileDialog();

             openFileDialog1.InitialDirectory = "c:\\";
             openFileDialog1.Filter = "Excel Documents (2003)|*.xls|Excel Document (2007)|*.xlsx";
             openFileDialog1.FilterIndex = 1;
             openFileDialog1.RestoreDirectory = true;

             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 try
                 {
                     if ((myStream = openFileDialog1.OpenFile()) != null)
                     {
                         using (myStream)
                         {
                             StreamReader reader = new StreamReader(myStream, Encoding.UTF8);
                             String line = "";
                             String[] segs = null;
                             char[] splitArr = new char[] { '\t' };

                             studentCompentencyTableAdapter.DeleteByStudentID(StudentID);

                             while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                             {
                                 //Console.WriteLine(line);
                                 if(line.Contains('\t'))
                                     segs = line.Split(splitArr, StringSplitOptions.None);
                                 else
                                     continue;

                                 if (segs[0].Equals("Name : "))
                                     continue;

                                 if (segs[0].Equals("ID : "))
                                     continue;

                                 if (segs[0].Equals("StudentCompId"))
                                     continue;

                                 int StudentCompId = Convert.ToInt32(segs[0]);
                                 int CompetencyID = Convert.ToInt32(segs[2]);
                                 int StudentId = Convert.ToInt32(segs[3]);
                                 int GradeLevel = Convert.ToInt32(segs[4]);
                                 int G1 = string.IsNullOrEmpty(segs[5]) ? 0 : Convert.ToInt32(segs[5]);
                                 int G2 = string.IsNullOrEmpty(segs[6]) ? 0 : Convert.ToInt32(segs[6]);
                                 int G3 = string.IsNullOrEmpty(segs[7]) ? 0 : Convert.ToInt32(segs[7]);
                                 int G4 = string.IsNullOrEmpty(segs[8]) ? 0 : Convert.ToInt32(segs[8]);
                                 int G5 = string.IsNullOrEmpty(segs[9]) ? 0 : Convert.ToInt32(segs[9]);
                                 int G6 = string.IsNullOrEmpty(segs[10]) ? 0 : Convert.ToInt32(segs[10]);
                                 int G7 = string.IsNullOrEmpty(segs[11]) ? 0 : Convert.ToInt32(segs[11]);
                                 int G8 = string.IsNullOrEmpty(segs[12]) ? 0 : Convert.ToInt32(segs[12]);
                                 int GTotalWeighted = Convert.ToInt32(segs[13]);
                                 string GradeEquivalent = segs[14];

                                 studentCompentencyTableAdapter.InsertWithStudentID(StudentCompId, CompetencyID, StudentId, G1, G2, G3, G4, G5, G6, G7, G8, GTotalWeighted, GradeEquivalent, GradeLevel);
                             }
                             studentCompentencyTableAdapter.FillByStudentID(this.mathsToolDatabaseDataSet.StudentCompentency, StudentID);
                             reader.Close();
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: Could not read file from disk.");
                 }
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