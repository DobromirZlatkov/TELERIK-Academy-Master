using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Human
    {
        private int age;

        public int Age
        {
            get
            {
                return this.age;    
            }
            set 
            { 
                this.age = value;
                this.UpdateState();
            }
        }

        public string name;

        public string state;

        public Human(int age, string name)// konstruktor nqma return
        {
            this.age = age;
            this.name = name;

            UpdateState();
        }
        private void UpdateState()
        {
            if (this.age < 35)
            {
                this.state = "young";
            }
            else if (this.age >= 35 && this.age <= 65)
            {
                this.state = "middle-aged";
            }
            else
            {
                this.state = "past middle-aged";
            }
        }
        public void GetOlder()
        {
            this.Age++;
        }
        public static int GetAverageNumberOfHairs()
        {
            return 100000;
        }
        public static int GetAverageAge(params Human[] humans)
        {
            int sum = 0;
            foreach (var human in humans)
            {
                sum += human.Age;
            }
            return sum / humans.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human(20, "Joro");
            h.Age = 34;
            h.GetOlder();

            Human.GetAverageNumberOfHairs();
            
            Console.WriteLine(h.name + " " + h.Age + " " + h.state);           

            Human dobrovolec = new Human(90, "Pesho");
           
            Console.WriteLine(dobrovolec.name + " " + dobrovolec.Age + " " + dobrovolec.state);

            Console.WriteLine(Human.GetAverageAge(h, dobrovolec));
            
        }
    }
}
