using System;

namespace Mediator.Mediators
{
    public class Cab : ICab
    {
        private readonly string _name;
        private readonly int _location;
        private readonly bool _free;

        public string Name => _name;
        public int CurrentLocation => _location;
        public bool IsFree => _free;

        public Cab(string name = null, int location = 0, bool free = false)
        {
            _name = name;
            _location = location;
            _free = free;
        }

        public void Assign(IPassenger passenger)
        {
            System.Console.WriteLine($"{Name}, you have been assigned passenger {passenger.Name}");
        }

        public bool IsWithinReach(int passengerLocation)
        {
            return Math.Abs(CurrentLocation- passengerLocation) < 5;
        }
    }
}
