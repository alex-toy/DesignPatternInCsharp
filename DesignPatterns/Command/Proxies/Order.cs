using Command.Commands;

namespace Command.Proxies
{
    public record Order(string ProductName, int Quantity) : IMessage;
}
