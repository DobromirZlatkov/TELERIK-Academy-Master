using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline : SchoolObj
    {
       
        private int numberOfLectures;
        private int numberOfExercises;
       
        //properties       
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }       
        //constructors
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            :base(name)
        {           
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;          
        }
        public Discipline(string name, int numberOfLectures, int numberOfExercises, List<string> comments)
            : base(name, comments)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Discipline: " + this.Name);
            sb.AppendLine("Number of lectures: " + this.numberOfLectures);
            sb.AppendLine("Number of exercises: " + this.numberOfExercises);
            return sb.ToString();
        }
    }
}
