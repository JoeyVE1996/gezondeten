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
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void CalculateBMI()
        {
            if (FilledIn())
            {
                double bmi = PerformCalculation();
                outputAdvise.Text = GetAdvice(bmi);
                outputBMI.Text = bmi.ToString();
            }
        }

        private string GetAdvice(double bmi)
        {
            string advice = "";
            if (bmi < 18.5)
            {
                advice = "U heeft ondergewicht.";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
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
            return advice;
        }

        private double PerformCalculation()
        {
            int weight = int.Parse(inputWeight.Text);
            double length = double.Parse(inputLength.Text);
            length = length / 100;
            return Math.Ceiling(weight / (length * length));
        }

        private bool FilledIn()
        {
            return inputLength.Text.Length > 0 && inputWeight.Text.Length > 0;
        }
    }
}
