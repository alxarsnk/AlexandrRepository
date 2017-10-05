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
                        
                        
                        d=d+i;
                    }
                x = int.Parse(Console.ReadLine());

            }
            
            Console.WriteLine($"{d}");
            Console.ReadKey();
        }

    }

}

