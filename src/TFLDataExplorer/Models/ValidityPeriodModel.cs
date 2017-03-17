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
    public class ValidityPeriodModel
    {
        [Display(Name = "Validity Period Type: ")]
        public string type { get; set; }

        [Display(Name = "From: ")]
        public string fromDate { get; set; }

        [Display(Name = "To: ")]
        public string toDate { get; set; }

        [Display(Name = "Now?: ")]
        public bool isNow { get; set; }
    }
}
