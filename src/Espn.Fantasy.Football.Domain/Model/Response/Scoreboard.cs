using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class Scoreboard
    {
        public bool ProGamesInProgress { get; set; }
        public int ScoringPeriodId { get; set; }
        public List<ScoreboardMatchup> Matchups { get; set; }
        public int MatchupPeriodId { get; set; }
    }
}
