using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALS
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private string sex;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public void TypeOfAnimal()
        {
            Console.WriteLine("I am " + GetType().Name);
        }

        public static double Average(Animal[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i].Age;
            }
            return sum / array.Length;
        }
    }
}
