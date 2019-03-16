using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Html.Parser.Hap.Exception;
using HtmlAgilityPack;

namespace Espn.Fantasy.Football.Html.Parser.Hap.Provider
{
    /// <inheritdoc />
    public class HtmlParser : IHtmlParserProvider
    {
        /// <inheritdoc />
        public async Task<string> getInnerTextForFirstXPathMatch(string url, string xPath)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = await htmlWeb.LoadFromWebAsync(url);
            HtmlNode htmlNode = htmlDocument.DocumentNode.SelectSingleNode(xPath);
            if (htmlNode == null)
            {
                throw new NoNodesForXPathException();
            }
            return htmlNode.InnerText;
        }
    }
}