namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IUrlConfigurationProvider
    {
        string GetUrlBase();
        string GetLeagueEndpointUrlWithBase(int leagueId, int year);
        string GetScoreboardEndpointWithBase(int leagueId, int year);
    }
}
