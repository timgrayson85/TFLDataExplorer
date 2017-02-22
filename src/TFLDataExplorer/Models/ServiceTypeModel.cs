using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TFLDataExplorer.Models
{
     public class ServiceTypeModel
    {
            public string type { get; set; }

            [Display(Name = "Service Types: ")]
            public string name { get; set; }

            public string uri { get; set; }
      
    }
}
