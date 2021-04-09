using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class BMI
    {
        private int menuIndex;
        private double bmi;
        private string bmiCategory;
        public int MenuIndex { get; set; }
        public double Bmi { get; set; }
        //Hitung nilai BMI
        public double CalculateBMI(double bodyWeight, double bodyHeight)
        {
            Bmi = bodyWeight / (bodyHeight * bodyHeight);
            return Bmi;
        }
        //Kategorisasi kondisi gizi tubuh berdasarkan nilai BMI
        public int CategorizeBMI(double bmi, out string bmiCategory)
        {
            if (bmi < 17)
            {
                MenuIndex = 0;
                bmiCategory = "Kekurangan Berat Badan";
            }
            else if (bmi >= 17 && bmi < 23)
            {
                MenuIndex = 1;
                bmiCategory = "Ideal";
            }
            else if (bmi >= 23 && bmi < 27)
            {
                MenuIndex = 2;
                bmiCategory = "Kelebihan berat badan";
            }
            else
            {
                MenuIndex = 3;
                bmiCategory = "Obesitas";
            }
            return MenuIndex;
        }


    }

}
