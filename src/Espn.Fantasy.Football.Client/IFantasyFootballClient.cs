using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model.Response;

namespace Espn.Fantasy.Football.Client
{
    /// <summary>
    /// ESPN fantasy football client
    /// </summary>
    public interface IFantasyFootballClient
    {
        /// <summary>
        /// Fetches league data asynchronously 
        /// </summary>
        /// <param name="leagueId">ESPN league ID</param>
        /// <param name="year">Four-digit year</param>
        /// <returns>League data</returns>
        Task<League> GetLeagueAsync(int leagueId, int year);

        /// <summary>
        /// Fetches an NFL player's name for their ID
        /// </summary>
        /// <param name="playerId">ESPN NFL player ID</param>
        /// <returns>NFL player name</returns>
        Task<string> GetNflPlayerNameForId(int playerId);
    }
}
