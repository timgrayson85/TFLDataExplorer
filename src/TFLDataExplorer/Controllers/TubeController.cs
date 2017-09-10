using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;
using System.Collections;
using Newtonsoft.Json;
using Moq;

namespace TFLDataExplorer.Controllers
{
    public class TubeController : Controller
    {
        private readonly MyOptions _optionsAccessor;
        private readonly IAPIContextAsync _apiContextAsync;

        public TubeController(IOptions<MyOptions> optionsAccessor, IAPIContextAsync apiContextAsync)
        {
            _optionsAccessor = optionsAccessor.Value;
            _apiContextAsync = apiContextAsync;
        }

        public async Task<ActionResult> Index()
        {
            // Declare which Mode we want to request Line data for.
            var mode = "tube";

            // Get the current Line status for the given mode (tube).
            var model = await _apiContextAsync.GetObjectsAsync<LineModel>(string.Format("Line/Mode/{0}/Status?detail=false{1}app_id={2}{1}app_key={3}", mode, "&", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            model = model.OrderByDescending(x => x.lineStatuses.Sum(s => s.statusSeverity)).ToList();


            return View(model);
        }


        public async Task<ActionResult> Detail(string name)
        {
            // Get the current Line status for the given line.
            var model = await _apiContextAsync.GetObjectsAsync<LineModel>(string.Format("Line/{0}?app_id={2}{1}app_key={3}", name, "&", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            return View(model);
        }


        public async Task<ActionResult> Status(string name)
        {
            // Get the current Line status for the given line.
            var model = await _apiContextAsync.GetObjectsAsync<LineModel>(string.Format("Line/{0}/Status?app_id={2}{1}app_key={3}", name, "&", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            return View(model);
        }


        public IActionResult Error()
        {

            return View();
        }
    }
}
