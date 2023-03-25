namespace Command.Proxies
{
    public interface IProxy<T>
    {
        bool Create(T item);
        bool Delete(T item);
    }
}
