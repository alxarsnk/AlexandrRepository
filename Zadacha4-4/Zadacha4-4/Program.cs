using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 5)
                Console.WriteLine($"{x*x}");
            else 
            if (x % 5 == 0 && x % 10 != 0)
            {
                x = (x / 10 * x / 10 + 1) * 100 + 25;
                Console.WriteLine($"{x}");
            }
            else Console.WriteLine("Ne podxodit");
            Console.ReadKey();
        }
    }
}
