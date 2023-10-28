using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.CQRS.Results.DeestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public string DayNight { get; set; }
    }
}
