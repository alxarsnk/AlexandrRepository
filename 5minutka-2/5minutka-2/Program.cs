using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5minutka_2
{
    class Program
    {
        static void Main(string[] args)
        { double y1,y2,y;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a + b + c) / 3 > a * b * c)
                y1 = (a + b + c) / 3;
            else y1 = a * b * c;
            if (a > b)
                y2 = b / (a - b);
            else y2 = a / (b - a);
            y = y1 + y2;
            Console.WriteLine($"{y}");
            Console.ReadKey();

        }
    }
}
