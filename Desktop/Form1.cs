using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(inputWeight.Text);
            double length = double.Parse(inputLength.Text);
            length = length / 100;
            //int age = Int32.Parse(inputAge.Text);
            double bmi = Math.Ceiling(weight / (length * length));

            outputBMI.Text = bmi.ToString();

            string advice = "";
            if(bmi < 18.5)
            {
                advice = "U heeft ondergewicht.";
            }
            else if (bmi >= 18.5 && bmi < 25){
                advice = "U heeft een goed gewicht.";
            }
            else if (bmi >= 25 && bmi < 27)
            {
                advice = "U heeft licht overgewicht.";
            }
            else if (bmi >= 27 && bmi < 30)
            {
                advice = "U heeft matig overgewicht.";
            }
            else if (bmi >= 30 && bmi < 40)
            {
                advice = "U heeft ernstig overgewicht.";
            }
            else
            {
                advice = "U heeft gevaarlijk overgewicht.";
            }
            outputAdvise.Text = advice;
        }
    }
}
