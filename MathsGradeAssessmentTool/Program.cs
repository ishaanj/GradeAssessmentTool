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
        static StartTeacherForm startTeacherForm;

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

    }
}
