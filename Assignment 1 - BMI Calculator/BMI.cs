using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1___BMI_Calculator
{
    class BMI
    {
        // Class for calculating BMI
        // Data
        private double dWeight;
        private double dHeightIn;
        private double dHeightFt;
        private double bmi;
        const double bmi_const = 703.0; //constant keeps value from changing, an error will occur if value is changed

        //Constructor
        public BMI(double weight, double heightIn, double heightFt)
        {
            this.dWeight = weight;
            this.dHeightIn = heightIn;
            this.dHeightFt = heightFt;
        }

        //Calculations
        public double calculate()
        {
            this.dHeightIn += this.dHeightFt * 12;                                  // converts ft to in (in = ft*12+in)
            this.bmi = (this.dWeight * bmi_const) / Math.Pow(this.dHeightIn, 2.0);  // (mass/(height_in)^2) * 703
            return Math.Round(this.bmi, 4);                                         //returns value rounded to the 4th decimal
        }
    }
}
