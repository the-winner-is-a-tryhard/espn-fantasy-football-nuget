using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model
{
    public class ScoreboardTeam
    {
        public bool Home { get; set; }
        public double Score { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public List<int> PlayerIDs { get; set; }
    }
}
