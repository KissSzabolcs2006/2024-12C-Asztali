using System;

class Program
{
    static void Main(string[] args)
    {
        // Objektum létrehozása
        MagasOOP magas = new MagasOOP(10.0, 50.0);

        // Magasság számítása
        Console.WriteLine("Magasság: " + magas.MagassagSzamitas() + " egység"); // Kimenet: 40

        // Alaphely és csúcspont frissítése
        magas.SetAlaphely(15.0);
        magas.SetCsucspont(60.0);

        // Új értékek lekérdezése
        Console.WriteLine("Alaphely: " + magas.GetAlaphely()); // Kimenet: 15.0
        Console.WriteLine("Csúcspont: " + magas.GetCsucspont()); // Kimenet: 60.0

        // Szöveges megjelenítés
        Console.WriteLine(magas); // Kimenet: Tereptárgy magassága: 45.0 egység ...
    }
}