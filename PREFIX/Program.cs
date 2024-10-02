using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREFIX
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"Az x eredeti értéke {x}");
            Console.WriteLine($"Az x értéke '++x' iratással ({x++}) az");
            Console.WriteLine($"Az érték után: {x}");

            Console.WriteLine($"\n Az y eredeti értéke {y}");
            Console.WriteLine($"Az y értéke '++y' iratással ({y++}) az");
            Console.WriteLine($"Az érték után: {y}");

            Console.ReadLine();
        }
    }
}
