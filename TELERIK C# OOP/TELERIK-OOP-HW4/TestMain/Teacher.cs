using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Human
    {
        private List<Discipline> disciplines;
      
        //properties
        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
        }
        
        //constructors
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>();            
        }
        public Teacher(string name, List<Discipline> disciplines, List<string> comments)
            : base(name, comments)
        {
            this.disciplines = new List<Discipline>();
        }
        //methods
        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }
        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

    }
}
