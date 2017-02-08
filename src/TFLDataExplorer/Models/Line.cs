using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFLDataExplorer.Models;
using Newtonsoft.Json;

namespace TFLDataExplorer.Models
{
    public class Line
    {
        
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string modeName { get; set; }
        public object[] disruptions { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public Linestatus[] lineStatuses { get; set; }
        public object[] routeSections { get; set; }
        public ServiceType[] serviceTypes { get; set; }
        public Crowding crowding { get; set; }
        
    }
}
