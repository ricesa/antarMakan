using System;
using System.Collections.Generic;
using System.Text;

namespace AntarDiet
{
    abstract class PayMethod
    {
        protected long phoneNumber;
        public long PhoneNumber { get; set; }
        public virtual void InputPhoneNumber() { }

    }
}
