using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiMssql.DAL
{
    public class Visitor
    {
        public enum ECity{
            İstanbul=1,
            Ankara=2,
            Kayseri=3,
            İzmir=4,
            Gaziantep=5
        }
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
