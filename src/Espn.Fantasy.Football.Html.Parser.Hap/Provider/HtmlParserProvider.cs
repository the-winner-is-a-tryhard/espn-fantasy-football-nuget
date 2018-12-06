using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Html.Parser.Hap.Exception;
using HtmlAgilityPack;

namespace Espn.Fantasy.Football.Html.Parser.Hap.Provider
{
    public class HtmlParser : IHtmlParserProvider
    {
        public string getInnerTextForFirstXpathMatch(string url, string xpath)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load(url);
            HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode(xpath);
            if (htmlNode == null)
            {
                throw new NoNodesForXpathException();
            }
            return htmlNode.InnerText;
        }
    }
}