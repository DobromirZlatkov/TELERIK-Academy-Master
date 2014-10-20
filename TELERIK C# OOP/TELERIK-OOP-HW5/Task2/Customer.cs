using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Customer
    {
        private string id;
        private string name;       
        private string address;
        private string phone;
        private bool isCompany;

        public string Id
        {
            get { return this.id; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ID should not be empty");
                }
                else
                {
                   this.id = value;
                }
            }
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name should not be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }       
        public string Address
        {
            get { return this.address; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Address should not be empty");
                }
                else
                {
                    this.address = value;
                }
            }
        }
        public string Phone
        {
            get { return this.phone; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Phone name should not be empty");
                }
                else
                {
                    this.phone = value;
                }
            }
        }
        public bool IsCompany
        {
            get { return this.isCompany; }
            set { this.isCompany = value; }
        }

        public Customer(string id, string name, string address, string phone, bool isCompany)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.IsCompany = isCompany;
        }
    }
}
