namespace DesignPattern.Iterator.IteratorPattern.Abstract
{
    public interface IMover<T>
    {
        IIterator<T> CreateIterator();
    }
}
