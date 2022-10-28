using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentDatabase1
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }

        public Address(string streetAddress, string city, string state, int zipcode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
        public string GetHomeTown()
        {
            string cityState = String.Concat(City + State);
            return cityState;
        }
    }
}


