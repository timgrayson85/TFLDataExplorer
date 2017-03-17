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
    public class LineModel
    {
        [Display(Name = "Line Type: ")]
        public string type { get; set; }

        public string id { get; set; }

        [Display(Name="Line Name: ")]
        public string name { get; set; }

        [Display(Name = "Mode Name: ")]
        public string modeName { get; set; }

        public object[] disruptions { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public LinestatusModel[] lineStatuses { get; set; }
        public object[] routeSections { get; set; }
        public ServiceTypeModel[] serviceTypes { get; set; }
        public CrowdingModel crowding { get; set; }

    }
}
