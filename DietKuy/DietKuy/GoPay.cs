using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class GoPay : PayMethod
    {
        //Metode pembayaran dengan GoPay
        protected long goPayPhoneNumber;

        public long GoPayPhoneNumber { get; set; }
        public override void InputPhoneNumber()
        {
            Console.Write("Masukkan nomor (HP) GoPay Anda: ");
            GoPayPhoneNumber = Convert.ToInt64(Console.ReadLine());
        }
    }
}
