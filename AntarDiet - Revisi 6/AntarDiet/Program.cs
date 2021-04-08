using System;

namespace AntarDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================____  APLIKASI ANTAR DIET ____=============================");
            Console.WriteLine("\n \nAplikasi ini merekomendasikan Anda menu diet sehat dengan pertimbangan BMI.");
            Console.WriteLine("Anda dapat pula memesan menu diet yang direkomendasikan dengan layanan antar ke rumah.\n");

            //Instancing
            User user = new User();
            BMI bmi = new BMI();
            MenuSiang siang = new MenuSiang();
            MenuMalam malam = new MenuMalam();
            Order order = new Order();
            Payment payment = new Payment();
            Address address = new Address();
            PayMethod shopeePay = new ShopeePay();
            PayMethod goPay = new GoPay();
            PayMethod linkAja = new LinkAja();
            TriggerPayMethod TriggerPayMethod = new TriggerPayMethod();
            ////////////////////////////////

            //Input nama pengguna
            Console.Write("~ Masukkan nama Anda: ");
            user.Name = Console.ReadLine();

            //Input tinggi badan
            Console.Write("~ Masukkan tinggi badan Anda (dalam meter| misal 1.7): ");
            double height = user.BodyHeight = Convert.ToDouble(Console.ReadLine());

            //Input berat badan
            Console.Write("~ Masukkan berat badan Anda (dalam kg| misal 56): ");
            double weight = user.BodyWeight = Convert.ToDouble(Console.ReadLine());

            //Tampilkan BMI
            double bmiVal = bmi.CalculateBMI(weight, height);
            string bmiCateg = Convert.ToString(bmi.CategorizeBMI(bmiVal, out string bmiCategory));
            Console.WriteLine("\n~ BMI Anda adalah: {0}", Math.Round(bmiVal, 3));
            Console.WriteLine("~ Kategori BMI-nya adalah: {0}", bmiCategory);

            //Menu yang cocok
            int menuIndex = Convert.ToInt32(bmiCateg);
            string menuSiang = siang.ShowMenu(menuIndex);
            string menuMalam = malam.ShowMenu(menuIndex);
            string snackSiang = siang.ShowSnack(menuIndex);
            Console.WriteLine("\n~ Menu makan siang yang cocok untuk Anda adalah: {0}", menuSiang);
            Console.WriteLine("~ Menu makan siang yang cocok untuk Anda adalah: {0}", menuMalam);
            Console.WriteLine("~ Snack siang yang cocok untuk Anda adalah: {0}", snackSiang);

            
            double priceSiang = siang.ShowPrice(menuIndex);
            double priceMalam = malam.ShowPrice(menuIndex);
            double priceSnackSiang = siang.ShowSnackPrice(menuIndex);
            //Apakah pengguna jadi order?
            string orderStatus = order.ConfirmOrder(menuSiang, priceSiang, snackSiang, priceSnackSiang, menuMalam, priceMalam);

            //Input alamat
            address.AddMainAlamat();
            address.UtamaAlamat = Console.ReadLine();

            address.AddPostalCode();
            address.KodePos = Convert.ToInt32(Console.ReadLine());

            address.AddKetAlamat();
            address.KeteranganAlamat = Console.ReadLine();

            //Lanjut ke pembayaran?
            string paymentStatus = payment.LanjutPembayaran();

            //Show metode pembayaran
            payment.ShowPaymentMethod(paymentStatus);

            //Pilih metode pembayaran
            payment.ChoosePaymentMethod();
            int paymentChoice = payment.PaymentChoice;

            TriggerPayMethod.TriggerPay(paymentChoice);







            Console.ReadLine();
        }
    }
}
