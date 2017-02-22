using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TFLDataExplorer.Models
{

    public class AirQualityModel
    {
        public string id { get; set; }

        public string type { get; set; }

        [Display(Name = "Update Period: ")]
        public string updatePeriod { get; set; }

        public string updateFrequency { get; set; }

        public string forecastURL { get; set; }

        public string disclaimerText { get; set; }

        public CurrentForecastModel[] currentForecast { get; set; }

    }
}
