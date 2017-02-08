using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TFLDataExplorer.Models
{
        public class Linestatus
        {
            public string type { get; set; }
            public int id { get; set; }
            public int statusSeverity { get; set; }
            public string statusSeverityDescription { get; set; }
            public DateTime created { get; set; }
            public object[] validityPeriods { get; set; }
        }
    
}
