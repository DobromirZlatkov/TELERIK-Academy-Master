using System;

namespace Methods
{
    class Student
    {
        private string firstName;
        private string lastName;
        private PersonalInformation personalInfo;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set 
            {
                if (value.Length < 2 || value == null)
                {
                    throw new ArgumentException("Invalid First Name!");
                }
                this.firstName = value;
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
                if (value.Length < 2 || value == null)
                {
                    throw new ArgumentException("Invalid Last Name!");
                }
                this.lastName = value;
            }
        }

        public PersonalInformation PersonalInfo
        {
            get { return this.personalInfo; }
            set
            {
                this.personalInfo = value;
            }
        }
        public bool IsOlderThan(Student student)
        {           
            DateTime firstStudent = this.PersonalInfo.BirthDate;
            DateTime secondStudent = student.PersonalInfo.BirthDate;

            bool isOlder = false;
            if (DateTime.Compare(firstStudent, secondStudent) < 0)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }
}
