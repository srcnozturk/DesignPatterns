﻿using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                Name = values.Name,
                Price = values.Price,
                StockNumber = values.StockNumber,
                Id = values.Id,
            };
        }
    }
}
