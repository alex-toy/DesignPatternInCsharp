namespace Mediator.Mediators
{
    public interface IPassenger
    {
        string Name { get; }
        string Address { get; }
        int Location { get; }

        void Inform(ICab cab);
    }
}
