using System.Threading.Tasks;
using Espn.Fantasy.Football.Client;
using Espn.Fantasy.Football.Domain.Model.Response;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Integration.Client
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public async Task Should_GetLeagueAsync_ForValidInput()
        {
            //arrange
            int leagueId = 526113;
            int year = 2018;
            EspnFantasyFootballClient espnFantasyFootballClient = new EspnFantasyFootballClient();

            //act
            League league = await espnFantasyFootballClient.GetLeagueAsync(leagueId, year);

            //assert
            league.Should().NotBeNull();
        }

        [Test]
        public async Task Should_GetScoreboardAsync_ForValidInput()
        {
            //arrange
            int leagueId = 526113;
            int year = 2018;
            EspnFantasyFootballClient espnFantasyFootballClient = new EspnFantasyFootballClient();

            //act
            LeagueScoreboard leagueScoreboard = await espnFantasyFootballClient.GetScoreboardAsync(leagueId, year);

            //assert
            leagueScoreboard.Should().NotBeNull();
        }
    }
}
