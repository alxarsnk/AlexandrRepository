using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_5
{
    class Programm
    {
        static void Main(string[] args)
        {
            int n = 0, summ = 0, p, i;
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            if (a1 > a2)
            {
                p = a1;
                a1 = a2;
                a2 = p;
            }
            n = (a2 - a1) / s - 1;
            for (i = a2 - s; i >= a1 + s; i = i - s)
                summ = summ + i;

            Console.WriteLine($"Kol-vo={n} Summa={summ}");
            Console.ReadLine();


        }
    }
}
