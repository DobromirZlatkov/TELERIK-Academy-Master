using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePfone
{
    class Call
    {
        private DateTime dateTime;
        private string number;
        private int duration;

                
        public DateTime DateTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public Call(DateTime dateTime, string number, int duration)
        {
            this.dateTime = DateTime.Now;
            this.number = number;
            this.duration = duration;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date : " + this.dateTime);
            sb.AppendLine("Number : " + this.number);
            sb.AppendLine("Duration : " + this.duration + " seconds");

            return sb.ToString();
        }
    }
}
