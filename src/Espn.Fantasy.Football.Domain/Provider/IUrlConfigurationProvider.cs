namespace Espn.Fantasy.Football.Domain.Provider
{
    public interface IUrlConfigurationProvider
    {
        string GetLeagueEndpointUrl(int leagueId, int year);
        string GetScoreboardEndpoint(int leagueId, int year);
        string GetRecentActivityEndpoint(int leagueId, int year);
        string GetNflPlayerEndpoint(int playerId);
    }
}
