namespace Espn.Fantasy.Football.Domain.Provider
{
    public class HardcodedUrlConfigurationProvider : IUrlConfigurationProvider
    {
        public string GetUrlBase()
        {
            return "http://games.espn.com/ffl/api/v2/";
        }

        public string GetLeagueEndpointUrlWithBase(int leagueId, int year)
        {
            const string leagueEndpointFormat = "{0}leagueSettings?leagueId={1}&seasonId={2}";
            return string.Format(leagueEndpointFormat, GetUrlBase(), leagueId, year);
        }

        public string GetScoreboardEndpointWithBase(int leagueId, int year)
        {
            const string scoreboardEndpointFormat = "{0}scoreboard?leagueId={1}&seasonId={2}";
            return string.Format(scoreboardEndpointFormat, GetUrlBase(), leagueId, year);
        }
    }
}
