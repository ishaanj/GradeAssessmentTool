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
    public partial class StudentDetailsForm : Form
    {
        public StudentDetailsForm()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);
        }

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartTeacherForm stf = new StartTeacherForm();
            stf.Show();
            this.Hide();
        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void studentBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }


        private void selectStudentAndSeeCompetencies_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = studentDataGridView.SelectedCells[0].RowIndex;
                int studentID = Convert.ToInt32(studentTableAdapter.GetData().Rows[rowindex]["StudentID"]);

                StudentCompetencyEditForm scef = new StudentCompetencyEditForm();
                scef.StudentID = studentID;
                scef.Show();
                this.Hide();
            }
            catch (Exception ex) { }

        }

        private void SaveSelectedStudentDetails_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (2003)|*.xls";
            sfd.FileName = "All Student Competencies.xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToeXcel(studentCompetencyDataAdapter, sfd.FileName);
            }
        }

        private void ToeXcel(DataGridView dGV, string filename)
        {

            string stOutput = "";

            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
            {
                if (j != 0)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                else
                {
                    sHeaders = sHeaders.ToString() + "Competency Name" + "\t" + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                }
            }

            stOutput += sHeaders + "\r\n";

            int selectedRowCount = studentDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            for (int k = 0; k < selectedRowCount; k++)
            {
                Console.WriteLine("K : " + k);
                int studentid = 0;
                try
                {
                    studentid = Convert.ToInt32(studentDataGridView.SelectedRows[k].Cells[0].Value);
                }
                catch (Exception ex)
                {
                    break;
                }

                Console.WriteLine("Student Id : " + studentid);
                studentCompentencyTableAdapter1.FillByStudentID(mathsToolDatabaseDataSet.StudentCompentency, studentid);
                Console.WriteLine("Table Adapter Row Count : " + studentCompetencyDataAdapter.RowCount);

                for (int i = 0; i < dGV.RowCount; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    {
                        if (j != 0)
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

            }

            Encoding utf16 = Encoding.UTF8;
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();

            var fileInfo = new FileInfo(filename) { IsReadOnly = true };
        }
    }
}
