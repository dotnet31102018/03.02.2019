using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP_2
{
    class Sqaure : Rectangle
    {
        public Sqaure(int a, string name = "square") : base(a, a, name)
        {

        }

        public override void CalcArea()
        {
            area = a * b;
        }
    }
}
