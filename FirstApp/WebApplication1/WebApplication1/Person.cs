using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Person
    {
        private string _FirstName;
        private string _LastName;
        public string PhoneNumber { get; set; }
        public Address address { get; set; }
        public Person()
        {

        }

        public Person ( string firstName, string lastName, string phoneNumber, Address address)
        {
            this._FirstName = firstName;
            this._LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.ContactAddress = address;
        }
        public Address ContactAddress
        {
            get{ return address; }
            set{ address = value; }
        }


        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }

        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }

        }
    }
}