using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;

namespace TFLDataExplorer.Controllers
{
    public class HomeController : Controller
    {

        private readonly MyOptions _optionsAccessor;

        public HomeController(IOptions<MyOptions> optionsAccessor)
        {
            _optionsAccessor = optionsAccessor.Value;
        }

        public async Task<ActionResult> Index()
        {
            //var appId = _optionsAccessor.AppId;
            //var appKey = _optionsAccessor.AppKey;

            IEnumerable<Line> model = new List<Line>();
            
            APIDataAsync test = new APIDataAsync();
            

            model = await test.GetObject<Line>(string.Format("Line/Mode/tube/Status?detail=false{0}app_id={1}{0}app_key={2}","&",_optionsAccessor.AppId,_optionsAccessor.AppKey));

            return View();

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Please get in touch.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
