using Command.Commands;

namespace Command.Proxies
{
    public record Inventory(string ProductName, int Quantity) : IMessage;
}
