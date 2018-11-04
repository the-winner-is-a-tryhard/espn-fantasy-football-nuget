using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class DraftPick
    {
        public int DraftPickId { get; set; }
        public IList<int> OwningTeams { get; set; }
        public int RoundSelection { get; set; }
        public bool IsTradeLocked { get; set; }
        public bool IsKeeper { get; set; }
        public int Round { get; set; }
        public int OverallSelection { get; set; }
        public PlayerPotentialTransactions PlayerPotentialTransactions { get; set; }
    }
}
