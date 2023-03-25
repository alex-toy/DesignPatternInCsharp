namespace Mediator.Mediators
{
    public interface ICab
    {
        string Name { get; }
        int CurrentLocation { get; }
        bool IsFree { get; }

        void Assign(IPassenger passenger);

        bool IsWithinReach(int passengerLocation);
    }
}
