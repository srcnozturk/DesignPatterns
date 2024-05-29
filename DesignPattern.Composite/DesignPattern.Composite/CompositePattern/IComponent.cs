namespace DesignPattern.Composite.CompositePattern
{
    public interface IComponent
    {
        public int Id { get; set; }
        public int Name { get; set; }
        int TotalCount();
        string Display();
    }
}
