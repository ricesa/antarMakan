using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    interface Menu
    {
        //Interface untuk base kelas MenuSiang dan MenuMalam
        string ShowMenu(int menuIndex);
        double ShowPrice(int menuIndex);
    }

}
