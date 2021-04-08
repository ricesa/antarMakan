using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class TriggerPayMethod
    {
        /*class tambahan untuk membantu memanggil metode-metode pembayaran
        agar kode lebih rapi.*/

        GoPay goPay = new GoPay();
        LinkAja linkAja = new LinkAja();
        ShopeePay shopeePay = new ShopeePay();

        public void TriggerPay(int paymentChoice)
        {
            if (paymentChoice == 1)
            {
                shopeePay.InputPhoneNumber();
                shopeePay.InputShopeeId();
            }
            else if (paymentChoice == 2)
            {
                goPay.InputPhoneNumber();
            }
            else if (paymentChoice == 3)
            {
                linkAja.InputPhoneNumber();
                linkAja.InputKeterangan();
            }
            else
            {
                Console.WriteLine("Harap masukkan angka dari metode yang tersedia!");
            }

            if(paymentChoice> 0 && paymentChoice <= 3)
                Console.WriteLine("\nTerima kasih. Pembayaran Anda segera diproses.");


        }
    }
}
