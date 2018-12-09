using System.Threading.Tasks;

namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IHtmlParserProvider
    {
        Task<string> getInnerTextForFirstXPathMatch(string url, string xPath);
    }
}