using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class kivetelClass
    {
        public kivetelClass() { }
        public void kivkeznincs()
        {
            Console.WriteLine("Nincs kivételekezelés!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);
            Console.ReadKey();
        }

        public void KivKezAlt()
        {
            Console.WriteLine("Hiba!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch
            {
                throw;
            }
            Console.ReadKey();
        }

        public void KivkezOS()
        {

            Console.WriteLine("Hiba!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
