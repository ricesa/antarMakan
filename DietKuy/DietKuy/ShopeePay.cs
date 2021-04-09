using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class ShopeePay : PayMethod
    {
        //Metode pembayaran dengan ShopeePay
        protected long shopeePhoneNumber;
        protected string shopeePayId;
        public long ShopeePhoneNumber { get; set; }
        public string ShopeePayId { get; set; }
        public override void InputPhoneNumber()
        {
            Console.Write("Masukkan nomor (HP) Shopee Pay Anda: ");
            ShopeePhoneNumber = Convert.ToInt64(Console.ReadLine());
        }
        public void InputShopeeId()
        {
            Console.Write("Masukkan ID ShopeePay Anda: ");
            ShopeePayId = Console.ReadLine();
        }
    }
}
