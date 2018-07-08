using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class Matchup
    {
        public int MatchupTypeId { get; set; }
        public List<int> AwayTeamScores { get; set; }
        public Team AwayTeam { get; set; }
        public int AwayTeamAdjustment { get; set; }
        public int AwayTeamId { get; set; }
        public bool IsBye { get; set; }
        public int HomeTeamId { get; set; }
        public int HomeTeamAdjustment { get; set; }
        public List<int> HomeTeamScores { get; set; }
        public int HomeTeamBonus { get; set; }
        public int Outcome { get; set; }
        public Team HomeTeam { get; set; }
    }
}
