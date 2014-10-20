namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PersonalInformation
    {
        private DateTime birthDate { get; set; }
        private string city { get; set; }
        private string hobby { get; set; }


        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Hobby
        {
            get { return this.hobby; }
            set { this.hobby = value; }
        }

        public PersonalInformation(string birthDate, string city = null, string hobby = null)
        {
            DateTime outParamBirthDate;
            if (!DateTime.TryParse(birthDate, out outParamBirthDate))
            {
                throw new FormatException("Incorrect Date format! Try ->> (15.04.1999)");
            }

            this.BirthDate = outParamBirthDate;
            this.City = city;
            this.Hobby = hobby;
        }
    }
}
