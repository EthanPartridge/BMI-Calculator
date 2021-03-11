using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1___BMI_Calculator
{
    public partial class Form1 : Form
    {
        // Data
        private double weight, heightIn, heightFt, sex, age;
        private double bmi, bfp, bfpd;
        private string bodyType;
        private double ibmi = 21.75; 
        private double iWeight, tHeightIn;
        private double cbmi = 703;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler method - Click on Calculate Button
        private void btCalculate_Click(object sender, EventArgs e)
        {
            //Step 1: parse the input values
            parseInputValue();

            //Step 2: calculate
            calculate();

            //Step 3: output
            showValue();
        }

        // Step 1
        private void parseInputValue()
        {
            this.age = double.Parse(tbAge.Text);
            this.sex = parseSex();
            this.weight = double.Parse(tbWeightLbs.Text);
            this.heightFt = double.Parse(tbHeightFt.Text);
            this.heightIn = double.Parse(tbHeightIn.Text);

            while ((this.sex = parseSex()) < 0)
            {
                MessageBox.Show("Please type Male or Female in sex.");
                tbSex.Text = "";
                tbSex.Focus();
                return;
            }
        }

        // Prevents most invalid inputs in Sex text box
        private double parseSex()
        {
            bool isMale = string.Equals(tbSex.Text.First().ToString().ToUpper(), "M");
            bool isFemale = string.Equals(tbSex.Text.First().ToString().ToUpper(), "F");
            if (isMale)
                return 1.0;
            else if (isFemale)
                return 0.0;
            else
                return -1.0;
        }

        // (Event handler method - Key Press in Age Text Box)
        // Only allows user to type numbers and periods and use backspace and delete in Age text box 
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        // (Event handler method - Key Press in Height(ft) Text Box)
        // Only allows user to type numbers and periods and use backspace and delete in Height(ft) text box 
        private void tbHeightFt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        // (Event handler method - Key Press in Height(in) Text Box)
        // Only allows user to type numbers and periods and use backspace and delete in Height(In) text box 
        private void tbHeightIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        // (Event handler method - Key Press in Weight(lbs) Text Box)
        // Only allows user to type numbers and periods and use backspace and delete in Weight(lbs) text box 
        private void tbWeightLbs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        // Step 2
        private void calculate()
        {
            // Calculate BMI
            BMI bmiObject = new BMI(this.weight, this.heightIn, this.heightFt);
            this.bmi = Math.Round(bmiObject.calculate(), 2);

            // Calculate BFP
            BFP bfpObject = new BFP(this.bmi, this.age, this.sex);
            this.bfp = Math.Round(bfpObject.calculate(), 2);

            // Calculate BFP Description
            BFPDescription bfpdObject = new BFPDescription(this.age, this.sex, this.bfp);
            this.bfpd = bfpdObject.calculate();

            // double is returned from BFPDescription.cs, so logic intializes string as a certain value based on double value returned
            if (this.bfpd == 0.0)
            {
                this.bodyType = "too young to calculate";
            }
            if (this.bfpd == 1.0)
            {
                this.bodyType = "lean";
            }
            if (this.bfpd == 2.0)
            {
                this.bodyType = "ideal";
            }
            if (this.bfpd == 3.0)
            {
                this.bodyType = "average";
            }
            if (this.bfpd == 4.0)
            {
                this.bodyType = "above average";
            }

            // Calculate Ideal Weight
            tHeightIn = (this.heightFt * 12) + this.heightIn;               // calculates total height in inches
            iWeight = (this.ibmi * Math.Pow(tHeightIn, 2)) / this.cbmi ;    // calculates ideal weight
            iWeight = Math.Round(iWeight, 2);                               // rounds ideal weight to two decimal points

        }

        // Step 3
        private void showValue()
        {
            // Show BMI
            lblBMI.Text = "Your BMI value is: " + this.bmi;

            // Show BFP
            lblBodyFat.Text = "Your BF% value is: " + this.bfp;

            // Show BFP Description
            lblBFPD.Text = "Your BF% type is: " + this.bodyType;

            // Show Ideal Weight
            lblIDealWeightLbs.Text = "Your ideal weight is: " + this.iWeight + " lbs";
        }
    }
}
