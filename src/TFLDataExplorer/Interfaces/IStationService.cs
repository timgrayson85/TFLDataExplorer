using System.Threading.Tasks;
using TFLDataExplorer.Models;

namespace TFLDataExplorer
{
    public interface IStationService
    {
        Task<StationsModel> GetStationsAsync(string uri);
    }
}