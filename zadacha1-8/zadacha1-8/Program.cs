using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestrovka1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double r1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double r2 = double.Parse(Console.ReadLine());
            if (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)) <= (r1 + r2) && Math.Abs(r1 - r2) <= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)))
                Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadKey();

        }
    }
}
