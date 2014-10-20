using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = 
            {
                new Dog("FirstDog", 12, "male"),                
                new Dog("SecondDog", 2, "female"),                
                new Dog("ThirdDog", 3, "female"),                
                new Dog("FourthDog", 20, "male"),
            };
            Cat[] cats = 
            {
                new Cat("FirstCat", 12, "male"),                
                new Cat("SecondCat", 2, "female"),                
                new Cat("ThirdCat", 3, "female"),                
                new Cat("FourthCat", 20, "male"),
            };
            Frog[] frogs = 
            {
                new Frog("FirstFrog", 12, "male"),                
                new Frog("SecondFrog", 2, "female"),                
                new Frog("ThirdFrog", 3, "female"),                
                new Frog("FourthFrog", 20, "male"),
            };

            dogs[1].TypeOfAnimal();
            cats[3].TypeOfAnimal();
            frogs[2].TypeOfAnimal();

            dogs[2].ProduceSound();
            cats[3].ProduceSound();
            frogs[2].ProduceSound();

            Console.WriteLine("Average age of dogs " + Animal.Average(dogs));
            Console.WriteLine("Average age of cats " + Animal.Average(cats));
            Console.WriteLine("Average age of frogs " + Animal.Average(frogs));
        }
    }
}
