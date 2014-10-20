using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;
        private IList<string> topics;
        private ITeacher teacher;
        public Course(string name, ITeacher teacher)
        {
            this.Teacher = teacher;
            this.Name = name;
            topics = new List<string>();
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
                    throw new ArgumentNullException("Course name cannot be null");
                }
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string topicsComaSeparated = string.Join(",", topics);

            result.Append(GetType().Name);
            result.Append(": ");
            result.Append(string.Format("Name={0}; " , this.Name));
            if (this.Teacher != null)
            {
                result.Append(string.Format("Teacher={0}; " ,Teacher.Name));
            }
            if (topicsComaSeparated.Length > 0)
            {
                result.Append(string.Format("Topics=[{0}]; ", topicsComaSeparated));
            }
            
            return result.ToString();
        }
    }
}
