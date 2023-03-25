using Prototype.Prototypes;
using System.Collections.Generic;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string>() { "Sunroof", "Navigation", "Leather seats"};
            Car c1 = new Car("Ford", "Mustang", 2022, options);

            Car c2 = c1.Clone() as Car;
        }
    }
}
