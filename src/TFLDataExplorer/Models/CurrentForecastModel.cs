using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFLDataExplorer.Models
{
    public class CurrentForecastModel
    {
            public string id { get; set; }
            public string type { get; set; }
            public string forecastType { get; set; }
            public string forecastID { get; set; }
            public string forecastBand { get; set; }

            [Display(Name = "Forecast Summary: ")]
            public string forecastSummary { get; set; }
            public string nO2Band { get; set; }
            public string o3Band { get; set; }
            public string pM10Band { get; set; }
            public string pM25Band { get; set; }
            public string sO2Band { get; set; }

            [Display(Name = "Forecast: ")]
            public string forecastText { get; set; }
    }
}
