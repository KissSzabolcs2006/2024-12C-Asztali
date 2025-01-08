using System;

public class MagasOOP
{
    private double alaphely;
    private double csucspont;

    // Konstruktor
    public MagasOOP(double alaphely, double csucspont)
    {
        this.alaphely = alaphely;
        this.csucspont = csucspont;
    }

    // Magasság számítás
    public double MagassagSzamitas()
    {
        return csucspont - alaphely;
    }

    // Alaphely beállítása
    public void SetAlaphely(double ujAlaphely)
    {
        this.alaphely = ujAlaphely;
    }

    // Csúcspont beállítása
    public void SetCsucspont(double ujCsucspont)
    {
        this.csucspont = ujCsucspont;
    }

    // Alaphely lekérdezése
    public double GetAlaphely()
    {
        return alaphely;
    }

    // Csúcspont lekérdezése
    public double GetCsucspont()
    {
        return csucspont;
    }

    // Szöveges megjelenítés felülírása
    public override string ToString()
    {
        return $"Tereptárgy magassága: {MagassagSzamitas()} egység\n" +
               $"Alaphely: {alaphely} egység\n" +
               $"Csúcspont: {csucspont} egység";
    }
}
