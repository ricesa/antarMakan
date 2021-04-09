using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class MenuMalam : Menu
    {
        //derived class dari Menu
        string[] daftarMenuMalam = { "Beef Steak with Smoked Asparagus", "Ginger Marinated Chicken With Vegetables",
                                        "Low-Calorie Nasi kremes ayam marinasi", "Low-Calorie Nasi Kuning Tuna" };
        double[] menuMalamPrice = { 65_000, 45_500, 41_500, 46_000 };
        public string[] DaftarMenuMalam { get; }
        public double[] MenuMalamPrice { get; }

        public string ShowMenu(int menuIndex)
        {
            return daftarMenuMalam[menuIndex];
        }
        public double ShowPrice(int menuIndex)
        {
            return menuMalamPrice[menuIndex];
        }
    }
}
