using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;
using System.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var model = await _stationService.GetStationsAsync(string.Format("https://data.tfl.gov.uk/tfl/syndication/feeds/stations-facilities.xml?app_id={0}&app_key={1}", _optionsAccessor.AppId, _optionsAccessor.AppKey));
            

            return View(model);
        }

        // Action result for Ajax call.
        [HttpPost]
        public async Task<ActionResult> GetStationsByZone(string zoneid)
        {
            // Get the list of Stations and their facilities from the TFL Feed.
            var model = await _stationService.GetStationsAsync(string.Format("https://data.tfl.gov.uk/tfl/syndication/feeds/stations-facilities.xml?app_id={0}&app_key={1}", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            // Get a List of Stations that are in the Zone selected by the user.
            var stationListbyZone = model.Stations.Station.Where(x => x.Zones.Zone == zoneid).ToList();

            SelectList stationSelectList = new SelectList(stationListbyZone, "Id", "Name", 0);


            return Json(stationSelectList);
        }


        [HttpPost]
        public async Task<ActionResult> GetStationById(string stationid)
        {
            // Get the list of Stations and their facilities from the TFL Feed.
            var model = await _stationService.GetStationsAsync(string.Format("https://data.tfl.gov.uk/tfl/syndication/feeds/stations-facilities.xml?app_id={0}&app_key={1}", _optionsAccessor.AppId, _optionsAccessor.AppKey));

            // Get the Station with the Id selected by the user.
            var station = model.Stations.Station.Where(x => x.Id == stationid);


            return PartialView("_Station", station);
        }


        public IActionResult Error()
        {

            return View();
        }
    }
}
