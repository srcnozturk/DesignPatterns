namespace DesignPattern.Iterator.IteratorPattern.Abstract
{
    public interface IIterator<T>
    {
        T CurrentItem { get; }
        bool NextLocation();
    }
}
