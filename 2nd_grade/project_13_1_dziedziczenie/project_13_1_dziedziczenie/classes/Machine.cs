﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proejct_13_1_dziedziczenie.classes
{
    internal class Machine
    {
        public string Name {  get; set; }
        public Machine (string name)
        {
            Name = name;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Name} została uruchomiona");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} została zatrzymana");
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} pracuje");
        }
    }
}
