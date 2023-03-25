namespace Mediator.Mediators
{
    public interface ICabCallCenter
    {
        ICabCallCenter Register(ICab cab);
        void BookCab(IPassenger passenger);
    }
}
