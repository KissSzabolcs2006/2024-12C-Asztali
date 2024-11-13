using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class Tegla
    {
        protected double a, b, kerulet, terulet;

        public Tegla()
        {

        }

        public void SetKerület()
        {

            this.kerulet = 2 * (a + b);
        }
        public void SetTerület()
        {
            double eredmeny1 = 0.0;
            double eredmeny2 = 0.0;
            eredmeny2 = this.terulet = a * b;
            if (eredmeny2 != 0)
            {
                this.terulet = eredmeny1;
            }
        }
        public double GetKerulet()
        {
            return this.kerulet;
        }
        public double GetTerulet()
        {
            return this.terulet;
        }
    }
}
