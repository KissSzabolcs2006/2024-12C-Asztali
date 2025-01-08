using System;

public class NegyszogClass
{
    private double oldal1;
    private double oldal2;
    private double terulet;
    private double kerulet;

    // Konstruktor1: Paraméter nélküli üres konstruktor
    public NegyszogClass()
    {
        oldal1 = 0;
        oldal2 = 0;
        terulet = 0;
        kerulet = 0;
    }

    // Konstruktor2: Egy paraméteres konstruktor (négyzet)
    public NegyszogClass(double oldal)
    {
        oldal1 = oldal;
        oldal2 = oldal;
        SetTerulet();
        SetKerulet();
    }

    // Konstruktor3: Két paraméteres konstruktor (téglalap)
    public NegyszogClass(double oldal1, double oldal2)
    {
        this.oldal1 = oldal1;
        this.oldal2 = oldal2;
        SetTerulet();
        SetKerulet();
    }

    // SetOldal1: Négyzet egy oldalának beállítása
    public void SetOldal1(double a)
    {
        oldal1 = a;
        oldal2 = a; // Négyzet esetén mindkét oldal azonos
        SetTerulet();
        SetKerulet();
    }

    // SetOldal2: Téglalap két oldalának beállítása
    public void SetOldal2(double a, double b)
    {
        oldal1 = a;
        oldal2 = b;
        SetTerulet();
        SetKerulet();
    }

    // SetTerulet: Terület kiszámítása
    public void SetTerulet()
    {
        terulet = oldal1 * oldal2;
    }

    // SetKerulet: Kerület kiszámítása
    public void SetKerulet()
    {
        kerulet = 2 * (oldal1 + oldal2);
    }

    // GetTerulet: Terület visszaadása
    public double GetTerulet()
    {
        return terulet;
    }

    // GetKerulet: Kerület visszaadása
    public double GetKerulet()
    {
        return kerulet;
    }

    // Osztály állapotának kiírása
    public override string ToString()
    {
        return $"Oldal1: {oldal1}, Oldal2: {oldal2}, Terület: {terulet}, Kerület: {kerulet}";
    }
}
