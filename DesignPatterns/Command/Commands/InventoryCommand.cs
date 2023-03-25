using Command.Proxies;

namespace Command.Commands
{
    public class InventoryCommand : ICommand
    {
        private readonly IProxy<Inventory> _inventoryProxy;

        public InventoryCommand(IProxy<Inventory> orderProxy)
        {
            _inventoryProxy = orderProxy;
        }

        public bool Execute(IMessage message)
        {
            return _inventoryProxy.Create((Inventory)message);
        }

        public bool RollBack(IMessage message)
        {
            return _inventoryProxy.Delete((Inventory)message);
        }
    }
}
