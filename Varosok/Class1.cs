using System;
using System.Collections.Generic;

public class Varosok
{
    private List<string> varosLista;

    public Varosok()
    {
        varosLista = new List<string>();
    }

    // setDb: Beállítjuk, hány nevet akarunk eltárolni
    public void SetDb()
    {
        Console.WriteLine("Hány városnevet szeretne eltárolni? (Üres bemenet esetén folytatás üres mezőig)");
        string bemenet = Console.ReadLine();
        int darabszam;

        if (int.TryParse(bemenet, out darabszam) && darabszam > 0)
        {
            for (int i = 0; i < darabszam; i++)
            {
                Console.Write($"Adja meg a(z) {i + 1}. város nevét: ");
                string nev = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nev))
                {
                    varosLista.Add(nev);
                }
            }
        }
        else
        {
            Console.WriteLine("Addig írjon városneveket, amíg nem ad üres bemenetet:");
            while (true)
            {
                Console.Write("Város neve: ");
                string nev = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nev)) break;
                varosLista.Add(nev);
            }
        }
    }

    // setNevek: Városneveket adunk hozzá a listához
    public void SetNevek()
    {
        Console.WriteLine("Addig írjon városneveket, amíg nem ad üres bemenetet:");
        while (true)
        {
            Console.Write("Város neve: ");
            string nev = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nev)) break;
            varosLista.Add(nev);
        }
    }

    // getNevek: Kiírja a listában lévő városneveket vesszővel elválasztva
    public void GetNevek()
    {
        if (varosLista.Count > 0)
        {
            Console.WriteLine("Tárolt városok: " + string.Join(", ", varosLista));
        }
        else
        {
            Console.WriteLine("A városlista üres.");
        }
    }

    // getVan: Megnézi, hogy egy adott város szerepel-e a listában
    public void GetVan()
    {
        Console.Write("Adjon meg egy városnevet, amelyet keresni szeretne: ");
        string keresettNev = Console.ReadLine();
        if (varosLista.Contains(keresettNev))
        {
            Console.WriteLine($"A(z) {keresettNev} szerepel a listában.");
        }
        else
        {
            Console.WriteLine($"A(z) {keresettNev} nem szerepel a listában.");
        }
    }

    // delNev: Törli vagy hozzáadja az adott városnevet
    public void DelNev()
    {
        Console.Write("Adjon meg egy városnevet: ");
        string nev = Console.ReadLine();
        if (varosLista.Contains(nev))
        {
            varosLista.Remove(nev);
            Console.WriteLine($"A(z) {nev} törölve lett a listából.");
        }
        else
        {
            varosLista.Add(nev);
            Console.WriteLine($"A(z) {nev} hozzáadva a listához.");
        }
    }

    // delLast: Törli az utolsó elemet a listából
    public void DelLast()
    {
        if (varosLista.Count > 0)
        {
            string utolsoNev = varosLista[varosLista.Count - 1];
            varosLista.RemoveAt(varosLista.Count - 1);
            Console.WriteLine($"A(z) {utolsoNev} törölve lett a listából.");
        }
        else
        {
            Console.WriteLine("A városlista üres, nincs mit törölni.");
        }
    }
}
