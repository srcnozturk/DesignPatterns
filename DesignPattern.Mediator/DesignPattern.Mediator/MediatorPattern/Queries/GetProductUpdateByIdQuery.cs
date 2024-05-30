using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<UpdateProductByIDQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }
    }
}
