using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ha
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            if (b) Console.WriteLine("Ez az igaz");
            else Console.WriteLine("Ez a hamis");

            b = false;
            if (b) Console.WriteLine("Ez az igaz");
            else Console.WriteLine("Ez a hamis");

            Console.ReadLine();
        }
    }
}
