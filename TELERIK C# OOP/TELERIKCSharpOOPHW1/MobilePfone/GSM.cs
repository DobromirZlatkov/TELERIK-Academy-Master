using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePfone
{
    class GSM
    {                     
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> CallHistory;
       
        public static GSM Iphone4S
        {
            get { return iPhone4s; }
        }

        public string Model
        {
            get { return this.model; }
            set 
            {
                if (value != null)
                {
                    this.model = value;
                }
                else
                {
                    Console.WriteLine("Enter phone model.");
                    throw new FormatException();
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {             
                if (value != null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    Console.WriteLine("Enter phone manufacturer.");
                    throw new FormatException();
                }
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value.GetType() == typeof(decimal))
                {
                    if (value > 0 && value < decimal.MaxValue)
                    {
                        this.price = value;
                    }
                    else
                    {
                        Console.WriteLine("GSM price must be between 0 and {0}", decimal.MaxValue);
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    Console.WriteLine("GSM price is in wrong format please use decimal.");
                    throw new FormatException();
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set 
            {
                if (value != null)
                {
                    if (value.Length < 2)
                    {                      
                        Console.WriteLine("Owner name is too short.");
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        this.owner = value;
                    }                    
                }
                else
                {
                    this.owner = "N/A";
                }
            }
        }

        //constructors



        public GSM(string model, string manufacturer, List<Call> CallHistory)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }
        public GSM(string model, string manufacturer, List<Call> CallHistory, decimal price)
            : this(model, manufacturer, CallHistory)
        {
            this.price = price;
            
        }
        public GSM(string model, string manufacturer, List<Call> CallHistory, decimal price, string owner)
            : this(model, manufacturer,CallHistory, price)
        {
            this.owner = owner;            
        }
        //end of constructors
      
        //iphone4S static
        private static GSM iPhone4s = new GSM("IPhone 4S", "Apple", null)
        {
            Price = 1300,
            createBattery = new Battery("Apple", 10, 20, BatteryType.LiIon),
            createDisplay = new Display(10, 10000),

        };

        Battery createBattery = new Battery("Toshiba", 12, 11, BatteryType.NiMH);
        Display createDisplay = new Display(12, 1000);
       
        
        public override string ToString()
        {
            StringBuilder gsmCharacteristics = new StringBuilder();
            gsmCharacteristics.AppendLine("GSM model : " + this.model);
            gsmCharacteristics.AppendLine("GSM manufacturer : " + this.manufacturer);

            if (this.price > 0)
            {
               gsmCharacteristics.AppendLine("GSM price : " + this.price); 
            }
            else
            {
                gsmCharacteristics.AppendLine("GSM price : N/A" );
            }
            gsmCharacteristics.AppendLine("GSM owner : " + this.owner);
            gsmCharacteristics.AppendLine("Display size in inches : " + createDisplay.Size + " inches");
            gsmCharacteristics.AppendLine("Display colors : " + createDisplay.DisplayCOlor);
            gsmCharacteristics.AppendLine("Battery type : " + createBattery.Type);
            gsmCharacteristics.AppendLine("Battery midel : " + createBattery.BatteryModel);
            gsmCharacteristics.AppendLine("Battery hours idl : " + createBattery.HoursIdle + " hrs");
            gsmCharacteristics.AppendLine("Battery hours talk : " + createBattery.HoursTalk + " hrs");
            return gsmCharacteristics.ToString();
        }

        //task 10
        public void AddCall(Call addCall)
        {
            this.CallHistory.Add(addCall);
        }
        public void DeleteCall(int deleteCall)
        {
            this.CallHistory.RemoveAt(deleteCall);
        }
        public void ClearAllCalls()
        {
            this.CallHistory.Clear();
        }
        public List<Call> GetCallHistory()
        {
            return this.CallHistory;
        }
        //task 11
        public decimal PriceOfTheCalls(decimal pricePerMinute)
        {
            decimal price = 0;
            foreach (var call in CallHistory)
            {
                price += call.Duration;
            }

            return (price / 60) * pricePerMinute; ;
        }
    }
}
