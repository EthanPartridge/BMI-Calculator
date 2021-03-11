using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1___BMI_Calculator
{
    class BFPDescription
    {
        // Class for calculating body fate percentage description
        // Data
        private double age;
        private double sex;
        private double bfp;
        private double bfpd; // body fate percentage description

        // Constructor
        public BFPDescription(double age, double sex, double bfp)
        {
            this.age = age;
            this.sex = sex;
            this.bfp = bfp;
        }

        // Categorization Conditionals
        public double calculate()
        {
            // Males
            if (sex == 1.0)
            {
                // Ages 17 and below
                if (age < 18.0)
                {
                    bfpd = 0.0;
                }

                // Ages 18 - 20
                if (age >= 18.0 && age <= 20.0 && bfp <= 6.2)
                {
                    bfpd = 1.0;
                }
                if (age >= 18.0 && age <= 20.0 && bfp > 6.2 && bfp <= 14.3)
                {
                    bfpd = 2.0;
                }
                if (age >= 18.0 && age <= 20.0 && bfp > 14.3 && bfp <= 20.2)
                {
                    bfpd = 3.0;
                }
                if (age >= 18.0 && age <= 20.0 && bfp > 20.2)
                {
                    bfpd = 4.0;
                }

                // Ages 21 - 25
                if (age >= 21.0 && age <= 25.0 && bfp <= 7.3)
                {
                    bfpd = 1.0;
                }
                if (age >= 21.0 && age <= 25.0 && bfp > 7.3 && bfp <= 15.4)
                {
                    bfpd = 2.0;
                }
                if (age >= 21.0 && age <= 25.0 && bfp > 15.4 && bfp <= 21.2)
                {
                    bfpd = 3.0;
                }
                if (age >= 21.0 && age <= 25.0 && bfp > 21.2)
                {
                    bfpd = 4.0;
                }

                // Ages 26 - 30
                if (age >= 26.0 && age <= 30.0 && bfp <= 8.4)
                {
                    bfpd = 1.0;
                }
                if (age >= 26.0 && age <= 30.0 && bfp > 8.4 && bfp <= 16.4)
                {
                    bfpd = 2.0;
                }
                if (age >= 26.0 && age <= 30.0 && bfp > 16.4 && bfp <= 22.3)
                {
                    bfpd = 3.0;
                }
                if (age >= 26.0 && age <= 30.0 && bfp > 22.3)
                {
                    bfpd = 4.0;
                }

                // Ages 31 - 35
                if (age >= 31.0 && age <= 35.0 && bfp <= 11.7)
                {
                    bfpd = 1.0;
                }
                if (age >= 31.0 && age <= 35.0 && bfp > 11.7 && bfp <= 17.5)
                {
                    bfpd = 2.0;
                }
                if (age >= 31.0 && age <= 35.0 && bfp > 17.5 && bfp <= 24.5)
                {
                    bfpd = 3.0;
                }
                if (age >= 31.0 && age <= 35.0 && bfp > 24.5)
                {
                    bfpd = 4.0;
                }

                // Ages 36 - 40
                if (age >= 36.0 && age <= 40.0 && bfp <= 12.7)
                {
                    bfpd = 1.0;
                }
                if (age >= 36.0 && age <= 40.0 && bfp > 12.7 && bfp <= 20.2)
                {
                    bfpd = 2.0;
                }
                if (age >= 36.0 && age <= 40.0 && bfp > 20.2 && bfp <= 25.6)
                {
                    bfpd = 3.0;
                }
                if (age >= 36.0 && age <= 40.0 && bfp > 25.6)
                {
                    bfpd = 4.0;
                }

                // Ages 41 - 45
                if (age >= 41.0 && age <= 45.0 && bfp <= 13.8)
                {
                    bfpd = 1.0;
                }
                if (age >= 41.0 && age <= 45.0 && bfp > 13.8 && bfp <= 21.3)
                {
                    bfpd = 2.0;
                }
                if (age >= 41.0 && age <= 45.0 && bfp > 21.3 && bfp <= 26.6)
                {
                    bfpd = 3.0;
                }
                if (age >= 41.0 && age <= 45.0 && bfp > 26.6)
                {
                    bfpd = 4.0;
                }

                // Ages 46 - 50
                if (age >= 46.0 && age <= 50.0 && bfp <= 14.8)
                {
                    bfpd = 1.0;
                }
                if (age >= 46.0 && age <= 50.0 && bfp > 14.8 && bfp <= 22.4)
                {
                    bfpd = 2.0;
                }
                if (age >= 46.0 && age <= 50.0 && bfp > 22.4 && bfp <= 27.7)
                {
                    bfpd = 3.0;
                }
                if (age >= 46.0 && age <= 50.0 && bfp > 27.2)
                {
                    bfpd = 4.0;
                }

                // Ages 51 - 55
                if (age >= 51.0 && age <= 55.0 && bfp <= 15.9)
                {
                    bfpd = 1.0;
                }
                if (age >= 51.0 && age <= 55.0 && bfp > 15.9 && bfp <= 23.4)
                {
                    bfpd = 2.0;
                }
                if (age >= 51.0 && age <= 55.0 && bfp > 23.4 && bfp <= 29.7)
                {
                    bfpd = 3.0;
                }
                if (age >= 51.0 && age <= 55.0 && bfp > 29.7)
                {
                    bfpd = 4.0;
                }

                // Ages 56 and up
                if (age >= 56.0 && bfp <= 19.1)
                {
                    bfpd = 1.0;
                }
                if (age >= 56.0 && bfp > 19.1 && bfp <= 26.0)
                {
                    bfpd = 2.0;
                }
                if (age >= 56.0 && bfp > 26.0 && bfp <= 30.8)
                {
                    bfpd = 3.0;
                }
                if (age >= 56.0 && bfp > 30.8)
                {
                    bfpd = 4.0;
                }
            }

            // Females
            if (sex == 0.0)
            {
                // Ages 17 and below
                if (age < 18.0)
                {
                    bfpd = 0.0;
                }

                // Ages 18 - 20
                if (age >= 18.0 && age <= 20.0 && bfp <= 17.7)
                {
                    bfpd = 1.0;
                }
                if (age >= 18.0 && age <= 20.0 && bfp > 17.7 && bfp <= 23.2)
                {
                    bfpd = 2.0;
                }
                if (age >= 18.0 && age <= 20.0 && bfp > 23.2 && bfp <= 30.2)
                {
                    bfpd = 3.0;
                }
                if (age >= 18.0 && age <= 20.0 && bfp > 30.2)
                {
                    bfpd = 4.0;
                }

                // Ages 21 - 25
                if (age >= 21.0 && age <= 25.0 && bfp <= 18.4)
                {
                    bfpd = 1.0;
                }
                if (age >= 21.0 && age <= 25.0 && bfp > 18.4 && bfp <= 23.8)
                {
                    bfpd = 2.0;
                }
                if (age >= 21.0 && age <= 25.0 && bfp > 23.8 && bfp <= 30.8)
                {
                    bfpd = 3.0;
                }
                if (age >= 21.0 && age <= 25.0 && bfp > 30.8)
                {
                    bfpd = 4.0;
                }

                // Ages 26 - 30
                if (age >= 26.0 && age <= 30.0 && bfp <= 20.9)
                {
                    bfpd = 1.0;
                }
                if (age >= 26.0 && age <= 30.0 && bfp > 20.9 && bfp <= 26.1)
                {
                    bfpd = 2.0;
                }
                if (age >= 26.0 && age <= 30.0 && bfp > 26.1 && bfp <= 31.5)
                {
                    bfpd = 3.0;
                }
                if (age >= 26.0 && age <= 30.0 && bfp > 31.5)
                {
                    bfpd = 4.0;
                }

                // Ages 31 - 35
                if (age >= 31.0 && age <= 35.0 && bfp <= 21.5)
                {
                    bfpd = 1.0;
                }
                if (age >= 31.0 && age <= 35.0 && bfp > 21.5 && bfp <= 26.7)
                {
                    bfpd = 2.0;
                }
                if (age >= 31.0 && age <= 35.0 && bfp > 26.7 && bfp <= 32.1)
                {
                    bfpd = 3.0;
                }
                if (age >= 31.0 && age <= 35.0 && bfp > 32.1)
                {
                    bfpd = 4.0;
                }

                // Ages 36 - 40
                if (age >= 36.0 && age <= 40.0 && bfp <= 22.2)
                {
                    bfpd = 1.0;
                }
                if (age >= 36.0 && age <= 40.0 && bfp > 22.2 && bfp <= 27.3)
                {
                    bfpd = 2.0;
                }
                if (age >= 36.0 && age <= 40.0 && bfp > 27.3 && bfp <= 33.8)
                {
                    bfpd = 3.0;
                }
                if (age >= 36.0 && age <= 40.0 && bfp > 33.8)
                {
                    bfpd = 4.0;
                }

                // Ages 41 - 45
                if (age >= 41.0 && age <= 45.0 && bfp <= 22.8)
                {
                    bfpd = 1.0;
                }
                if (age >= 41.0 && age <= 45.0 && bfp > 13.8 && bfp <= 27.9)
                {
                    bfpd = 2.0;
                }
                if (age >= 41.0 && age <= 45.0 && bfp > 27.9 && bfp <= 34.4)
                {
                    bfpd = 3.0;
                }
                if (age >= 41.0 && age <= 45.0 && bfp > 34.4)
                {
                    bfpd = 4.0;
                }

                // Ages 46 - 50
                if (age >= 46.0 && age <= 50.0 && bfp <= 23.4)
                {
                    bfpd = 1.0;
                }
                if (age >= 46.0 && age <= 50.0 && bfp > 23.4 && bfp <= 28.6)
                {
                    bfpd = 2.0;
                }
                if (age >= 46.0 && age <= 50.0 && bfp > 28.6 && bfp <= 35.0)
                {
                    bfpd = 3.0;
                }
                if (age >= 46.0 && age <= 50.0 && bfp > 35.0)
                {
                    bfpd = 4.0;
                }

                // Ages 51 - 55
                if (age >= 51.0 && age <= 55.0 && bfp <= 25.9)
                {
                    bfpd = 1.0;
                }
                if (age >= 51.0 && age <= 55.0 && bfp > 25.9 && bfp <= 30.7)
                {
                    bfpd = 2.0;
                }
                if (age >= 51.0 && age <= 55.0 && bfp > 30.7 && bfp <= 36.6)
                {
                    bfpd = 3.0;
                }
                if (age >= 51.0 && age <= 55.0 && bfp > 36.6)
                {
                    bfpd = 4.0;
                }

                // Ages 56 and up
                if (age >= 56.0 && bfp <= 26.5)
                {
                    bfpd = 1.0;
                }
                if (age >= 56.0 && bfp > 26.5 && bfp <= 31.3)
                {
                    bfpd = 2.0;
                }
                if (age >= 56.0 && bfp > 31.3 && bfp <= 37.2)
                {
                    bfpd = 3.0;
                }
                if (age >= 56.0 && bfp > 37.2)
                {
                    bfpd = 4.0;
                }
            }

            return bfpd;
        }
    }
}
