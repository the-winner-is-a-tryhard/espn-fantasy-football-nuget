namespace Espn.Fantasy.Football.Domain.Provider
{
    public class HardcodedUrlConfigurationProvider : IUrlConfigurationProvider
    {
        public string GetLeagueEndpointUrl(int leagueId, int year)
        {
            const string leagueEndpointFormat = "{0}leagueSettings?leagueId={1}&seasonId={2}";
            return string.Format(leagueEndpointFormat, GetFantasyUrlBase(), leagueId, year);
        }

        public string GetScoreboardEndpoint(int leagueId, int year)
        {
            const string scoreboardEndpointFormat = "{0}scoreboard?leagueId={1}&seasonId={2}";
            return string.Format(scoreboardEndpointFormat, GetFantasyUrlBase(), leagueId, year);
        }

        public string GetRecentActivityEndpoint(int leagueId, int year)
        {
            const string recentActivityEndpointFormat = "{0}recentActivity?leagueId={1}&seasonId={2}";
            return string.Format(recentActivityEndpointFormat, GetFantasyUrlBase(), leagueId, year);
        }

        public string GetNflPlayerEndpoint(int playerId)
        {
            const string nflPlayerEndpointFormat = "http://www.espn.com/nfl/player/_/id/{0}";
            return string.Format(nflPlayerEndpointFormat, playerId);
        }
        
        private string GetFantasyUrlBase()
        {
            return "http://games.espn.com/ffl/api/v2/";
        }
    }
}
