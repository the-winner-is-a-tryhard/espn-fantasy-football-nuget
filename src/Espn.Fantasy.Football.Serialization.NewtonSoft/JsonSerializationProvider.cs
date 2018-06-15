using Espn.Fantasy.Football.Domain.Provider;
using Newtonsoft.Json;

namespace Espn.Fantasy.Football.Serialization.NewtonSoft
{
    public class JsonSerializationProvider : IJsonSerializationProvider
    {
        public T DeserializeJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
