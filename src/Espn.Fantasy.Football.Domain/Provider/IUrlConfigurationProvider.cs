namespace Espn.Fantasy.Football.Domain.Provider
{
    /// <summary>
    /// URL provider for ESPN's API
    /// </summary>
    public interface IUrlConfigurationProvider
    {
        /// <summary>
        /// Creates URL for the league endpoint
        /// </summary>
        /// <param name="leagueId">ESPN league ID</param>
        /// <param name="year">Four-digit year</param>
        /// <returns>Complete league URL</returns>
        string GetLeagueEndpointUrl(int leagueId, int year);
        
        /// <summary>
        /// Creates URL for the scoreboard endpoint
        /// </summary>
        /// <param name="leagueId">ESPN league ID</param>
        /// <param name="year">Four-digit year</param>
        /// <returns>Complete scoreboard URL</returns>
        string GetScoreboardEndpoint(int leagueId, int year);
        
        /// <summary>
        /// Creates URL for the recent activity endpoint
        /// </summary>
        /// <param name="leagueId">ESPN league ID</param>
        /// <param name="year">Four-digit year</param>
        /// <returns>Complete recent activity URL</returns>
        string GetRecentActivityEndpoint(int leagueId, int year);
        
        /// <summary>
        /// Creates URL for the player stats webpage
        /// </summary>
        /// <param name="playerId"></param>
        /// <returns>Complete NFL player URL</returns>
        string GetNflPlayerEndpoint(int playerId);
    }
}
