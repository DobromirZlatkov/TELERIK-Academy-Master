using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TELERIK_KPK_UnitTesting
{
    public class Student
    {
        private string name;
        private uint uniqueNumber;

        public Student(string name, uint uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can't be null or empty");
                }

                this.name = value;
            }
        }

        public uint UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            set
            {
                if (10000 > value || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("The unique number of the student should be between 10000 and 99999");
                }

                this.uniqueNumber = value;
            }
        }
    }
}
