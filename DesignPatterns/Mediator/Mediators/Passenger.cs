namespace Mediator.Mediators
{
    public class Passenger : IPassenger
    {
        private string _name;
        private string _address;
        public int _location;

        public string Name => _name;

        public string Address => _address;

        public int Location => _location;

        public Passenger(string name, string address, int location)
        {
            _name = name;
            _address = address;
            _location = location;
        }

        public void Inform(ICab cab)
        {
            System.Console.WriteLine($"{Name}, cab {cab.Name} has been assigned to you.");
        }
    }
}
