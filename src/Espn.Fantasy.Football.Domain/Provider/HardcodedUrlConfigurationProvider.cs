namespace Espn.Fantasy.Football.Domain.Provider
{
    public class HardcodedUrlConfigurationProvider :IUrlConfigurationProvider
    {
        public string GetUrlBase()
        {
            return "http://games.espn.com/ffl/api/v2/";
        }

        public string GetLeagueEndpointUrlWithBase(int leagueId, int year)
        {
            const string LEAGUE_ENDPOINT_FORMAT = "{0}leagueSettings?leagueId={1}&seasonId={2}";
            return string.Format(LEAGUE_ENDPOINT_FORMAT, GetUrlBase(), leagueId, year);
        }
    }
}
