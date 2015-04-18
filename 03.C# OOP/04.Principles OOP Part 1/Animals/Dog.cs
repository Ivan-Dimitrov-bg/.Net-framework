﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal, ISound
    {
        public Dog(int age, string name, char sex)
            : base(age, name, sex)
        {
        }
        public void ProduceSound()
        {
            Console.WriteLine(Name + " says bau.");
        }
    }
}
