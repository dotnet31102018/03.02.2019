using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP
{
    class PrintValues
    {
        // without overloading
        public void PrintInteger(int x)
        {
            Console.WriteLine($"integer {x}");
        }

        public void PrintString(string s)
        {
            Console.WriteLine($"string {s}");
        }

        // with overloading
        public void Print(int x)
        {
            Console.WriteLine($"integer {x}");
        }

        // this is compilation error
        //public int Print(int x)
        //{
        //    Console.WriteLine($"integer {x}");
        //    return 1;
        //}

        public void Print(string s)
        {
            Console.WriteLine($"string {s}");
        }



    }
}
