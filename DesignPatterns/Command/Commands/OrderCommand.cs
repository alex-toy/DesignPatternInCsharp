using Command.Proxies;

namespace Command.Commands
{
    public class OrderCommand : ICommand
    {
        private readonly IProxy<Order> _orderProxy;

        public OrderCommand(IProxy<Order> orderProxy)
        {
            _orderProxy = orderProxy;
        }

        public bool Execute(IMessage message)
        {
            return _orderProxy.Create((Order)message);
        }

        public bool RollBack(IMessage message)
        {
            return _orderProxy.Delete((Order)message);
        }
    }
}
