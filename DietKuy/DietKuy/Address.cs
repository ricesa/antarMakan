using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    class Address
    {
        private string utamaAlamat;
        private string keteranganAlamat;
        private int kodePos;

        public string UtamaAlamat { get; set; }
        public string KeteranganAlamat { get; set; }
        public int KodePos { get; set; }
        public void AddMainAlamat()
        {
            Console.WriteLine("\n=========__  FORMULIR ALAMAT PELANGGAN  __=========");
            Console.Write("==> Masukkan alamat: ");
        }
        public void AddPostalCode()
        {
            Console.Write("==> Masukkan kode pos: ");
        }
        public void AddKetAlamat()
        {
            Console.Write("==> Masukkan keterangan alamat: ");
        }
    }
}
