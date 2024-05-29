namespace DesignPattern.Composite.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public ProductComponent(int id, int name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get ; set  ; }
        public int Name { get  ; set ; }

        public string Display()
        {
            return $"<li class='list-group-item'>{Name}</li>";
        }

        public int TotalCount()
        {
            return 1;
        }
    }
}
