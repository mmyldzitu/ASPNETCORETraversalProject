using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.DAL
{
    public enum ECity
    {
        İstanbul=1,
        Ankara=2,
        İzmir=3,
        Kayseri=4,
        Konya=5,
        Bursa=6,
        Antalya=7
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
