using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_1
{
    class Program
    {
        static void Main(string[] args)
        { int i,k=0;
            int N = int.Parse(Console.ReadLine());
            for (i = N-1; i > 0; i--)
                k = k + i;
            Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}
