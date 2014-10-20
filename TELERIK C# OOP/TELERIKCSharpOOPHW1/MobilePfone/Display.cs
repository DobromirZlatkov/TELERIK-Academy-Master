using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePfone
{
    class Display
    {
        private double sizeInInches;
        private double numberOfColors;
        //constructor second task
        public Display()
        {
            this.sizeInInches = 0;
            this.numberOfColors = 0;
        }
        public Display(double sizeInInches)
        {
            this.sizeInInches = sizeInInches;
        }
        public Display(double sizeInInches, double numberOfColors)
            : this(sizeInInches)
        {
            this.numberOfColors = numberOfColors;
        }
        //end of constructors

        //properties
        public double Size
        {
            get { return this.sizeInInches; }
            set 
            {
                if (value.GetType() == typeof(double))
                {
                    if (value < double.MaxValue && value > 0)
                    {
                        this.sizeInInches = value;
                    }
                    else
                    {
                        Console.WriteLine("Display size you entered is too small or too big");
                        Console.WriteLine("Please Enter Double value");
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    Console.WriteLine("You have entered wrong data for Display size");
                    throw new FormatException();
                }
            }
        }
        public double DisplayCOlor
        {
            get { return this.numberOfColors; }
            set 
            {
                if (value.GetType() == typeof(double))
                {
                    if (value > 256 && value < double.MaxValue)
                    {
                        this.numberOfColors = value;
                    }
                    else
                    {
                        Console.WriteLine("Color range of the display must be between 256 and {0}", double.MaxValue);
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    Console.WriteLine("You have entered wrong data for Display colors");
                    Console.WriteLine("Please Enter Double value");
                    throw new FormatException();
                }
            }
        }            
    }
}
