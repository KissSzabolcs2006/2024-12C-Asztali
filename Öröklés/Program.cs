using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklés
{
    /*
     * virtuál és sealed kulcsszó használata
     * virtuál
     * A virtuál kulcsszóval egy property felülírható az override kulcsszó segítségével
     * sealed
     * A sealed kulcsszó lezárja az osztályt vagy metódust a további örökléstől vagy felülírásokról
     */
    internal class öröklésprog
    {
        class Allat
        {
            public string Name
            {
                get;
                set;
            }
            public string Hang
            {
                get;
                set;
            }

            public Allat()
            {
                this.Name = "Anonim";
                this.Hang = "Én egy állat vagyok";
            }

            public Allat(string name)
            {
                this.Name = name;
                this.Hang = "Én egy Allat vagyok";
            }
            public void hangotAd()
            {
                Console.WriteLine("Ezt a Allat.hangotAd() metódus írta ki");
                Console.ReadLine();
            }
            public virtual void mozog()
            {
                Console.WriteLine("Ezt a virtuális mozog() metódus írta ki.");
                Console.ReadLine();
            }
        }
        class Kutya : Allat
        {
            public Kutya() : base()
            {
                this.Hang = "Én egy kutya vagyok";
                Console.ReadLine();
            }

            public void hangotAd()
            {
                Console.WriteLine("Ezt a Kutya.hangotAd() metódus írta ki.");
                Console.ReadLine();
            }
            public sealed override void mozog()
            {
                Console.WriteLine("Ezt a lezárt mozog() metódus írta ki.");
                Console.ReadLine();
            }
        }
        
        class Komondor : Kutya
        {
            public Komondor() : base()
            {
                this.Name = "Komondor";
            }
            //Lezárt metódust nem írhatjuk felül

            public void mozog() { }
        }

        sealed class Macska : Allat
        {
            public Macska()
            {
                this.Name = "Cicamica";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
