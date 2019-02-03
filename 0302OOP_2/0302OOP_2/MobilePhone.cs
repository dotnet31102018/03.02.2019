using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP_2
{
    abstract class MobilePhone
    {
        public string number;
        public string brand;


        public MobilePhone(string number)
        {
            this.number = number;
    }

        public MobilePhone(string number, string brand) : this(number)
        {
            this.brand = brand;
        }
    }
}
