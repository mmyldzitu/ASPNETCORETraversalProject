using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Commands.GuideComments
{
    public class RemoveGuideCommand:IRequest
    {
        public RemoveGuideCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
