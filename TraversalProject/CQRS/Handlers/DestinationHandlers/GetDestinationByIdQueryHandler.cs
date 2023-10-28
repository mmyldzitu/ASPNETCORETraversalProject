using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Quaries.DestinationQuaries;
using TraversalProject.CQRS.Results.DeestinationResults;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                City = values.City,
                DayNight = values.DayNight,
                DestinationId = values.DestinationID,
                Capacity=values.Capacity,
                Price=values.Price
            };
        }
    }
}
