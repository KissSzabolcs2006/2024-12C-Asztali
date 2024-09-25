using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobbelem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int parat = 0;
            int paros = 0;

            while (true)
            {
                Console.WriteLine("Adj meg egy számot: ");
                int b = Convert.ToInt32(Console.ReadLine());

                a += b;
                if (b % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    parat++;
                }
                if (a > 100)
                {
                    break;
                }
            }
            Console.WriteLine("Páros: " + paros + "Páratlan: " + parat);

        }
    }
}
