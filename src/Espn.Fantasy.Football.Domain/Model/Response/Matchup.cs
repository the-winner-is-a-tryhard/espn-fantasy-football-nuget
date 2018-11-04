using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class Matchup
    {
        public int MatchupTypeId { get; set; }
        public IList<double> AwayTeamScores { get; set; }
        public Team AwayTeam { get; set; }
        public double AwayTeamAdjustment { get; set; }
        public int AwayTeamId { get; set; }
        public bool IsBye { get; set; }
        public int HomeTeamId { get; set; }
        public double HomeTeamAdjustment { get; set; }
        public IList<double> HomeTeamScores { get; set; }
        public double HomeTeamBonus { get; set; }
        public double Outcome { get; set; }
        public Team HomeTeam { get; set; }
    }
}
