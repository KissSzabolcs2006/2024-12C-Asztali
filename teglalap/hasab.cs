using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    class hasab : Tegla 
    {
        private double terfogat, c, felszin;

        public hasab(double x, double y)
        {
            this.terfogat = x;
            this.felszin = y;
            SetTerület();
            this.terfogat = this.a * this.b * this.c;
            this.felszin = 2 * (a * b + a * c + c * b);
        }

        public double GetTerfogat()
        {
            return this.terfogat;
        }
        public double GetFelszin()
        {
            return this.felszin;
        }
    }
}
