using System;
using System.Collections.Generic;
using System.Text;

namespace DietKuy
{
    abstract class PayMethod
    {
        //Base class untuk metode-metode pembayaran yang ada
        protected long phoneNumber;
        public long PhoneNumber { get; set; }
        public virtual void InputPhoneNumber() { }

    }
}
