using System;
using System.Collections.Generic;

namespace Prototype.Prototypes
{
    public class Car : Prototype
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public List<string> Options { get; set; }

        public Car(string make, string model, int year, List<string> options)
        {
            Make = make;
            Model = model;
            Year = year;
            Options = options;
        }

        public override Prototype Clone()
        {
            return new Car(Make, Model, Year, new List<string>());
        }
    }
}
