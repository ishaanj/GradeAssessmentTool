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
            int temp = Convert.ToInt32(outof.Text);
            int temp2 = Convert.ToInt32(ticks.Text);
            if (temp == 12)
            {
                if (temp2 > 0 && temp2 <= 3)
                    temp2 = 1;
                else if (temp2 >= 4 && temp2 <= 6)
                    temp2 = 2;
                else if (temp2 >= 7 && temp2 <= 9)
                    temp2 = 3;
                else if (temp2 >= 10 && temp2 <= 12)
                    temp2 = 4;
                else if (temp2 == 0)
                    temp2 = 0;

            }
            if (temp == 16)
            {
                if (temp2 > 0 && temp2 <= 4)
                    temp2 = 1;
                else if (temp2 >= 5 && temp2 <= 8)
                    temp2 = 2;
                else if (temp2 >= 9 && temp2 <= 12)
                    temp2 = 3;
                else if (temp2 >= 13 && temp2 <= 16)
                    temp2 = 4;
                else if (temp2 == 0)
                    temp2 = 0;

            }
            if (temp == 8)
            {
                if (temp2 > 0 && temp2 <= 2)
                    temp2 = 1;
                else if (temp2 >= 3 && temp2 <= 4)
                    temp2 = 2;
                else if (temp2 >= 5 && temp2 <= 6)
                    temp2 = 3;
                else if (temp2 >= 7 && temp2 <= 8)
                    temp2 = 4;
                else if (temp2 == 0)
                    temp2 = 0;

            }
            if (temp == 4)
            {
                temp2 = temp2;

            }
            pointer.Text = Convert.ToString(temp2);
        }
    } 
}
