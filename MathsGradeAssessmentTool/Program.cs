using MathsGradeAssessmentTool.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGradeAssessmentTool
{
    static class Program
    {
        public static StartTeacherForm startTeacherForm;
        public static CompentencyEditForm compentencyEditForm;
        public static StudentCompentency studentCompentencyForm;
        public static StudentDetailsForm studentDetailsForm;
        public static StudentSelectForm studentSelectForm;
        public static SubjectEditForm subjectEditForm;
        public static TeacherDetailsForm teacherDetailsForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startTeacherForm = new StartTeacherForm();
            Application.Run(startTeacherForm);
        }


        public static void HideAllFrames()
        {
            // Hide all the frames
            startTeacherForm.Hide();

            if (compentencyEditForm != null)
                compentencyEditForm.Hide();

            if (studentCompentencyForm != null)
                studentCompentencyForm.Hide();

            if (studentDetailsForm != null)
                studentDetailsForm.Hide();

            if (studentSelectForm != null)
                studentSelectForm.Hide();

            if (subjectEditForm != null)
                subjectEditForm.Hide();

            if (teacherDetailsForm != null)
                teacherDetailsForm.Hide();

        }

        public static void ShowFrame(Form f)
        {
            //Show specific frame
            HideAllFrames();

            if(f != null)
                f.Show();
            else
            {
                MessageBox.Show("Form is null.");    
            }
        }
    }
}
