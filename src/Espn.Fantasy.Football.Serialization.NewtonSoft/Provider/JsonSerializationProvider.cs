using Espn.Fantasy.Football.Domain.Model.Exception;
using Espn.Fantasy.Football.Domain.Provider;
using Newtonsoft.Json;

namespace Espn.Fantasy.Football.Serialization.NewtonSoft.Provider
{
    /// <inheritdoc />
    public class JsonSerializationProvider : IJsonSerializationProvider
    {
        /// <inheritdoc/>
        public T DeserializeJson<T>(string json)
        {
            EspnServerErrorResponse espnServerErrorResponse = JsonConvert.DeserializeObject<EspnServerErrorResponse>(json);
            if (espnServerErrorResponse?.Error == null)
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            throw new EspnServerErrorException()
            {
                EspnServerErrorMessage = espnServerErrorResponse.Error
            };
        }
    }
}