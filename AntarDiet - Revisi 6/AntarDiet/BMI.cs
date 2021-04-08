using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class BMI
    {
        int menuIndex;
        double bmi;
        public int MenuIndex { get; set; }
        public double Bmi { get; set; }
        public double CalculateBMI(double bodyWeight, double bodyHeight)
        {
            bmi = bodyWeight / (bodyHeight * bodyHeight);
            return bmi;
        }
        public int CategorizeBMI(double bmi, out string bmiCategory)
        {
            if (bmi < 17)
            {
                menuIndex = 0;
                bmiCategory = "Kekurangan Berat Badan";
            } 
            else if (bmi >= 17 && bmi < 23){
                menuIndex = 1;
                bmiCategory = "Ideal";
            }
            else if (bmi >= 23 && bmi < 27)
            {
                menuIndex = 2;
                bmiCategory = "Kelebihan berat badan";
            }
            else
            {
                menuIndex = 3;
                bmiCategory = "Obesitas";
            }
            return menuIndex;
        }

        
    }

}
