using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public abstract class Human
    {
        private string name;
        private List<string> comments;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<string> Comment
        {
            get { return this.comments; }            
        }

        public Human(string name)
        {
            this.Name = name;            
        }
        public Human(string name, List<string> comments)
            : this(name)
        {            
            this.comments = new List<string>();
        }


        //methods
        public void AddComment(string comment)
        {
            comments.Add(comment);
        }
        
    }
}
