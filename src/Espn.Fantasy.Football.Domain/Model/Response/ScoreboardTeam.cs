using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class ScoreboardTeam
    {
        public bool Home { get; set; }
        public decimal Score { get; set; }
        public TeamRecord Team { get; set; }
        public int TeamId { get; set; }
        public List<int> PlayerIDs { get; set; }
    }
}
