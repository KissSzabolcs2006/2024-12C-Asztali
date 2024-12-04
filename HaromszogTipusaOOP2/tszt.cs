using System;

namespace HaromszogTipusaOOP
{
    public class HTipus
    {
        private int a, b, c;

        public HTipus(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Az oldalaknak pozitív egész számoknak kell lenniük.");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Ellenőrzi, hogy az oldalak háromszöget alkotnak-e
        public bool HaromszogE()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Ellenőrzi, hogy derékszögű háromszög-e
        public bool DerekszoguE()
        {
            if (!HaromszogE()) return false;
            int[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        // Ellenőrzi, hogy egyenlő szárú háromszög-e
        public bool EgyenloSzarue()
        {
            if (!HaromszogE()) return false;
            return a == b || a == c || b == c;
        }

        // Ellenőrzi, hogy egyenlő oldalú háromszög-e
        public bool EgyenloOldaluE()
        {
            if (!HaromszogE()) return false;
            return a == b && b == c;
        }

        // Számolja a háromszög területét (Heron-képlet)
        public double Terulet()
        {
            if (!HaromszogE())
                throw new InvalidOperationException("Az adatok nem alkotnak háromszöget, így terület nem számítható.");
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        // Információ kiírása
        public void Kiir()
        {
            try
            {
                Console.WriteLine($"Oldalak: a={a}, b={b}, c={c}");
                Console.WriteLine(HaromszogE() ? "Ez egy háromszög." : "Ez nem háromszög.");
                if (HaromszogE())
                {
                    Console.WriteLine(DerekszoguE() ? "Ez egy derékszögű háromszög." : "Ez nem derékszögű háromszög.");
                    Console.WriteLine(EgyenloSzarue() ? "Ez egy egyenlő szárú háromszög." : "Ez nem egyenlő szárú háromszög.");
                    Console.WriteLine(EgyenloOldaluE() ? "Ez egy egyenlő oldalú háromszög." : "Ez nem egyenlő oldalú háromszög.");
                    Console.WriteLine($"A háromszög területe: {Terulet():0.00}");
                }
            }
            catch
            {
                Console.WriteLine($"Hiba történt!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Példa 1
                HTipus h1 = new HTipus(3, 4, 5);
                Console.WriteLine("Példa 1:");
                h1.Kiir();

                Console.WriteLine();

                // Példa 2
                HTipus h2 = new HTipus(5, 5, 5);
                Console.WriteLine("Példa 2:");
                h2.Kiir();

                Console.WriteLine();

                // Példa 3
                HTipus h3 = new HTipus(1, 2, 3);
                Console.WriteLine("Példa 3:");
                h3.Kiir();

                Console.WriteLine();

                // Példa 4: Hibás input (negatív oldalhossz)
                HTipus h4 = new HTipus(-3, 4, 5);
                Console.WriteLine("Példa 4:");
                h4.Kiir();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Hibás bemenet: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Érvénytelen művelet: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Váratlan hiba történt: {ex.Message}");
            }
        }
    }
}
