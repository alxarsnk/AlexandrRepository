using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 1;
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            { l = l * i; }
            l = l % 10;
            Console.WriteLine($"{l}");
            Console.ReadKey();
        }
    }
}