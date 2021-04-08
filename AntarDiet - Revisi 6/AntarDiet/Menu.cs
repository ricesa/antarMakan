using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    interface Menu
    {
        string ShowMenu(int menuIndex);
        double ShowPrice(int menuIndex);
    }
    interface LunchAddition
    {
        /*Porsi makan siang lebih banyak dari makan malam, apalagi ketika sedang kerja berat, 
         * maka disediakan LunchAddition untuk makan siang saja. (menerapkan Interface Sgregation Principle)*/
        string ShowSnack(int menuIndex);
        double ShowSnackPrice(int menuIndex);
    }
}
