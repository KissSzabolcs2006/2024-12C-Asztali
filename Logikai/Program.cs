﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logikai
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true,
                b = false;
            Console.WriteLine("Az és (&&) kapcsolat");
            Console.WriteLine($"Ha a={a} és b={b} akkor a&&b = {a && b}");

            a = true;
            b = true;

            Console.WriteLine($"Ha a={a} és b={b} akkor a&&b = {a && b}");
            a = false;
            b = true;

            Console.WriteLine($"Ha a={a} és b={b} akkor a&&b = {a && b}");
            a = false;
            b = false;

            Console.WriteLine($"Ha a={a} és b={b} akkor a&&b = {a && b}");
            Console.ReadLine();

            //---------------------------------------------------------------------------

            a = true;
            b = false;
            Console.WriteLine("\n Az vagy (||) kapcsolat");
            Console.WriteLine($"Ha a={a} és b={b} akkor a||b = {a || b}");

            a = true;
            b = true;

            Console.WriteLine($"Ha a={a} és b={b} akkor a||b = {a || b}");
            a = false;
            b = true;

            Console.WriteLine($"Ha a={a} és b={b} akkor a||b = {a || b}");
            a = false;
            b = false;

            Console.WriteLine($"Ha a={a} és b={b} akkor a||b = {a || b}");
            Console.ReadLine();
        }
    }
}
