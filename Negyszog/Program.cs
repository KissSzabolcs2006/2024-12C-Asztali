using System;

class Program
{
    static void Main(string[] args)
    {
        // Paraméter nélküli konstruktor
        NegyszogClass negyszog1 = new NegyszogClass();
        Console.WriteLine("Alapértelmezett állapot: " + negyszog1);

        // Egy paraméteres konstruktor (négyzet)
        NegyszogClass negyszog2 = new NegyszogClass(5);
        Console.WriteLine("Négyzet: " + negyszog2);

        // Két paraméteres konstruktor (téglalap)
        NegyszogClass negyszog3 = new NegyszogClass(4, 6);
        Console.WriteLine("Téglalap: " + negyszog3);

        // Négyzet oldalának beállítása
        negyszog1.SetOldal1(7);
        Console.WriteLine("Négyzet beállított oldallal: " + negyszog1);

        // Téglalap oldalainak beállítása
        negyszog1.SetOldal2(3, 8);
        Console.WriteLine("Téglalap beállított oldalakkal: " + negyszog1);

        // Terület és kerület lekérdezése
        Console.WriteLine("Terület: " + negyszog1.GetTerulet());
        Console.WriteLine("Kerület: " + negyszog1.GetKerulet());
    }
}
