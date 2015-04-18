using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal, ISound
    {
        public Cat(int age, string name, char sex)
            : base(age, name, sex)
        { 
            
        }
        public void ProduceSound()
        {
            Console.WriteLine(Name + " says meau.");
        }
    }
}
