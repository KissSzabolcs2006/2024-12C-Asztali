using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Kor
    {
        //Az osztáy feladata: A sugárból kiszámítja a kör területét, kerületét.

        //Osztályváltozók
        private double sugar, kerulet, terulet;

        //Konstruktorok
        public Kor()
        {

        }

        public Kor(double r)
        {
            this.sugar = r;
        }

        //Metódusok
        public void Readsugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerület()
        {
            
            this.kerulet = 2 * this.sugar * Math.PI;
        }
        public void SetTerület()
        {
            double eredmeny1 = 0.0;
            double eredmeny2 = 0.0;
            eredmeny2 = this.terulet= this.sugar*this.sugar*Math.PI;
            eredmeny1 = Math.Pow(this.sugar, 2)*Math.PI;
            if(eredmeny2 == eredmeny1)
            {
                this.terulet = eredmeny1;
            }
            else
            {
                Console.WriteLine($"Eredmény1 ({eredmeny1}) != Eredmeny2 ({eredmeny2})");
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
        public double GetSugar()
        {
            return this.sugar;
        }
    }
}
