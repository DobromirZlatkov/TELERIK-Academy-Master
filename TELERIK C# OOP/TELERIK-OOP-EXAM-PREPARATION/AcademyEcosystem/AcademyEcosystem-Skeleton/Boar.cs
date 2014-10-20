using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Boar : Animal, IHerbivore, ICarnivore
    {

        private const int BoarInitialSize = 4;
        private const int BoarBiteSize = 2;



        public Boar(string name, Point location)
            : base(name, location, BoarInitialSize)
        {           
        }

        public int EatPlant(Plant plant)
        {
            
            if (plant != null)
            { 
                this.Size++;
                return plant.GetEatenQuantity(BoarBiteSize);     
            }
            return 0;                              
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                 if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }           
            return 0;          
        }
    }
}
