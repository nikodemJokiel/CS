﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejct_13_1_dziedziczenie.classes
{
    internal class Loader : Machine
    {
        public Loader(string name) : base(name)
        {

        }
        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna łądowanie materiałów");
        }

        public void Load() 
        {
            Console.WriteLine($"{Name} ładuje materiał");
        }
        public override void Work()
        {
            Load();
        }

    }
}
