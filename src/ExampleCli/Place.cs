using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleCli
{
    public class Place
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public Place(string country, string city, string street, int number)
        {
            Country = country;
            City = city;
            Street = street;
            Number = number;
        }
    }
}
