using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFLDataExplorer.Controllers;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TFLDataExplorer.Tests
{
    public class StationControllerTests
    {

        [Fact]
        public async Task GetStationsByZone_Action_Returns_Stations_With_Selected_Zone()
        {
            // Arrange.
            string zoneId = "3";

            // Create some fake stations in different Zones.
            var fakeStationOne = new Station();
            fakeStationOne.Name = "Fake Station One";
            fakeStationOne.Zones = new Zones { Zone = "1" };

            var fakeStationTwo = new Station();
            fakeStationTwo.Name = "Fake Station Two";
            fakeStationTwo.Zones = new Zones { Zone = "2" };

            var fakeStationThree = new Station();
            fakeStationThree.Name = "Fake Station Three";
            fakeStationThree.Zones = new Zones { Zone = "3" };

            var fakeStationsModel = new StationsModel();
            var fakeStations = new Stations();
            var stationList = new List<Station>();

            fakeStationsModel.Stations = fakeStations;
            fakeStationsModel.Stations.Station = stationList;
            
            fakeStations.Station.Add(fakeStationOne);
            fakeStations.Station.Add(fakeStationTwo);
            fakeStations.Station.Add(fakeStationThree);
            
            // Create some mock options to avoid Null Reference Exception.
            MyOptions options = new MyOptions() { AppId = "Foo", AppKey = "Bar" };

            var mockOptions = new Mock<IOptions<MyOptions>>();
            mockOptions.Setup(x => x.Value)
                .Returns(options);

            // Mock the API caller to return the details of Stations.
            var mockStationServiceAsync = new Mock<IStationService>();
            mockStationServiceAsync.Setup(x => x.GetStationsAsync(It.IsAny<string>()))
               .ReturnsAsync(fakeStationsModel);

            // Act.
            StationController stationController = new StationController(mockOptions.Object, mockStationServiceAsync.Object);
            var actionResult = await stationController.GetStationsByZone(zoneId);
            var jsonResult = actionResult as JsonResult;
            var result = jsonResult.Value as SelectList;


            // Assert.
            Assert.NotNull(jsonResult);
            Assert.IsType<SelectList>(jsonResult.Value);
            Assert.NotNull(result);
            Assert.Equal("Fake Station Three", result.FirstOrDefault().Text);
                     

        }


        [Fact]
        public async Task GetStationsById_Action_Returns_Stations_With_Selected_Id()
        {
            // Arrange.
            string stationId = "1";

            // Create some fake stations in different Zones.
            var fakeStationOne = new Station();
            fakeStationOne.Name = "Fake Station One";
            fakeStationOne.Id = "1";

            var fakeStationTwo = new Station();
            fakeStationTwo.Name = "Fake Station Two";
            fakeStationTwo.Id = "2";

            var fakeStationThree = new Station();
            fakeStationThree.Name = "Fake Station Three";
            fakeStationThree.Id = "3";

            var fakeStationsModel = new StationsModel();
            var fakeStations = new Stations();
            var stationList = new List<Station>();

            fakeStationsModel.Stations = fakeStations;
            fakeStationsModel.Stations.Station = stationList;

            fakeStations.Station.Add(fakeStationOne);
            fakeStations.Station.Add(fakeStationTwo);
            fakeStations.Station.Add(fakeStationThree);

            // Create some mock options to avoid Null Reference Exception.
            MyOptions options = new MyOptions() { AppId = "Foo", AppKey = "Bar" };

            var mockOptions = new Mock<IOptions<MyOptions>>();
            mockOptions.Setup(x => x.Value)
                .Returns(options);

            // Mock the API caller to return the details of Stations.
            var mockStationServiceAsync = new Mock<IStationService>();
            mockStationServiceAsync.Setup(x => x.GetStationsAsync(It.IsAny<string>()))
               .ReturnsAsync(fakeStationsModel);

            // Act.
            StationController stationController = new StationController(mockOptions.Object, mockStationServiceAsync.Object);
            var actionResult = await stationController.GetStationById(stationId);
            var viewResult = actionResult as PartialViewResult;
            var result = viewResult.ViewData.Model as IEnumerable<Station>;

            // Assert.
            Assert.NotNull(result);
            Assert.Equal("Fake Station One", result.FirstOrDefault().Name);


        }

    }

}
