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
            Kor k1 = new Kor();
            k1.Readsugar(15.0);
            k1.SetKerület();
            k1.SetTerület();
            Console.WriteLine($"A {k1.GetSugar()} sugarú kör kerülete {k1.GetKerulet()} területe {k1.GetTerulet()}");
            Console.ReadLine();
            #endregion
            #region 2-es objektum
            Kor k2 = new Kor(28.7);
            k2.SetKerület();
            k2.SetTerület();
            Console.WriteLine($"A {k2.GetSugar()} sugarú kör kerülete {k2.GetKerulet()} területe {k2.GetTerulet()}");
            Console.ReadLine();
            #endregion
        }
    }
}
