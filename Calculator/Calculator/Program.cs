using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arguments:");
            if (args.Length == 0)
            {
                Console.WriteLine("No Arguments!");
                return;
            }
            if (args.Length == 1)
            {
                Console.WriteLine("Need two Arguments!");
                return;
            }

            
            Console.WriteLine("Hello world!");

            Console.WriteLine($"{args[0]} + {args[1]} = { Convert.ToInt32(args[0]) + Convert.ToInt32(args[1])}");
        }
    }
}
