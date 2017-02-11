using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;

namespace TFLDataExplorer.Controllers
{
    public class TubeController : Controller
    {

        private readonly MyOptions _optionsAccessor;

        // Get the secret app_id and app_key to pass in the GET request as the TFL API gives priority to requests with an app_id and app_key.
        // You can get your own here: https://api-portal.tfl.gov.uk/login. 
        public TubeController(IOptions<MyOptions> optionsAccessor)
        {
            _optionsAccessor = optionsAccessor.Value;
        }

        public async Task<ActionResult> Index()
        {
            // Declare which mode we want to request line data for.
            Mode mode = new Mode();
            mode.Type = "tube";

            // Create an empty list of Lines.
            IEnumerable<Line> model = new List<Line>();

            // Instantiate a new instance of the APIContextAsync Class which is used to make a call to the TFL API.
            // To Do: Implement DI 
            APIContextAsync apiFetcher = new APIContextAsync();

            // Get the current Line status for the given mode (tube).
            model = await apiFetcher.GetObject<Line>(string.Format("Line/Mode/{0}/Status?detail=false{1}app_id={2}{1}app_key={3}",mode.Type,"&", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            return View(model);
        }


        public IActionResult Error()
        {

            return View();
        }
    }
}
