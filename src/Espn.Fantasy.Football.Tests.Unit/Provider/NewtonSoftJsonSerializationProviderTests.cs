using Espn.Fantasy.Football.Domain.Model;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Serialization.NewtonSoft;
using Espn.Fantasy.Football.Tests.Assets.LeagueSerialization;
using Espn.Fantasy.Football.Tests.Assets.ScoreboardSerialization;
using FluentAssertions;
using NUnit.Framework;

namespace Espn.Fantasy.Football.Tests.Unit.Provider
{
    [TestFixture]
    public class NewtonSoftJsonSerializationProviderTests
    {
        [Test]
        public void Should_DeserializeLeagueJson_ForValidInput()
        {
            //arrange
            string json = JsonLeagueResponseConstants.VALID_LEAGUE_JSON;
            IJsonSerializationProvider jsonSerializationProvider = new JsonSerializationProvider();

            //act
            League deserializedLeague = jsonSerializationProvider.DeserializeJson<League>(json);

            //assert
            deserializedLeague.Should().BeEquivalentTo(CSharpLeagueTestCaseConstants.LEAGUE_OUTPUT_OBJECT);
        }

        [Test]
        public void Should_DeserializeScoreboardJson_ForValidInput()
        {
            //arrange
            string json = JsonScoreboardResponseConstants.VALID_SCOREBOARD_JSON;
            IJsonSerializationProvider jsonSerializationProvider = new JsonSerializationProvider();
            
            //act
            LeagueScoreboard deserializedScoreboard = jsonSerializationProvider.DeserializeJson<LeagueScoreboard>(json);
            
            //assert
            deserializedScoreboard.Should().BeEquivalentTo(CSharpScoreboardTestCaseConstants.SCOREBOARD_OUTPUT_OBJECT);
        }
    }
}
