using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5minutka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (y <= (x * x) && y >= x && x <= 0 && x >= -1 || x >= 0 && x <= 1 && y <= 0 && y >= -1)
                Console.WriteLine("+");

            else Console.WriteLine("-");
            Console.ReadKey();
        }
    }
}
