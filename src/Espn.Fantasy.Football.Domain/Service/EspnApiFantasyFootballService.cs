﻿using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model;
using Espn.Fantasy.Football.Domain.Provider;

namespace Espn.Fantasy.Football.Domain.Service
{
    public class EspnApiFantasyFootballService : IFantasyFootballService
    {
        private readonly IHttpProvider _httpProvider;
        private readonly IUrlConfigurationProvider _urlConfigurationProvider;

        public EspnApiFantasyFootballService(IHttpProvider httpProvider, IUrlConfigurationProvider urlConfigurationProvider)
        {
            _httpProvider = httpProvider;
            _urlConfigurationProvider = urlConfigurationProvider;
        }

        public async Task<League> GetLeagueAsync(int leagueId, int year)
        {
            string url = _urlConfigurationProvider.GetLeagueEndpointUrlWithBase(leagueId, year);
            return await _httpProvider.GetAsync<League>(url);
        }

        public async Task<LeagueScoreboard> GetScoreboardAsync(int leagueId, int year)
        {
            string url = _urlConfigurationProvider.GetScoreboardEndpointWithBase(leagueId, year);
            return await _httpProvider.GetAsync<LeagueScoreboard>(url);
        }
    }
}
