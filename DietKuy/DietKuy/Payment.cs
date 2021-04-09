using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class Payment
    {
        private int paymentChoice;
        private int paymentId;
        private string continuePayment;
        private string[] paymentMethodArr = { "1.ShopeePay", "2.GoPay", "3.LinkAja" };
        public int PaymentId { get; set; }
        public string ContinuePayment { get; set; }
        public int PaymentChoice { get; set; }
        public string[] PaymentMethodArr { get; }

        //Mengonfirmasi lanjut pembayaran
        public string LanjutPembayaran(string ContinuePayment)
        {
            if (ContinuePayment == "ya")
            {
                return "ya";
            }
            else if (ContinuePayment == "tidak")
            {
                return "tidak";
            }
            else return "Harap masukkan input yang benar!";
        }
        //Menampilkan metode pembayaran yang tersedia
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
        //Memilih metode pembayaran
        public void ChoosePaymentMethod()
        {
            Console.Write("\n~ Metode pilihan Anda (1/2/3): ");
            PaymentChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        //composition meng-generate PaymentID
        public int GetPaymentId()
        {
            Random random = new System.Random();
            PaymentId = random.Next(100_000);
            return PaymentId;
        }
    }
}
