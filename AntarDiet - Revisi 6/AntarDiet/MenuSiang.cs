using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class MenuSiang: Menu
    {
        string[] daftarMenuSiang = { "Oatmeal", "Buah salad", "pandan sari", "guacamole" };
        double[] menuSiangPrice = { 10000, 20000, 30000, 40000 };
        string[] daftarSnackSiang = { "kuda", "babi", "sapi", "picang" };
        double[] snackSiangPrice = { 10000, 20000, 30000, 40000 };

        public string[] DaftarMenuSiang { get; set; }
        public double[] MenuSiangPrice { get; set; }

        public string ShowMenu(int menuIndex)
        {
            return daftarMenuSiang[menuIndex];
        }
        public double ShowPrice(int menuIndex)
        {
            return menuSiangPrice[menuIndex];
        }
        public string ShowSnack(int menuIndex)
        {
            return daftarSnackSiang[menuIndex];
        }
        public double ShowSnackPrice(int menuIndex)
        {
            return snackSiangPrice[menuIndex];
        }
    }
}
