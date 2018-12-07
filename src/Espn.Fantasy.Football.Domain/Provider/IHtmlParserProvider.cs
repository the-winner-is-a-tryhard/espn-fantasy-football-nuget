namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IHtmlParserProvider
    {
        string getInnerTextForFirstXPathMatch(string url, string xPath);
    }
}