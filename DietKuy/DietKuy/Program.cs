using System;

namespace DietKuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================____  DIET_KUY ____=============================");
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

            //Tampilkan harga
            double priceSiang = siang.ShowPrice(menuIndex);
            double priceMalam = malam.ShowPrice(menuIndex);
            double priceSnackSiang = siang.ShowSnackPrice(menuIndex);

            //Apakah pengguna jadi order?
            Console.Write("\n~ Apakah Anda ingin memesan menu tersebut? (ya/tidak) ==> ");
            string orderStatus = order.OrderStatus = Console.ReadLine();
            order.ConfirmOrder(orderStatus, menuSiang, priceSiang, snackSiang, priceSnackSiang, menuMalam, priceMalam);

            //Tampilkan orderID
            user.ShowUserOrderId();

            //Input alamat
            address.AddMainAlamat();
            address.UtamaAlamat = Console.ReadLine();

            address.AddPostalCode();
            address.KodePos = Convert.ToInt32(Console.ReadLine());

            address.AddKetAlamat();
            address.KeteranganAlamat = Console.ReadLine();

            //Lanjut ke pembayaran?
            Console.Write("\n==> Lanjut ke pembayaran? ketik 'ya' atau 'tidak' => ");
            string continuePay = payment.ContinuePayment = Console.ReadLine();
            payment.LanjutPembayaran(continuePay);

            //Tampilkan metode pembayaran
            payment.ShowPaymentMethod(continuePay);

            //Pilih metode pembayaran
            payment.ChoosePaymentMethod();
            int paymentChoice = payment.PaymentChoice;

            //Panggil metode pembayaran yang dituju
            TriggerPayMethod.TriggerPay(paymentChoice);

            //Tampilkan PaymentId
            user.ShowUserPaymentId();

            Console.ReadLine();
        }
    }
}
