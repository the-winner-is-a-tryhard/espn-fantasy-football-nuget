using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model
{
    public class ScheduleItem
    {
        public List<Matchup> Matchups { get; set; }
        public int MatchupPeriodId { get; set; }
    }
}
