using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TFLDataExplorer.Models
{
     public class ServiceType
    {
            public string type { get; set; }
            public string name { get; set; }
            public string uri { get; set; }
      
    }
}
