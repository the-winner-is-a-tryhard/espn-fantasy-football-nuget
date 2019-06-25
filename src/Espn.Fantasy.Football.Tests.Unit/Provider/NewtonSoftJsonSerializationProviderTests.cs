using System;
using Espn.Fantasy.Football.Domain.Model.Exception;
using Espn.Fantasy.Football.Domain.Model.Response;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Serialization.NewtonSoft.Provider;
using Espn.Fantasy.Football.Tests.Assets.LeagueSerialization;
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
            string json = JsonLeagueResponseConstants.ValidLeagueJson;
            IJsonSerializationProvider jsonSerializationProvider = new JsonSerializationProvider();

            //act
            League deserializedLeague = jsonSerializationProvider.DeserializeJson<League>(json);

            //assert
            deserializedLeague.Should().BeEquivalentTo(CSharpLeagueTestCaseConstants.LeagueOutputObject);
        }

        [Test]
        public void Should_ThrowEspnServerErrorException_ForNoPermissionsToViewLeagueJson()
        {
            //arrange
            string json = "{\"error\":[{\"message\":\"No permission to view this league\",\"code\":\"functional\"}]}";
            IJsonSerializationProvider jsonSerializationProvider = new JsonSerializationProvider();

            //act
            Action action = () => jsonSerializationProvider.DeserializeJson<League>(json);

            //assert
            action.Should().Throw<EspnServerErrorException>();
        }
        
        [Test]
        public void Should_ThrowEspnServerErrorException_ForUnableToRetrieveLeagueJson()
        {
            //arrange
            string json = "{\"error\":[{\"message\":\"Unable to retrieve league (2011:526113)\",\"code\":\"functional\"}]}";
            IJsonSerializationProvider jsonSerializationProvider = new JsonSerializationProvider();

            //act
            Action action = () => jsonSerializationProvider.DeserializeJson<League>(json);

            //assert
            action.Should().Throw<EspnServerErrorException>();
        }
    }
}
