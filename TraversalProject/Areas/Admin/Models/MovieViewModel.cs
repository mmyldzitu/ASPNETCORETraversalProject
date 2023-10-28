using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.Areas.Admin.Models
{
    public class MovieViewModel
    {
        public int rank { get; set; }
        
        public string title { get; set; }

        public int year { get; set; }
        public string rating { get; set; }
        public string trailer { get; set; }
    }
}
