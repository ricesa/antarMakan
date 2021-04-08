using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    class ShopeePay: PayMethod
    {
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
