﻿using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Model;

namespace Espn.Fantasy.Football.Client
{
    public interface IFantasyFootballClient
    {
        Task<League> GetLeagueAsync(int leagueId, int year);
        Task<LeagueScoreboard> GetScoreboardAsync(int leagueId, int year);
    }
}