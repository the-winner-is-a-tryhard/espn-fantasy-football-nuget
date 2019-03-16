using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model.Response;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Domain.Service;
using Espn.Fantasy.Football.Html.Parser.Hap.Provider;
using Espn.Fantasy.Football.Serialization.NewtonSoft.Provider;

namespace Espn.Fantasy.Football.Client
{
    /// <inheritdoc />
    public class EspnFantasyFootballClient : IFantasyFootballClient
    {
        private readonly IFantasyFootballService _fantasyFootballService;
        private readonly INflPlayerService _nflPlayerService;

        /// <summary>
        /// Client constructor method
        /// </summary>
        public EspnFantasyFootballClient()
        {
            _fantasyFootballService = new EspnApiFantasyFootballService(
                new SystemDotNetHttpProvider(new JsonSerializationProvider()), new HardcodedUrlConfigurationProvider());
            _nflPlayerService = new NflPlayerService(new HtmlParser(), new HardcodedUrlConfigurationProvider());
        }

        /// <inheritdoc />
        public async Task<League> GetLeagueAsync(int leagueId, int year)
        {
            return await _fantasyFootballService.GetLeagueAsync(leagueId, year);
        }

        /// <inheritdoc />
        public async Task<LeagueScoreboard> GetScoreboardAsync(int leagueId, int year)
        {
            return await _fantasyFootballService.GetScoreboardAsync(leagueId, year);
        }

        /// <inheritdoc />
        public async Task<RecentActivity> GetRecentActivity(int leagueId, int year)
        {
            return await _fantasyFootballService.GetRecentActivity(leagueId, year);
        }

        /// <inheritdoc />
        public async Task<string> GetNflPlayerNameForId(int playerId)
        {
            return await _nflPlayerService.GetPlayerNameForId(playerId);
        }
    }
}
