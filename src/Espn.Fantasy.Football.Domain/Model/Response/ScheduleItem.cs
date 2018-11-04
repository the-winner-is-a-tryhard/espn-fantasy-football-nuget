using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class ScheduleItem
    {
        public IList<Matchup> Matchups { get; set; }
        public int MatchupPeriodId { get; set; }
    }
}
