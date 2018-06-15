using System.Threading.Tasks;

namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IHttpProvider
    {
        Task<T> GetAsync<T>(string url);
    }
}
