using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadacha3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x, n, j, d = 0, b = 2; int[] c=new int[50];
            x = int.Parse(Console.ReadLine());
            i = 0;
            while (x != 0)
            {
                
                for (i = 0; i < 25; i++)
                 if (x == Math.Pow(b, i))
                    {
                        
                        c[d] = x;
                        d++;
                    }
                x = int.Parse(Console.ReadLine());

            }
            for(i=0;i<d;i++)
            Console.WriteLine($"{c[i]}");
            Console.ReadKey();
        }

    }

}

