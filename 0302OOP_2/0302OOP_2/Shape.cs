using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP_2
{
    public abstract class Shape
    {
        public string name;
        public double area;

        public Shape(string name)
        {
            this.name = name;
        }
    }
}
