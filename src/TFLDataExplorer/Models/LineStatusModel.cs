using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFLDataExplorer.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Routing;

namespace TFLDataExplorer.Models
{
        public class LinestatusModel
        {
            public string type { get; set; }
            public int id { get; set; }

            [Display(Name = "Status Severity: ")]
            public int statusSeverity { get; set; }

            [Display(Name = "Status Description: ")]
            public string statusSeverityDescription { get; set; }

            [Display(Name = "Reason: ")]
            public string reason { get; set; }
            public DateTime created { get; set; }

            [Display(Name = "Validity Periods: ")]
            public ValidityPeriodModel[] validityPeriods { get; set; }
        }
    
}
