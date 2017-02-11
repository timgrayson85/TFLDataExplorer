using System.Collections.Generic;
using System.Threading.Tasks;

namespace TFLDataExplorer
{
    public interface IAPIContextAsync
    {
        Task<IEnumerable<T>> GetObject<T>(string uriActionString);
    }
}