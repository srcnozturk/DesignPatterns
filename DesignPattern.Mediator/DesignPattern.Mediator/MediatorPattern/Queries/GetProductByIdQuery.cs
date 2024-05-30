using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductByIDQueryResult>
    {

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
