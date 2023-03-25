namespace Command.Proxies
{
    public class OrderProxy : IProxy<Order>
    {
        public bool Create(Order order)
        {
            Console.WriteLine($"Created order for product {order.ProductName}");
            return true;
        }

        public bool Delete(Order order)
        {
            Console.WriteLine($"Deleted order for product {order.ProductName}");
            return true;
        }
    }
}
