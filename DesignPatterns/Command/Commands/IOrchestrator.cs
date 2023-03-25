using Command.Proxies;

namespace Command.Commands
{
    public interface IOrchestrator
    {
        bool CreateOrder(Order order);
    }
}