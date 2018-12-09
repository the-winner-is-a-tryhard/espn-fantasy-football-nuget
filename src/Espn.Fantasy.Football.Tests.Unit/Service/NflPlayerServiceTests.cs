using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Domain.Service;
using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Unit.Service
{
    [TestFixture]
    public class NflPlayerServiceTests
    {
        [Test]
        public async Task Should_GetPlayerNameForId_ForStandardInput()
        {
            //arrange
            int playerId = 55555;
            string url = "http://www.espn.com/nfl/player/_/id/55555";
            string xPath = "//div/h1";
            IHtmlParserProvider htmlParserProvider = A.Fake<IHtmlParserProvider>();
            A.CallTo(() => htmlParserProvider.getInnerTextForFirstXPathMatch(url, xPath)).Returns("Emmanuel Sanders");
            IUrlConfigurationProvider urlConfigurationProvider = A.Fake<IUrlConfigurationProvider>();
            A.CallTo(() => urlConfigurationProvider.GetNflPlayerEndpoint(playerId)).Returns(url);
            NflPlayerService nflPlayerService = new NflPlayerService(htmlParserProvider, urlConfigurationProvider);
            
            //act
            string playerName = await nflPlayerService.GetPlayerNameForId(55555);

            //assert
            playerName.Should().BeEquivalentTo("Emmanuel Sanders");
        }
    }
}