using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class Order
    {
        private string orderStatus;
        private int orderId;
        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        //Jika user mengonfirmasi order, maka set menu beserta harganya akan ditampilkan
        public string ConfirmOrder(string OrderStatus, string menuSiang, double priceSiang, string snackSiang, double priceSnackSiang, string menuMalam, double priceMalam)
        {
            if (OrderStatus == "ya")
            {
                Console.WriteLine("~ Anda memesan:" +
                    "\n 1. {0} => {1} " +
                    "\n 2. {2} => {3}" +
                    "\n 3. {4} => {5}" +
                    "\n TOTAL = {6}", menuSiang, priceSiang, menuMalam, priceMalam, snackSiang, priceSnackSiang, priceSiang + priceMalam + priceSnackSiang);
            }
            else if (OrderStatus == "tidak")
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

            return OrderStatus;
        }
        //composition meng-generate OrderID
        public int GetOrderId()
        {
            Random random = new System.Random();
            OrderId = random.Next(50_000);
            return OrderId;
        }
    }
}
