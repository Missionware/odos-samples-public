using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mc3s.Odos.Domain.Northwind
{
    partial class Address
    {

        public Address() { }

        public Address(string street, string city, string region, string postalCode,
                       string country, string phoneNumber, string fax)
        {
            Street = street;
            City = city;
            Region = region;
            Postalcode = postalCode;
            Country = country;
            Phonenumber = phoneNumber;
            Fax = fax;
        }
    }
}
