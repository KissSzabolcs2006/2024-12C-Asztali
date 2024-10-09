using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Program
    {
        static void Main(string[] args)
        {
            //A kor osztály felhasználása
            #region 1-es Objektum
            //1. objektum
            Tegla k1 = new Tegla();
            k1.SetKerület();
            k1.SetTerület();
            Console.WriteLine($"A teglalap kerülete {k1.GetKerulet()} területe {k1.GetTerulet()}");
            Console.ReadLine();
            #endregion
        }
    }
}
