using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFLDataExplorer.Models
{
    public class ModeModel
    {
            public string Type { get; set; }
            public bool IsTflService { get; set; }
            public bool IsFarePaying { get; set; }
            public bool IsScheduledService { get; set; }
            public string ModeName { get; set; }
    }
}
