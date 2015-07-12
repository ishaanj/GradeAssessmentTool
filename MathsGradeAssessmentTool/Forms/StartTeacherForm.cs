using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathsGradeAssessmentTool.Forms
{
    public partial class StartTeacherForm : Form
    {
        private int[] teacherIDS;
        private int[] schoolIDS;
        private SecureString email, password;

        public StartTeacherForm()
        {
            InitializeComponent();
            email = EncryptionClass.DecryptString(Convert.ToString(MathsGradeAssessmentTool.Properties.Settings.Default["EmailIdE"]));
            password = EncryptionClass.DecryptString(Convert.ToString(MathsGradeAssessmentTool.Properties.Settings.Default["PasswordE"]));

            if (!string.IsNullOrEmpty(EncryptionClass.ToInsecureString(email)))
                mailFromBox.Text = EncryptionClass.ToInsecureString(email);

            if (!string.IsNullOrEmpty(EncryptionClass.ToInsecureString(password)))
                mailFromPwdBox.Text = EncryptionClass.ToInsecureString(password);
        }

        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void teacherBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.teacherBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathsToolDatabaseDataSet);

        }

        private void StartTeacherForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.mathsToolDatabaseDataSet.School);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Competency' table. You can move, or remove it, as needed.
            this.competencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.Competency);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.StudentCompentency' table. You can move, or remove it, as needed.
            this.studentCompentencyTableAdapter.Fill(this.mathsToolDatabaseDataSet.StudentCompentency);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.mathsToolDatabaseDataSet.Teacher);

            int count = teacherTableAdapter.GetData().Count;
            teacherIDS = new int[count];

            DataRowCollection rows = teacherTableAdapter.GetData().Rows;

            for (int i = 0; i < count; i++)
            {
                teacherIDS[i] = Convert.ToInt32(rows[i]["TeacherID"]);
            }

            count = schoolTableAdapter.GetData().Count;
            schoolIDS = new int[count];

            rows = schoolTableAdapter.GetData().Rows;

            for (int i = 0; i < count; i++)
            {
                schoolIDS[i] = Convert.ToInt32(rows[i]["SchoolID"]);
            }

        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            TeacherDetailsForm tdf = new TeacherDetailsForm();
            tdf.Show();
            this.Hide();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            StudentDetailsForm sdf = new StudentDetailsForm();
            sdf.Show();
            this.Hide();
        }

        private void AddCompetency_Click(object sender, EventArgs e)
        {
            CompentencyEditForm cef = new CompentencyEditForm();
            cef.Show();
            this.Hide();
        }

        private void AddSubjectClicked_Clicked(object sender, EventArgs e)
        {
            SubjectEditForm sef = new SubjectEditForm();
            sef.Show();
            this.Hide();
        }

        private void SchoolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = SchoolComboBox.SelectedIndex;
            if (position >= 0)
            {
                int schoolid = schoolIDS[position];
                this.teacherTableAdapter.FillBySchoolID(this.mathsToolDatabaseDataSet.Teacher, schoolid);

                var teacherData = teacherTableAdapter.GetDataBySchoolID(schoolid);
                int count = teacherData.Count;
                teacherIDS = new int[count];

                DataRowCollection rows = teacherData.Rows;

                for (int i = 0; i < count; i++)
                {
                    teacherIDS[i] = Convert.ToInt32(rows[i]["TeacherID"]);
                }

                teacherBindingSource.DataSource = teacherData;

                position = teacherNameComboBox.SelectedIndex;
                if (position >= 0)
                {
                    int teacherID = teacherIDS[position];
                    fKStudentToTeacherBindingSource.DataSource = studentTableAdapter.GetDataByTeacherID(teacherID);

                    updateTeachersAverageScore(position);
                }
            }
            
        }

        private void onSelectedIndexChange(object sender, EventArgs e)
        {
            int position = teacherNameComboBox.SelectedIndex;
            if (position >= 0)
            {
                int teacherID = teacherIDS[position];
                fKStudentToTeacherBindingSource.DataSource = studentTableAdapter.GetDataByTeacherID(teacherID);

                updateTeachersAverageScore(position);
            }
        }

        private void updateTeachersAverageScore(int position)
        {
            double average = 0;
            int counter = 0;
            foreach (DataGridViewRow r in studentDataGridView.Rows)
            {
                Console.WriteLine(r.Cells[0].Value);
                int x = Convert.ToInt16(r.Cells[0].Value);

                var tab = studentCompentencyTableAdapter.GetDataByStudentID(x);
                foreach (DataRow d in tab)
                {
                    counter++;
                    average += Convert.ToDouble(d[11]);
                }
            }

            average = (double)average / counter;
            teacherBox.Text = average.ToString();
        }


        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gTotalWeightedTextBox.Text = "";
            gradeEquivalentTextBox.Text = "";
            double avgGrade = 0;
            //Todo: Add horizontal line at current grade            
            if (e.RowIndex >= 0)
            {
                StripLinesCollection strips = chart1.ChartAreas[0].AxisY.StripLines;
                try
                {

                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();

                    int currYear = (int)studentDataGridView.Rows[e.RowIndex].Cells[4].Value;

                    StripLine currentYear = new StripLine();
                    currentYear.Text = "Year";
                    currentYear.Interval = 0;
                    currentYear.IntervalOffset = (currYear) - 0.125;
                    currentYear.StripWidth = 0.25;
                    currentYear.BackColor = Color.FromArgb(64, Color.Blue);

                    if (strips.Count > 0)
                        strips.Clear();
                    strips.Add(currentYear);

                    chart1.Update();
                }
                catch (Exception ex) { }


                int id = (int)studentDataGridView.Rows[e.RowIndex].Cells[0].Value;
                int tid = (int)studentDataGridView.Rows[e.RowIndex].Cells[3].Value;

                if(tid > 0)
                    updateTeachersAverageScore(tid);

                var data = studentCompentencyTableAdapter.GetDataByStudentID(id);
                String name = "";

                if (data.Rows.Count > 0)
                {
                    int sumTotal = 0;
                    double sumGrade = 0.0;
                    int compCount = 0;
                    foreach (DataRow r in data.Rows)
                    {
                        compCount++;
                        sumTotal += Convert.ToInt32(r["GTotalWeighted"]);
                        sumGrade += Convert.ToDouble(r["GradeEquivalent"]);
                        
                        try
                        {
                            name = competencyTableAdapter.GetCompetencyNameByID((int)r[0])[0].CompetencyName;
                        }
                        catch (Exception ex) 
                        {
                            name = "Competency " + compCount;
                        }
                        if ((int)r[12] == (int)studentDataGridView.Rows[e.RowIndex].Cells[4].Value)
                            chart1.Series["Grades"].Points.AddXY(name, r[11]);
                        else
                            chart1.Series["Previous Year"].Points.AddXY(name, r[11]);
                    }
                   
                    gTotalWeightedTextBox.Text = sumTotal + "";
                    avgGrade = sumGrade / (double)data.Rows.Count;
                    gradeEquivalentTextBox.Text = avgGrade + "";

                    try
                    {
                        StripLine currentCompetency = new StripLine();
                        currentCompetency.Text = "Competency";
                        currentCompetency.Interval = 0;
                        currentCompetency.IntervalOffset = avgGrade - 0.25;
                        currentCompetency.StripWidth = 0.25;
                        currentCompetency.BackColor = Color.FromArgb(64, Color.OrangeRed);

                        strips.Add(currentCompetency);
                    }
                    catch (Exception ex) { }
                }

                
            }
            studentDataGridView.Rows[e.RowIndex].Cells[5].Value = avgGrade;

        }

        private void mail_Click(object sender, EventArgs e)
        {
            String id = mailFromBox.Text;
            String pwd = mailFromPwdBox.Text;

            if (!string.IsNullOrEmpty(id))
            {
                MathsGradeAssessmentTool.Properties.Settings.Default["EmailIdE"] = EncryptionClass.EncryptString(EncryptionClass.ToSecureString(id));
                MathsGradeAssessmentTool.Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Email ID cannot be empty");
                return;
            }

            if (!string.IsNullOrEmpty(pwd))
            {
                MathsGradeAssessmentTool.Properties.Settings.Default["PasswordE"] = EncryptionClass.EncryptString(EncryptionClass.ToSecureString(pwd));
                MathsGradeAssessmentTool.Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            MailForm mf = new MailForm(id, pwd);
            mf.Show();
            this.Hide();
        }

        private void AddSchoolButton_Click(object sender, EventArgs e)
        {
            SchoolEditForm sef = new SchoolEditForm();
            sef.Show();
            this.Hide();
        }

        

    }
}
