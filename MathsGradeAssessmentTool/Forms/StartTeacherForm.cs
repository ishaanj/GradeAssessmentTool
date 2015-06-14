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

namespace MathsGradeAssessmentTool.Forms
{
    public partial class StartTeacherForm : Form
    {
        public StartTeacherForm()
        {
            InitializeComponent();
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
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.mathsToolDatabaseDataSet.Student);
            // TODO: This line of code loads data into the 'mathsToolDatabaseDataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.mathsToolDatabaseDataSet.Teacher);

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

        private void onSelectedIndexChange(object sender, EventArgs e)
        {
            String name = teacherNameComboBox.Text;
            Console.WriteLine(name);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MathsToolDatabase.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Teacher where TeacherName="+name,con);
            
            /*DataTable table = new DataTable();

            adapter.Fill(table);

            String id = table.Rows[0][0].ToString();
            Console.WriteLine(id);

            adapter = new SqlDataAdapter("Select * from Student where TeacherID = " + id, con);
            adapter.Fill(table);
             */

        }

    }
}
