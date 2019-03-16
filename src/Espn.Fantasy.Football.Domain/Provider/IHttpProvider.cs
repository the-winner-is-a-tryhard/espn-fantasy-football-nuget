using System.Threading.Tasks;

namespace Espn.Fantasy.Football.Domain.Provider
{
    /// <summary>
    /// Provider that executes HTTP requests
    /// </summary>
    public interface IHttpProvider
    {
        /// <summary>
        /// Executes a simple GET request for the specified URL and deserializes to type T
        /// </summary>
        /// <param name="url">URL</param>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>Response</returns>
        Task<T> GetAsync<T>(string url);
    }
}
