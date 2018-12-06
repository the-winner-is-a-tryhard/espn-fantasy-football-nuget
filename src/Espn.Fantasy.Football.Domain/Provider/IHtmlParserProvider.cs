namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IHtmlParserProvider
    {
        string getInnerTextForFirstXpathMatch(string url, string xpath);
    }
}