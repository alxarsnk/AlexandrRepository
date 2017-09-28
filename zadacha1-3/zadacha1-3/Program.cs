
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestrovka1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char x1 = char.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            char x2 = char.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            if (Math.Abs(x2 - x1) == 1 && Math.Abs(y1 - y2) == 2 || Math.Abs(x2 - x1) == 2 && Math.Abs(y1 - y2) == 1)
                Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}

