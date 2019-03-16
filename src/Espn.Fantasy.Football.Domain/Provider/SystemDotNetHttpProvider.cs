using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Espn.Fantasy.Football.Domain.Provider
{
    /// <inheritdoc />
    public class SystemDotNetHttpProvider : IHttpProvider
    {
        private readonly HttpClient _httpClient;
        private readonly IJsonSerializationProvider _jsonSerializationProvider;

        /// <summary>
        /// HTTP provider constructor
        /// </summary>
        /// <param name="jsonSerializationProvider">JSON serialization provider</param>
        public SystemDotNetHttpProvider(IJsonSerializationProvider jsonSerializationProvider)
        {
            _httpClient = new HttpClient();
            _jsonSerializationProvider = jsonSerializationProvider;
        }

        /// <inheritdoc />
        public async Task<T> GetAsync<T>(string url)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string jsonResponse = await _httpClient.GetStringAsync(url);
            return _jsonSerializationProvider.DeserializeJson<T>(jsonResponse);
        }
    }
}
