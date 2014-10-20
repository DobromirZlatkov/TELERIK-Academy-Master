using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Human
    {
        private int classNumber;
     
        //properties
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }

       
        //constructor
        public Student(string name, int classNumber, List<string> comments)
            : base(name, comments)
        {
            this.ClassNumber = classNumber;           
        }
        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }
               
    }
}
