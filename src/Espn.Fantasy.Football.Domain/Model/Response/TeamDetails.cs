using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class TeamDetails : Team
    {
        public int DivisionStanding { get; set; }
        public int Percentile { get; set; }
        public int OverallStanding { get; set; }
        public List<DraftPick> DraftPicks { get; set; }
        public TeamTransactions TeamTransactions { get; set; }
        public List<ScheduleItem> ScheduleItems { get; set; }
        public Record Record { get; set; }
        public int Rank { get; set; }
        public List<Owner> Owners { get; set; }
    }
}
