using Mediator.Mediators;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var callCenter = new CabCallCenter();

            var passenger1 = new Passenger("Alex", "Rome", 13);
            var passenger2 = new Passenger("Seb", "Paris", 26);

            var cab1 = new Cab("cab1", 11, true);
            var cab2 = new Cab("cab2", 23, true);

            callCenter
                .Register(cab1)
                .Register(cab2);

            callCenter.BookCab(passenger1);
            callCenter.BookCab(passenger2);

            System.Console.ReadLine();
        }
    }
}
