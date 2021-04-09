using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class MenuSiang : Menu, LunchAddition
    {
        //derived class dari Menu
        private string[] daftarMenuSiang = { "Japanese Chicken Curry & Cauliflower Rich Salad",
                                    "Arugula Salad with Walnuts & Nasi Kuning Ayam Kremes",
                                    "Low-calory Shirataki Nasi Bali Tuna Sambal Matah",
                                    "Low-calory Shirataki & Diet-Friendly Soto Sapi" };
        private double[] menuSiangPrice = { 65_000, 54_000, 57_000, 49_500 };
        private string[] daftarSnackSiang = { "Fresh Blueberry Cream Cake", "Melon Custard",
                                    "Low-calory Fruit Punch Pudding", "Klepon Shirataki" };
        private double[] snackSiangPrice = { 10_000, 11_500, 12_000, 10_500 };

        public string[] DaftarMenuSiang { get; }
        public string[] DaftarSnackSiang { get; }
        public double[] MenuSiangPrice { get; }

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
