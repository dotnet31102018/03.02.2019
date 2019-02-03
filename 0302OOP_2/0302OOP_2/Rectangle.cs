using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP_2
{
    class Rectangle : Shape
    {

        public int a, b;

        public Rectangle(int a, int b, string name) : base (name)
        {
            this.a = a;
            this.b = b;
        }

        public virtual void CalcArea()
        {
            area = a * b;
        }

    }
}
