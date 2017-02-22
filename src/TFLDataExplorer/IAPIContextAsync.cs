using System.Collections.Generic;
using System.Threading.Tasks;

namespace TFLDataExplorer
{
    public interface IAPIContextAsync
    {
        Task<IEnumerable<T>> GetObjectsAsync<T>(string uriActionString);
        Task<T> GetObjectAsync<T>(string uriActionString);

    }
}