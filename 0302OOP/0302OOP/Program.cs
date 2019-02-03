using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintValues pv = new PrintValues();
            pv.Print("itay");
            pv.Print(5);

            Calculator c = new Calculator();
            int a = c.Add(1, 3);
            int b = c.Add("1", "3");

            Person p = new Person(1, "Moshe", "Tel aviv", 'M');

            
        }
    }
}
