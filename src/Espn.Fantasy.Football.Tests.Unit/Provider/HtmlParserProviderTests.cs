using System;
using System.Threading.Tasks;
using Espn.Fantasy.Football.Html.Parser.Hap.Exception;
using Espn.Fantasy.Football.Html.Parser.Hap.Provider;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Unit.Provider
{
    [TestFixture]
    public class HtmlParserTests
    {
        [Test]
        public async Task Should_GetInnerTextForXPath_ForStandardInput()
        {
            //arrange
            string url = "http://www.espn.com/nfl/player/_/id/13295";
            string xPath = "//div/h1";
            HtmlParser htmlParser = new HtmlParser();

            //act
            string playerName = await htmlParser.getInnerTextForFirstXPathMatch(url, xPath);

            //assert
            playerName.Should().Be("Emmanuel Sanders");
        }
        
        [Test]
        public void  ShouldNot_GetInnerTextForXPath_ForInvalidUrl()
        {
            //arrange
            string url = "not a valid url";
            string xPath = "//div/h1";
            HtmlParser htmlParser = new HtmlParser();

            //act
            Func<Task> action = async () => await htmlParser.getInnerTextForFirstXPathMatch(url, xPath);

            //assert
            action.Should().Throw<UriFormatException>();
        }
        
        [Test]
        public void ShouldNot_GetInnerTextForXPath_ForInvalidXPath()
        {
            //arrange
            string url = "http://www.espn.com/nfl/player/_/id/13295/";
            string xPath = "//notvalid/xPath";
            HtmlParser htmlParser = new HtmlParser();

            //act
            Func<Task> action = async () => await htmlParser.getInnerTextForFirstXPathMatch(url, xPath);

            //assert
            action.Should().Throw<NoNodesForXPathException>();
        }
        
        [Test]
        public async Task Should_GetInnerTextForXPath_ForMultipleNodeMatches()
        {
            //arrange
            string url = "http://www.espn.com/nfl/player/_/id/13295/";
            string xPath = "//div";
            HtmlParser htmlParser = new HtmlParser();

            //act
            string playerName = await htmlParser.getInnerTextForFirstXPathMatch(url, xPath);

            //assert
            playerName.Should().NotBeNull();
        }
    }
}