using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalProject.CQRS.Commands.GuideComments;

namespace TraversalProject.CQRS.Handlers.GuideHandlers
{
    public class AddGuideCommandHandler : IRequestHandler<AddGuideCommand>
    {
        private readonly Context _context;

        public AddGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AddGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide { Name = request.Name, Description = request.Description });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
