using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class Order
    {
        private string orderStatus;
        public string OrderStatus { get; set; }
        public string ConfirmOrder(string menuSiang, double priceSiang, string snackSiang, double priceSnackSiang, string menuMalam, double priceMalam)
        {
                Console.Write("\n~ Apakah Anda ingin memesan menu tersebut? (ya/tidak) ==> ");
                orderStatus = Console.ReadLine();
            if (orderStatus == "ya")
            {
                Console.WriteLine("~ Anda memesan:" +
                    "\n 1. {0} => {1} " +
                    "\n 2. {2} => {3}" +
                    "\n 3. {4} => {5}" +
                    "\n TOTAL = {6}", menuSiang, priceSiang, menuMalam, priceMalam, snackSiang, priceSnackSiang, priceSiang + priceMalam + priceSnackSiang);
            }
            else if (orderStatus == "tidak")
            {
                Console.WriteLine("Anda tidak jadi memesan menu diet." +
                    "~ Terima kasih telah menggunakan jasa kami :D");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Harap masukkan 'ya' atau 'tidak', tanpa petik.");
                Environment.Exit(0);
            }

            return orderStatus;
        }
    }
}
