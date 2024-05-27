namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public int Id { get; set; }

        public GetProductUpdateByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
