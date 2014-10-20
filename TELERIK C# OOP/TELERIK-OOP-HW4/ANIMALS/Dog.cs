using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALS
{
    class Dog : Animal, ISound 
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        { 
        }
        public void ProduceSound()
        {
            Console.WriteLine(Name + " say Bau.");
        }
    }
}
