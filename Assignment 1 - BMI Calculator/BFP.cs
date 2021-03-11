using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1___BMI_Calculator
{
    class BFP
    {
        // Class for calculating body fat percentage
        // Data
        private double bmi;
        private double age; //child < 18
        private double sex; //male = 1, female = 0 

        private double bfp;

        // Constructor
        public BFP(double bmi, double age, double sex)
        {
            this.bmi = bmi;
            this.age = age;
            this.sex = sex;
        }

        // Calculations
        public double calculate()
        {
            if (age < 18)
            {
                //Child body fat % = (1.51 × BMI) − (0.70 × Age) − (3.6 × sex) +1.4
                bfp = (1.51 * bmi) - (0.70 * age) - (3.6 * sex) + 1.4;
            }
            else
            {
                //Adult body fat % = (1.20 × BMI) + (0.23 × Age) − (10.8 × sex) − 5.4
                bfp = (1.20 * bmi) - (0.23 * age) - (10.8 * sex) + -5.4;
            }

            return Math.Round(bfp, 4);
        }
    }
}
