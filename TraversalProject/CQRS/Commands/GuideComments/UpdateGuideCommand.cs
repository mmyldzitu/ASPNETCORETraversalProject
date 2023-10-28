using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Commands.GuideComments
{
    public class UpdateGuideCommand:IRequest
    {
        public int GuideId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
