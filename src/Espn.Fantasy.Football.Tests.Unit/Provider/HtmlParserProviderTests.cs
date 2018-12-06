using System;
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
        public void Should_GetInnerTextForXpath_ForStandardInput()
        {
            //arrange
            string url = "http://www.espn.com/nfl/player/_/id/13295/";
            string xpath = "//div/h1";
            HtmlParser htmlParser = new HtmlParser();

            //act
            string playerName = htmlParser.getInnerTextForFirstXpathMatch(url, xpath);

            //assert
            playerName.Should().Be("Emmanuel Sanders");
        }
        
        [Test]
        public void ShouldNot_GetInnerTextForXpath_ForInvalidUrl()
        {
            //arrange
            string url = "not a valid url";
            string xpath = "//div/h1";
            HtmlParser htmlParser = new HtmlParser();

            //act
            Action action = () => htmlParser.getInnerTextForFirstXpathMatch(url, xpath);

            //assert
            action.Should().Throw<UriFormatException>();
        }
        
        [Test]
        public void ShouldNot_GetInnerTextForXpath_ForInvalidXpath()
        {
            //arrange
            string url = "http://www.espn.com/nfl/player/_/id/13295/";
            string xpath = "//notvalid/xpath";
            HtmlParser htmlParser = new HtmlParser();

            //act
            Action action = () => htmlParser.getInnerTextForFirstXpathMatch(url, xpath);

            //assert
            action.Should().Throw<NoNodesForXpathException>();
        }
        
        [Test]
        public void Should_GetInnerTextForXpath_ForMultipleNodeMatches()
        {
            //arrange
            string url = "http://www.espn.com/nfl/player/_/id/13295/";
            string xpath = "//div";
            HtmlParser htmlParser = new HtmlParser();

            //act
            string playerName = htmlParser.getInnerTextForFirstXpathMatch(url, xpath);

            //assert
            playerName.Should().NotBeNull();
        }
    }
}