using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMANS
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker(string firstName, string LastName, decimal workHours, decimal weekSalary)
            : base(firstName, LastName)
        {
            this.workHoursPerDay = workHours;
            this.weekSalary = weekSalary;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Week Salary: " + this.WeekSalary);
            sb.AppendLine("Work hours: " + this.WorkHoursPerDay);
            return sb.ToString();            
        }

        public decimal MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 0.5m);
        }
    }
}
