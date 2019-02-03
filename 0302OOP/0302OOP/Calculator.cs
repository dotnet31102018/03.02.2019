using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP
{
    class Calculator
    {
        public Calculator()
        {

        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(string x , string y)
        {
            int a = Convert.ToInt32(x);
            int b = Convert.ToInt32(y);
            return a + b;
        }

    }
}
