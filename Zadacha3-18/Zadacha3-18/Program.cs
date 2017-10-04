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
        { int i, x, n,j,d=0, b = 2;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] c = new int[n];
            var array = Console.ReadLine().Split(' ');
            for (i = 0; i < n; i++)
            {
                x = int.Parse(array[i]);
                
                    a[i] = x;
                    for (j = 0; j < 100; j++)
                        if (a[i] == Math.Pow(b, j))
                        {
                            c[d] = a[i];
                            d++;
                        }
                
            }

            for (i = 0; i < d; i++)
                Console.WriteLine(c[i]);

            Console.ReadKey();
        }
        
    }
    
}
