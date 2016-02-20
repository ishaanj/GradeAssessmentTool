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
using System.Windows.Forms.VisualStyles;

namespace MathsGradeAssessmentTool.Forms
{
    public partial class ExportImportForm : Form
    {
        public ExportImportForm()
        {
            InitializeComponent();
        }

        private void competencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.competencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);
        }

        private void ExportImportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.mathsToolDatabaseDataSet.Teacher);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.mathsToolDatabaseDataSet.Subject);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.StudentCompentency' table. You can move, or remove it, as needed.
            this.studentCompentencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.StudentCompentency);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.mathsToolDatabaseDataSet.School);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Competency' table. You can move, or remove it, as needed.
            this.competencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.Competency);
        }

        private void ImportAllButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Excel Documents (2003)|*.csv";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            progLbl.Visible = true;
            progressBarImport.Visible = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = null;
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader reader = new StreamReader(myStream, Encoding.UTF8);
                            String line = "";
                            String[] segs = null;
                            char[] splitArr = new char[] {','};
                            int fileCounter = 0;
                            while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                            {
                                if (line.Contains("--"))
                                    break;

                                if (line.Contains(','))
                                    segs = line.Split(splitArr, StringSplitOptions.None);

                                if (segs[0].Contains("TeacherID") || segs[0].Contains("SubjectID") ||
                                    segs[0].Contains("CompetencyID") || segs[0].Contains("SchoolID") ||
                                    segs[0].Contains("StudentId") || segs[0].Contains("Competency Name"))
                                {
                                    fileCounter++;
                                    continue;
                                }

                                switch (fileCounter)
                                {
                                    case 1:
                                        try
                                        {
                                            ImportTeacher(segs);
                                        }
                                        catch (Exception ex) {
                                            Console.WriteLine(ExportStudent());
                                        }
                                        break;
                                    case 2:
                                        try
                                        {
                                            ImportSubject(segs);
                                        }
                                        catch (Exception ex) {
                                            Console.WriteLine(ex);
                                        }
                                        break;
                                    case 3:
                                        try
                                        {
                                            ImportCompetency(segs);
                                        }
                                        catch (Exception ex) {
                                            Console.WriteLine(ex);
                                        }
                                        break;
                                    case 4:
                                        try
                                        {
                                            ImportSchool(segs);
                                        }
                                        catch (Exception ex) {
                                            Console.WriteLine(ex);
                                        }
                                        break;
                                    case 5:
                                        try
                                        {
                                            ImportStudent(segs);
                                        }
                                        catch (Exception ex) {
                                            Console.WriteLine(ex);
                                        }
                                        break;
                                    case 6:
                                        try
                                        {
                                            ImportStudentCompetency(segs);
                                        }
                                        catch (Exception ex) {
                                            Console.WriteLine(ex);
                                        }
                                        break;
                                }
                            }

                            reader.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from database correctly.\n\n" + ex);
                }

                progLbl.Visible = false;
                progressBarImport.Visible = false;
            }
        }

        private void ImportTeacher(string[] segs)
        {
            int teacherID = Convert.ToInt32(segs[0]);
            string teacherName = segs[1];
            int schoolID = string.IsNullOrEmpty(segs[2]) ? 1 : Convert.ToInt32(segs[2]);

            teacherTableAdapter.Insert(teacherID, teacherName, schoolID, "");
        }

        private void ImportSubject(string[] segs)
        {
            int subjectID = Convert.ToInt32(segs[0]);
            string subjectName = segs[1];
            int maxScore = string.IsNullOrEmpty(segs[2]) ? 100 : Convert.ToInt32(segs[2]);

            subjectTableAdapter.Insert(subjectID, subjectName, maxScore);
        }

        private void ImportCompetency(string[] segs)
        {
            int compID = Convert.ToInt32(segs[0]);
            string compName = segs[1];
            int subjectID = string.IsNullOrEmpty(segs[2]) ? 1 : Convert.ToInt32(segs[2]);
            int M1 = string.IsNullOrEmpty(segs[3]) ? 0 : Convert.ToInt32(segs[3]);
            int M2 = string.IsNullOrEmpty(segs[4]) ? 0 : Convert.ToInt32(segs[4]);
            int M3 = string.IsNullOrEmpty(segs[5]) ? 0 : Convert.ToInt32(segs[5]);
            int M4 = string.IsNullOrEmpty(segs[6]) ? 0 : Convert.ToInt32(segs[6]);
            int M5 = string.IsNullOrEmpty(segs[7]) ? 0 : Convert.ToInt32(segs[7]);
            int M6 = string.IsNullOrEmpty(segs[8]) ? 0 : Convert.ToInt32(segs[8]);
            int M7 = string.IsNullOrEmpty(segs[9]) ? 0 : Convert.ToInt32(segs[9]);
            int M8 = string.IsNullOrEmpty(segs[10]) ? 0 : Convert.ToInt32(segs[10]);

            competencyTableAdapter.Insert(compID, compName, subjectID, M1, M2, M3, M4, M5, M6, M7, M8);
        }

        private void ImportSchool(string[] segs)
        {
            int schoolID = Convert.ToInt32(segs[0]);
            string schoolName = segs[1];

            schoolTableAdapter.Insert(schoolID, schoolName, "");
        }

        private void ImportStudent(string[] segs)
        {
            int studentID = Convert.ToInt32(segs[0]);
            string studentName = segs[1];
            int subjectID = string.IsNullOrEmpty(segs[2]) ? 1 : Convert.ToInt32(segs[2]);
            int teacherID = string.IsNullOrEmpty(segs[3]) ? 1 : Convert.ToInt32(segs[3]);
            int year = string.IsNullOrEmpty(segs[4]) ? 1 : Convert.ToInt32(segs[4]);

            studentTableAdapter.InsertStudent(studentID, studentName, subjectID, teacherID, year, "");
        }

        private void ImportStudentCompetency(string[] segs)
        {
            Console.WriteLine(string.Join(",", segs));
            int CompetencyID = Convert.ToInt32(segs[1]);
            int StudentId = Convert.ToInt32(segs[2]);
            int G1 = string.IsNullOrEmpty(segs[3]) ? 0 : Convert.ToInt32(segs[3]);
            int G2 = string.IsNullOrEmpty(segs[4]) ? 0 : Convert.ToInt32(segs[4]);
            int G3 = string.IsNullOrEmpty(segs[5]) ? 0 : Convert.ToInt32(segs[5]);
            int G4 = string.IsNullOrEmpty(segs[6]) ? 0 : Convert.ToInt32(segs[6]);
            int G5 = string.IsNullOrEmpty(segs[7]) ? 0 : Convert.ToInt32(segs[7]);
            int G6 = string.IsNullOrEmpty(segs[8]) ? 0 : Convert.ToInt32(segs[8]);
            int G7 = string.IsNullOrEmpty(segs[9]) ? 0 : Convert.ToInt32(segs[9]);
            int G8 = string.IsNullOrEmpty(segs[10]) ? 0 : Convert.ToInt32(segs[10]);

            Console.Write(" --- GTotalWeighted = " + segs[11]);
            int GTotalWeighted = Convert.ToInt32(segs[11]);
            Console.WriteLine(" --- GEquivalent = " + segs[12]);
            string GradeEquivalent = segs[12];
            int GradeLevel = Convert.ToInt32(segs[13]);

            // CompetencyID, StudentId, G1, G2, G3, G4, G5, G6, G7, G8, GTotalWeighted, GradeEquivalent, GradeLevel

            var duplicate = studentCompentencyTableAdapter.GetDataIfDuplicate(CompetencyID, StudentId, G1, G2, G3, G4, G5, G6, G7, G8, GTotalWeighted, GradeEquivalent, GradeLevel);
            if (duplicate.Count == 0)
            {
                studentCompentencyTableAdapter.InsertStudComptency(CompetencyID, StudentId, G1, G2, G3, G4, G5, G6, G7, G8, GTotalWeighted, GradeEquivalent, GradeLevel);
            }
        }

        private void ExportAllButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel Documents (2003)|*.csv";
            saveFileDialog1.FileName = "Database.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportAll(saveFileDialog1.FileName);
            }
        }

        private void ExportAll(string filename)
        {
            Encoding utf16 = Encoding.UTF8;
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            byte[] preamble = Encoding.UTF8.GetPreamble();
            bw.Write(preamble, 0, preamble.Length);

            // Teacher Section
            string teacher = ExportTeacher();
            byte[] output = utf16.GetBytes(teacher);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();

            // Subject Section
            string subject = ExportSubject();
            output = utf16.GetBytes(subject);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();

            // Competency Section
            string competency = ExportCompetency();
            output = utf16.GetBytes(competency);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();

            // School Section
            string school = ExportSchool();
            output = utf16.GetBytes(school);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();

            // Student Section
            string student = ExportStudent();
            output = utf16.GetBytes(student);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();

            //Student Competenct Section
            string studentcomp = ExportStudentCompetency();
            output = utf16.GetBytes(studentcomp);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();

            bw.Write("--");
            bw.Flush();

            bw.Close();
            fs.Close();

            var fileInfo = new FileInfo(filename) { IsReadOnly = true };
        }

        private string ExportTeacher()
        {
            // Teacher Section
            teacherTableAdapter.Fill(mathsToolDatabaseDataSet.Teacher);
            int teacherCount = mathsToolDatabaseDataSet.Teacher.Count;

            string header = "";
            string output = "";

            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    header = header + Convert.ToString(teacherDataGridView.Columns[i].HeaderText);
                    break;
                }
                header = header + Convert.ToString(teacherDataGridView.Columns[i].HeaderText) + ",";
            }

            output += header + "\r\n";
            for (int i = 0; i < teacherDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < teacherDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == teacherDataGridView.Rows[i].Cells.Count - 1)
                        stLine = stLine + Convert.ToString(teacherDataGridView.Rows[i].Cells[j].Value);
                    else
                        stLine = stLine + Convert.ToString(teacherDataGridView.Rows[i].Cells[j].Value) + ",";
                }
                output += stLine + "\r\n";
            }

            return output;
        }

        private string ExportSubject()
        {
            // Teacher Section
            subjectTableAdapter.Fill(mathsToolDatabaseDataSet.Subject);

            string header = "";
            string output = "";

            for (int i = 0; i < subjectDataGridView.ColumnCount; i++)
            {
                if (i == subjectDataGridView.Columns.Count - 1)
                {
                    header = header + Convert.ToString(subjectDataGridView.Columns[i].HeaderText);
                }
                header = header + Convert.ToString(subjectDataGridView.Columns[i].HeaderText) + ",";
            }

            output += header + "\r\n";
            for (int i = 0; i < subjectDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < subjectDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == subjectDataGridView.Rows[i].Cells.Count - 1)
                        stLine = stLine + Convert.ToString(subjectDataGridView.Rows[i].Cells[j].Value);
                    else
                        stLine = stLine + Convert.ToString(subjectDataGridView.Rows[i].Cells[j].Value) + ",";
                }
                output += stLine + "\r\n";
            }

            return output;
        }

        private string ExportCompetency()
        {
            // Teacher Section
            competencyTableAdapter.Fill(mathsToolDatabaseDataSet.Competency);

            string header = "";
            string output = "";

            for (int i = 0; i < competencyDataGridView.ColumnCount; i++)
            {
                if (i == competencyDataGridView.Columns.Count - 1)
                {
                    header = header + Convert.ToString(competencyDataGridView.Columns[i].HeaderText);
                }
                else
                    header = header + Convert.ToString(competencyDataGridView.Columns[i].HeaderText) + ",";
            }

            output += header + "\r\n";
            for (int i = 0; i < competencyDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < competencyDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == competencyDataGridView.Rows[i].Cells.Count - 1)
                        stLine = stLine + Convert.ToString(competencyDataGridView.Rows[i].Cells[j].Value);
                    else
                        stLine = stLine + Convert.ToString(competencyDataGridView.Rows[i].Cells[j].Value) + ",";
                }
                output += stLine + "\r\n";
            }

            return output;
        }

        private string ExportSchool()
        {
            // Teacher Section
            schoolTableAdapter.Fill(mathsToolDatabaseDataSet.School);

            string header = "";
            string output = "";

            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    header = header + Convert.ToString(schoolDataGridView.Columns[i].HeaderText);
                }
                else header = header + Convert.ToString(schoolDataGridView.Columns[i].HeaderText) + ",";
            }

            output += header + "\r\n";
            for (int i = 0; i < schoolDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < schoolDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == schoolDataGridView.Rows[i].Cells.Count - 1)
                        stLine = stLine + Convert.ToString(schoolDataGridView.Rows[i].Cells[j].Value);
                    else
                        stLine = stLine + Convert.ToString(schoolDataGridView.Rows[i].Cells[j].Value) + ",";
                }
                output += stLine + "\r\n";
            }

            return output;
        }

        private string ExportStudent()
        {
            // Teacher Section
            studentTableAdapter.Fill(mathsToolDatabaseDataSet.Student);

            string header = "";
            string output = "";

            for (int i = 0; i < studentDataGridView.ColumnCount; i++)
            {
                if (i == studentDataGridView.Columns.Count - 2)
                {
                    header = header + Convert.ToString(studentDataGridView.Columns[i].HeaderText);
                    break;
                }
                header = header + Convert.ToString(studentDataGridView.Columns[i].HeaderText) + ",";
            }

            output += header + "\r\n";
            for (int i = 0; i < studentDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < studentDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == studentDataGridView.Rows[i].Cells.Count - 1)
                        stLine = stLine + Convert.ToString(studentDataGridView.Rows[i].Cells[j].Value);
                    else
                        stLine = stLine + Convert.ToString(studentDataGridView.Rows[i].Cells[j].Value) + ",";
                }
                output += stLine + "\r\n";
            }

            return output;
        }

        private string ExportStudentCompetency()
        {
            studentCompentencyTableAdapter.Fill(mathsToolDatabaseDataSet.StudentCompentency);

            string stOutput = "";

            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < studentCompentencyDataGridView.Columns.Count; j++)
            {
                if (j == 0)
                    sHeaders = sHeaders + "Competency Name" + "," + Convert.ToString(studentCompentencyDataGridView.Columns[j].HeaderText) + ",";
                else if (j == studentCompentencyDataGridView.Columns.Count - 1)
                    sHeaders = sHeaders + Convert.ToString(studentCompentencyDataGridView.Columns[j].HeaderText);
                else
                    sHeaders = sHeaders + Convert.ToString(studentCompentencyDataGridView.Columns[j].HeaderText) + ",";
            }

            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < studentCompentencyDataGridView.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < studentCompentencyDataGridView.Rows[i].Cells.Count; j++)
                {
                    if (j == 0)
                    {
                        string competencyName = "";
                        try
                        {
                            var row = competencyTableAdapter.GetCompetencyNameByID(Convert.ToInt32(studentCompentencyDataGridView.Rows[i].Cells[j].Value))[0];
                            competencyName = row.CompetencyName;
                        }
                        catch (Exception ex)
                        {
                            competencyName = "Competency " + Convert.ToString(studentCompentencyDataGridView.Rows[i].Cells[j].Value);
                        }

                        stLine = stLine + competencyName + "," + Convert.ToString(studentCompentencyDataGridView.Rows[i].Cells[j].Value) + ",";
                    }
                    else if (j == studentCompentencyDataGridView.Rows[i].Cells.Count - 1)
                        stLine = stLine + Convert.ToString(studentCompentencyDataGridView.Rows[i].Cells[j].Value);
                    else
                        stLine = stLine + Convert.ToString(studentCompentencyDataGridView.Rows[i].Cells[j].Value) + ",";
                }

                stOutput += stLine + "\r\n";
            }
            
            return stOutput;
        }

        private void ReturnToSchool_Click(object sender, EventArgs e)
        {
            SchoolEditForm f = new SchoolEditForm();
            f.Show();
            this.Hide();
        }
    }
}
