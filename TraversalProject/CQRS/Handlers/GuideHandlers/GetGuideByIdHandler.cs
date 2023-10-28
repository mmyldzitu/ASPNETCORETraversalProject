using DataAccessLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.CQRS.Quaries.GuideQueries;
using TraversalProject.CQRS.Results.GuideResults;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values= await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
