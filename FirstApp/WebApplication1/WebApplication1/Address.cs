using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Address() { }

        public Address(string strStreet, string strCity, string strState, string strZip)
        {
            Street = strStreet;
            City = strCity;
            State = strState;
            Zip = strZip;

        }

    }
}