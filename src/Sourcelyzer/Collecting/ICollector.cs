using System.Collections.Generic;
using System.Threading.Tasks;
using Sourcelyzer.Model;

namespace Sourcelyzer.Collecting
{
    public interface ICollector
    {
        Task<IEnumerable<IRepository>> GetRepositoriesAsync();
    }
}
