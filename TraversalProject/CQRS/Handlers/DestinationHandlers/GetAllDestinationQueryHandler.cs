using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalProject.CQRS.Results.DeestinationResults;

namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                DestinationID = x.DestinationID,
                Capacity = x.Capacity,
                Price = x.Price,
                DayNight = x.DayNight,
                City = x.City
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
