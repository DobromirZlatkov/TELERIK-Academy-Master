using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTest
{
    /*Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
    */
    class Student
    {
        private string firstName;
        private string lastName;
        private int facNum;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private Group group;

        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Student name should be atleast 3 symbols and less than 20");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentOutOfRangeException("Student name should be atleast 3 symbols and less than 20");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public int FacNumber
        {
            get
            {
                return this.facNum;
            }
            set
            {
                this.facNum = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Group Number cant be negative!");

                }
                else
                {
                    this.groupNumber = value;
                }
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
        }

        public Group Group
        {
            get { return this.group; }
            set { this.group = value; }
        }

        // constructor

        public Student(string firstName, string lastName, int facNum, string tel,
            string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacNumber = facNum;
            this.Tel = tel;
            this.Email = email;
            this.marks = marks;
            this.GroupNumber = groupNumber;
            
        }




        // methods
        public void AddMark(int mark)
        {
            if (mark < 2 || mark > 6)
            {
                throw new IndexOutOfRangeException("Mark shoud be between 2 and 6");
            }
            else
            {
                this.marks.Add(mark);
            }
        }

        public void RemoveMark(int index)
        {
            this.marks.RemoveAt(index);
        }

        public string TakeAllMarks()
        { 
            return string.Join(", ", this.marks);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("First name: {0}", this.FirstName));

            sb.AppendLine(string.Format("Last name:  {0}", this.LastName));
            sb.AppendLine(string.Format("Faclutet number: {0}", this.FacNumber));
            sb.AppendLine(string.Format("Tel number: {0}", this.Tel));
            sb.AppendLine(string.Format("E-mail : {0}", this.Email));
            sb.AppendLine(string.Format("Group: {0}", this.GroupNumber));
            sb.AppendLine(string.Format("Marks: {0}", TakeAllMarks()));

            return sb.ToString();
        }


    }
}
