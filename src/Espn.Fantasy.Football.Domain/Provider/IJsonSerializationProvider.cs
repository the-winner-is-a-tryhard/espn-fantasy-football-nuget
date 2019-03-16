namespace Espn.Fantasy.Football.Domain.Provider
{
    /// <summary>
    /// Provider for JSON serialization
    /// </summary>
    public interface IJsonSerializationProvider
    {
        /// <summary>
        /// Deserializes JSON to type T
        /// </summary>
        /// <param name="json">JSON</param>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>Object</returns>
        T DeserializeJson<T>(string json);
    }
}
