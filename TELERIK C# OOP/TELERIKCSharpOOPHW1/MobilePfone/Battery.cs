using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePfone
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    // end of task 3
    class Battery
    {
        private string batteryModel;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;
        //constructor second task

        //third task
        public Battery()
        {

        }

        //end of third task        
        public Battery(string batteryModel)     
        {
            this.batteryModel = batteryModel;
        }
        public Battery(string batteryModel, double hoursIdle)
            : this(batteryModel)
        {
            this.hoursIdle = hoursIdle;
        }
        public Battery(string batteryModel, double hoursIdle, double hoursTalk)
            : this( batteryModel, hoursIdle)
        {
            this.hoursTalk = hoursTalk;
        }
        public Battery(string batteryModel, double hoursIdle, double hoursTalk, BatteryType type)
            : this( batteryModel, hoursIdle, hoursTalk)
        {
            this.type = type;
        }
        //end of constructors

        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (value != null)
                {
                    this.batteryModel = value;
                }
                else
                {
                    this.batteryModel = "N/A";
                }
            }
        }
        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value.GetType() == typeof(double))
                {
                    if (value > 5 && value < double.MaxValue)
                    {
                        this.hoursIdle = value; 
                    }
                    else
                    {
                        Console.WriteLine("Battery Hours idle must be between 5 and {0}", double.MaxValue);
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    Console.WriteLine("Hours idle is in wrong format please use double.");
                    throw new FormatException();
                }
                
            }
        }
        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value.GetType() == typeof(double))
                {
                    if (value > 5 && value < double.MaxValue)
                    {
                        this.hoursIdle = value;
                    }
                    else
                    {
                        Console.WriteLine("Battery Hours talk must be between 5 and {0}", double.MaxValue);
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    Console.WriteLine("Hours talk is in wrong format please use double.");
                    throw new FormatException();
                }
            }
        }        
    }
}
