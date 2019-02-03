using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP_2
{
    class Samsung : MobilePhone
    {
        public string theme;

        public Samsung(string number, string brand, string theme) : base(number, brand)
        {
            this.theme = theme;
        }
    }
}
