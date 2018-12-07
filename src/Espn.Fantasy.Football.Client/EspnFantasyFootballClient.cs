using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model.Response;
using Espn.Fantasy.Football.Domain.Provider;
using Espn.Fantasy.Football.Domain.Service;
using Espn.Fantasy.Football.Html.Parser.Hap.Provider;
using Espn.Fantasy.Football.Serialization.NewtonSoft.Provider;

namespace Espn.Fantasy.Football.Client
{
    public class EspnFantasyFootballClient : IFantasyFootballClient
    {
        private readonly IFantasyFootballService _fantasyFootballService;

        public EspnFantasyFootballClient()
        {
            _fantasyFootballService = new EspnApiFantasyFootballService(
                new SystemDotNetHttpProvider(new JsonSerializationProvider()), new HardcodedUrlConfigurationProvider(),
                new NflPlayerService(new HtmlParser(), new HardcodedUrlConfigurationProvider()));
        }

        public async Task<League> GetLeagueAsync(int leagueId, int year)
        {
            return await _fantasyFootballService.GetLeagueAsync(leagueId, year);
        }

        public async Task<LeagueScoreboard> GetScoreboardAsync(int leagueId, int year)
        {
            return await _fantasyFootballService.GetScoreboardAsync(leagueId, year);
        }

        public async Task<RecentActivity> GetRecentActivity(int leagueId, int year)
        {
            return await _fantasyFootballService.GetRecentActivity(leagueId, year);
        }
    }
}
