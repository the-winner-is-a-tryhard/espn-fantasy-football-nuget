namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IJsonSerializationProvider
    {
        T DeserializeJson<T>(string json);
    }
}
