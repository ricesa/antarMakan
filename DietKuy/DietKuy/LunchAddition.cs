using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    interface LunchAddition
    {
        /*Porsi makan siang lebih banyak dari makan malam, apalagi ketika sedang kerja berat, 
         * maka disediakan LunchAddition untuk makan siang saja. (menerapkan Interface Segregation Principle)*/
        string ShowSnack(int menuIndex);
        double ShowSnackPrice(int menuIndex);
    }
}
