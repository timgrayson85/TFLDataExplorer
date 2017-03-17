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
    public class AirQualityController : Controller
    {
        private readonly MyOptions _optionsAccessor;
        private readonly IAPIContextAsync _apiContextAsync;

        public AirQualityController(IOptions<MyOptions> optionsAccessor, IAPIContextAsync apiContextAsync)
        {
            _optionsAccessor = optionsAccessor.Value;
            _apiContextAsync = apiContextAsync;
        }


        public async Task<ActionResult> Index()
        {
            // Get the current Air Quality status
            var model = await _apiContextAsync.GetObjectAsync<AirQualityModel>(string.Format("AirQuality/?app_id={1}{0}app_key={2}", "&", _optionsAccessor.AppId, _optionsAccessor.AppKey));
           

            return View(model);
        }


        public IActionResult Error()
        {

            return View();
        }
    }
}
