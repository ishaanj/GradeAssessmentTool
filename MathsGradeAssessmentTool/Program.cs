using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGradeAssessmentTool
{
    static class Program
    {

        public static StartTeacherSelectForm sf;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sf = new StartTeacherSelectForm();
            Application.Run(sf);
        }


        static void HideAllFrames()
        {
            // Hide all the frames
            sf.Hide();

        }

        static void ShowFrame(Form f)
        {
            //Show specific frame
            HideAllFrames();
            f.Show();
        }
    }
}
