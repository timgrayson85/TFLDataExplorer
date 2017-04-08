using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TFLDataExplorer.Models;

namespace TFLDataExplorer
{
    public class StationService : IStationService
    {

        public async Task<StationsModel> GetStationsAsync()
        {
            HttpClient client = new HttpClient();

            // Get the list of Stations and their facilities from the TFL Feed.
            var response = await client.GetStringAsync("https://data.tfl.gov.uk/tfl/syndication/feeds/stations-facilities.xml?app_id=&app_key=");

            XmlSerializer serial = new XmlSerializer(typeof(StationsModel), new XmlRootAttribute("Root"));

            // Deserialize the XML string to a StationsModel object.
            var model = (StationsModel)serial.Deserialize(new StringReader(response));

            return model;

        }
    }
}
