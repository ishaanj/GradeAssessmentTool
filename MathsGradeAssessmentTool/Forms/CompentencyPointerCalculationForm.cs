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
    public partial class CompentencyPointerCalculationForm : Form
    {
        public CompentencyPointerCalculationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(ticks.Text);
            double temp2;
            int i;
            int[] gradeEq = {0,4,12,24,40,60,84,112,144};

            for (i = 0; i < 9; i++ )
            {
                if (gradeEq[i] > temp)
                    break;
            }

            i--;
            temp = temp - gradeEq[i];
            temp2 = (double)temp / (gradeEq[i + 1] - gradeEq[i]);
            temp2 += i;

            pointer.Text = Convert.ToString(temp2);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            StartTeacherForm stf = new StartTeacherForm();
            stf.Show();
            this.Hide();
        }
    } 
}
