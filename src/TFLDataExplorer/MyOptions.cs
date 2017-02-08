using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFLDataExplorer
{
    public class MyOptions
    {
        public MyOptions()
        {
            // Set default values.
            AppId = "app_id";
            AppKey = "app_key";
        }

        public string AppId { get; set; }
        public string AppKey { get; set; }
    }
}
