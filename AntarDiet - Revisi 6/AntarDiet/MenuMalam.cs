using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class MenuMalam: Menu
    {
        string[] daftarMenuMalam = { "Nasgorr", "sate 200", "bakso horor", "cumi gelap" };
        double[] menuMalamPrice = { 10000, 20000, 30000, 40000};
        public string[] DaftarMenuMalam { get; set; }
        public double[] MenuMalamPrice { get; set; }

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
