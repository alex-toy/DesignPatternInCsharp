namespace Command.Commands
{
    public interface ICommand
    {
        bool Execute(IMessage message);
        bool RollBack(IMessage message);
    }
}
