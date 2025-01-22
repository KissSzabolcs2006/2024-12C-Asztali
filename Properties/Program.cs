﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ez a példa azt mutatja be, hogy a property féle deklaráció nem úgy hozza létre a privát osztályt.
 */

namespace Properties
{
    class Person
    {
        //Tagváltozók
        string name; //Osztályváltozók

        //Properly
        public string Name
        {
            get;
            set;
        }
        //Konstruktor
        public Person()
        {

        }
        //Setter, getter metódusok a name tagváltozóhoz
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "István";
            p.setName("Gábor");
            Console.WriteLine("p.Name: {0}", p.Name);
            Console.WriteLine("p.getName(): {0}", p.getName());
            Console.ReadLine();
        }
    }
}
