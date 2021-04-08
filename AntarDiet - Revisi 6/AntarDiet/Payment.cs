using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class Payment
    {
        private int paymentChoice;
        public int PaymentChoice { get; set; }

        string[] paymentMethodArr = { "1.ShopeePay", "2.GoPay", "3.LinkAja" };
        public string LanjutPembayaran()
        {
            Console.Write("\n==> Lanjut ke pembayaran? ketik 'ya' atau 'tidak' => ");
            string lanjutPembayaran = Console.ReadLine();

            if (lanjutPembayaran == "ya")
            {
                return "ya";
            }
            else if (lanjutPembayaran == "tidak")
            {
                return "tidak";
            }
            else return "Harap masukkan input yang benar!";
        }
        public void ShowPaymentMethod(string paymentStatus)
        {
            if (paymentStatus == "ya")
            {
                Console.WriteLine("\nMetode Pembayaran yang tersedia: ");
                for (int i = 0; i < paymentMethodArr.Length; i++)
                {
                    Console.WriteLine(paymentMethodArr[i]);
                }
            }
            else
            {
                Console.WriteLine("Anda tidak jadi melakukan pemesanan dan pembayaran. " +
                  "~ Terima kasih sudah menggunakan layanan kami");
                Environment.Exit(0);
            }
        }
        public void ChoosePaymentMethod()
        {
            Console.Write("\n~ Metode pilihan Anda (1/2/3): ");
            PaymentChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
