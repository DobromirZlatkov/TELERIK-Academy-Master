using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        private string schoolName;
        private List<SchoolClass> classes;

        public string SchoolName
        {
            get 
            {
                return this.schoolName;
            }
            set
            {
                this.schoolName = value;
            }
        }
        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }
        }

        public School(string name)
        {
            this.schoolName = name;
            this.classes = new List<SchoolClass>();
        }
    }
}
