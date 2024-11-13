using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Henger : Kor
    {
        private double magassag,
            terfogat;

        public Henger(double r, double m) 
        {
            this.sugar = r;
            this.magassag = m;
            SetTerület();
            this.terfogat = this.terulet * this.magassag;
        }

        public double GetTerfogat()
        {
            return this.terfogat;
        }
        public double GetMagassag()
        {
            return this.magassag;
        }
    }
}
