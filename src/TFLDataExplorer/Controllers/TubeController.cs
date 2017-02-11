using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;
using System.Collections;

namespace TFLDataExplorer.Controllers
{
    public class TubeController : Controller
    {

        private readonly IList<Line> _lineList;
        private readonly Mode _mode;
        private readonly MyOptions _optionsAccessor;
        private readonly IAPIContextAsync _apiContextAsync;

        public TubeController(IOptions<MyOptions> optionsAccessor, IAPIContextAsync apiContextAsync, Mode mode, IList<Line> lineList)
        {
            _lineList = lineList;
            _mode = mode;
            _optionsAccessor = optionsAccessor.Value;
            _apiContextAsync = apiContextAsync;
        }


        public async Task<ActionResult> Index()
        {
            // Declare which Mode we want to request Line data for.
            _mode.Type = "tube";

            // Create an empty list of Lines.
            IEnumerable<Line> model = _lineList;

            // Get the current Line status for the given mode (tube).
            model = await _apiContextAsync.GetObject<Line>(string.Format("Line/Mode/{0}/Status?detail=false{1}app_id={2}{1}app_key={3}",_mode.Type,"&", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            return View(model);
        }


        public IActionResult Error()
        {

            return View();
        }
    }
}
