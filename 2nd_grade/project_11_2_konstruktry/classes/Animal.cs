﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_11_2_konstruktry.classes
{
    enum Kind
    {
        Ptak,
        Ryba,
        Gad,
        Płaz,
        Ssak
    }

    internal class Animal
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMammal { get; set; }
        public Kind Kind { get; set; }

        public Animal(string name)
        {
            Name = name;
            BirthDate = DateTime.Now; //DateTime.MinValue
            IsMammal = true;
            Kind = Kind.Ssak;
        }

        public Animal(string name, DateTime birthDate) : this(name)
        {
            BirthDate = birthDate;
        }

        public Animal(string name, DateTime birthDate, bool isMammal) : this(name, birthDate)
        {
            IsMammal = isMammal;
        }

        public Animal(string name, DateTime birthDate, bool isMammal, Kind kind) : this(name, birthDate, isMammal)
        {
            Kind = kind;
        }

        public string Describe()
        {
            string description = "Nazwa zwierzęcia: "  + Name + ". Data urodzenia: " + BirthDate.ToShortDateString()+"r. ";
            if (IsMammal)
            {
                description += "Zwierzę jest ssakiem. ";
            }
            else
            {
                description += "Zwierzę nie jest ssakiem. ";
            }

            description += "Rodzaj zwierzęcia " + Kind;
            return description;
        }

        public void ShowAge()
        {
            int age = DateTime.Now.Year -BirthDate.Year;
            Console.WriteLine($"Wiek {Name} wynosi: {age}");
        }



    }
}
