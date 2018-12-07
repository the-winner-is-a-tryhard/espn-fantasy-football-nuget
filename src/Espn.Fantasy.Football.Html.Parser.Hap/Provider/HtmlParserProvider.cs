using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Html.Parser.Hap.Exception;
using HtmlAgilityPack;

namespace Espn.Fantasy.Football.Html.Parser.Hap.Provider
{
    public class HtmlParser : IHtmlParserProvider
    {
        public string getInnerTextForFirstXPathMatch(string url, string xPath)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load(url);
            HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode(xPath);
            if (htmlNode == null)
            {
                throw new NoNodesForXPathException();
            }
            return htmlNode.InnerText;
        }
    }
}