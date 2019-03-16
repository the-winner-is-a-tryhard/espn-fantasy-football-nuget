using Espn.Fantasy.Football.Domain.Service;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Unit.Service
{
    [TestFixture]
    public class EspnHtmlTrimServiceTests
    {
        [Test]
        public void Should_TrimNameFromTitleTag_ForStandardInput()
        {
            //arrange
            string titleTag = "Emmanuel Sanders Stats, News, Bio | ESPN";
            IEspnHtmlTrimService espnHtmlTrimService = new EspnHtmlTrimService();

            //act
            string playerName = espnHtmlTrimService.TrimNameFromTitleTag(titleTag);

            //assert
            playerName.Should().Be("Emmanuel Sanders");
        }

        [Test]
        public void ShouldNot_TrimNameFromTitleTag_ForInvalidInput()
        {
            //arrange
            string titleTag = "Emmanuel Sanders Invalid Additional Text";
            IEspnHtmlTrimService espnHtmlTrimService = new EspnHtmlTrimService();

            //act
            string playerName = espnHtmlTrimService.TrimNameFromTitleTag(titleTag);

            //assert
            playerName.Should().Be("Emmanuel Sanders Invalid Additional Text");
        }
    }
}