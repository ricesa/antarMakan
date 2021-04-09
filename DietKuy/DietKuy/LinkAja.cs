using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class LinkAja : PayMethod
    {
        //Metode pembayaran dengan LinkAja
        protected long linkAjaPhoneNumber;
        protected string ketLinkAja;
        public long LinkAjaPhoneNumber { get; set; }
        public string KetLinkAja { get; set; }
        public override void InputPhoneNumber()
        {
            Console.Write("Masukkan nomor (HP) LinkAja Anda: ");
            LinkAjaPhoneNumber = Convert.ToInt64(Console.ReadLine());
        }
        public void InputKeterangan()
        {
            Console.Write("Masukkan keterangan pembayaran LinkAja: ");
            KetLinkAja = Console.ReadLine();
        }
    }
}
