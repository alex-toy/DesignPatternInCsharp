namespace Command.Proxies
{
    public class InventoryProxy : IProxy<Inventory>
    {
        public bool Create(Inventory inventory)
        {
            Console.WriteLine($"Created inventory for product {inventory.ProductName}");
            return true;
        }

        public bool Delete(Inventory inventory)
        {
            Console.WriteLine($"Deleted inventory for product {inventory.ProductName}");
            return true;
        }
    }
}
