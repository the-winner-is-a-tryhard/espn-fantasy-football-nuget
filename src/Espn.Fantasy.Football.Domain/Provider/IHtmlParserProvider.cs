using System.Threading.Tasks;

namespace Espn.Fantasy.Football.Domain.Provider
{
    /// <summary>
    /// Provider that fetches an HTML web page and parses it using xPath
    /// </summary>
    public interface IHtmlParserProvider
    {
        /// <summary>
        /// Fetches HTML for URL and returns the first xPath match
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="xPath">xPath</param>
        /// <returns>Inner text of first match</returns>
        Task<string> getInnerTextForFirstXPathMatch(string url, string xPath);
    }
}