using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, x, y, k=0, l=0;
                 double min = 100000000;
            double d;
            Console.WriteLine("VVedite koordinati centra");
            double x0 = double.Parse(Console.ReadLine());
            double y0 = double.Parse(Console.ReadLine());
            Console.WriteLine("VVedite dlinu radiusa");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("VVedite kolichestvo par");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("VVedite koordinat par");
            for (i = 0; i < n/2; i++)
            {
                for (j = 0; j < n; j++)
                {

                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());

                    d = Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y))-r;
                    if (d <= min && d > 0)
                    {
                        min = d;
                        k = x;
                        l = y;
                        
                    }
                    
                    
                }
            }
            if (min < 100000000)
                Console.WriteLine($"x={k}  y={l}");
            else Console.WriteLine("Нет такой точки");


                    Console.ReadKey();

        }
    }

}