using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model.Response;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Domain.Service;
using FakeItEasy;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Unit.Service
{
    [TestFixture]
    public class EspnApiFantasyFootballServiceTests
    {
        [Test]
        public async Task Should_GetLeagueAsync_ForValidInput()
        {
            //arrange
            int leagueId = 555555;
            int year = 2018;
            IHttpProvider httpProvider = A.Fake<IHttpProvider>();
            IUrlConfigurationProvider urlConfigurationProvider = A.Fake<IUrlConfigurationProvider>();
            IFantasyFootballService fantasyFootballService = new EspnApiFantasyFootballService(httpProvider, urlConfigurationProvider);
            
            //act
            League league = await fantasyFootballService.GetLeagueAsync(leagueId, year);

            //assert
            A.CallTo(() => urlConfigurationProvider.GetLeagueEndpointUrlWithBase(leagueId, year)).MustHaveHappened();
            A.CallTo(() => httpProvider.GetAsync<League>(null)).WithAnyArguments().MustHaveHappened();
        }
        
        [Test]
        public async Task Should_GetScoreboardAsync_ForValidInput()
        {
            //arrange
            int leagueId = 555555;
            int year = 2018;
            IHttpProvider httpProvider = A.Fake<IHttpProvider>();
            IUrlConfigurationProvider urlConfigurationProvider = A.Fake<IUrlConfigurationProvider>();
            IFantasyFootballService fantasyFootballService = new EspnApiFantasyFootballService(httpProvider, urlConfigurationProvider);
            
            //act
            LeagueScoreboard leagueScoreboard = await fantasyFootballService.GetScoreboardAsync(leagueId, year);

            //assert
            A.CallTo(() => urlConfigurationProvider.GetScoreboardEndpointWithBase(leagueId, year)).MustHaveHappened();
            A.CallTo(() => httpProvider.GetAsync<LeagueScoreboard>(null)).WithAnyArguments().MustHaveHappened();
        }
    }
}