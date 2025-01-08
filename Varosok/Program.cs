using System;

class Program
{
    static void Main(string[] args)
    {
        Varosok varosok = new Varosok();

        // Városnevek beállítása
        varosok.SetDb();

        // Városnevek kiírása
        varosok.GetNevek();

        // Város keresése
        varosok.GetVan();

        // Város hozzáadása vagy törlése
        varosok.DelNev();

        // Utolsó elem törlése
        varosok.DelLast();

        // Végső lista kiírása
        varosok.GetNevek();
    }
}
