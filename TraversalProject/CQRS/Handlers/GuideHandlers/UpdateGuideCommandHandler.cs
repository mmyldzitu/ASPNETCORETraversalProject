using DataAccessLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.CQRS.Commands.GuideComments;
using TraversalProject.CQRS.Results.GuideResults;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class UpdateGuideCommandHandler : IRequestHandler<UpdateGuideCommand>
    {
        private readonly Context _context;

        public UpdateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateGuideCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.GuideId);
            values.Name = request.Name;
            values.Description = request.Description;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
