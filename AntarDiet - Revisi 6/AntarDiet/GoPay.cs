using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class GoPay: PayMethod
    {
        protected long goPayPhoneNumber;

        public long GoPayPhoneNumber { get; set; }
        public override void InputPhoneNumber()
        {
            Console.Write("Masukkan nomor (HP) GoPay Anda: ");
            GoPayPhoneNumber = Convert.ToInt64(Console.ReadLine());
        }
    }
}
