using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class User
    {
        private string name;
        private string gender;
        private double bodyHeight;
        private double bodyWeight;

        public string Name { get; set; }
        public string Gender { get; set; }
        public double BodyHeight { get; set; }
        public double BodyWeight { get; set; }

        public string chooseGender(string gender)
        {
            if (gender == "male")
            {
                return "male";
            }
            else if (gender == "female")
            {
                return "female";
            }
            else
            {
                return "Silakan masukkan input yang sesuai!";
            }
        }


    }
}
