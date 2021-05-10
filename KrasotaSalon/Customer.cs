using System;
using System.Collections.Generic;
using System.Text;

namespace KrasotaSalon
{
    public class Customer
    {
        private string name;
        private string phoneNumber;
        private Membership membership;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public Membership Membership
        {
            get { return this.membership; }
            set { this.membership = value; }
        }


        public Customer(string name, string phoneNumber, Membership membership)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Membership = membership;
        }


    }
}
