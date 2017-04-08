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
    public class StationController : Controller
    {
        private readonly MyOptions _optionsAccessor;
        private readonly IStationService _stationService;

        public StationController(IOptions<MyOptions> optionsAccessor, IStationService stationService)
        {
            _optionsAccessor = optionsAccessor.Value;
            _stationService = stationService;
        
        }

        public async Task<IActionResult> Index()
        {
            // Get the list of Stations and their facilities from the TFL Feed.
            var model = await _stationService.GetStationsAsync();

            return View(model);
        }


        public IActionResult Error()
        {

            return View();
        }
    }
}
