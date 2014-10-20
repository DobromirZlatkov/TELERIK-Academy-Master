using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMANS
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FristName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Human(string firstName, string lastName)
        {
            this.FristName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First name: " + this.FristName);
            sb.AppendLine("Last name: " + this.LastName);
            return sb.ToString();
        }
    }
}
