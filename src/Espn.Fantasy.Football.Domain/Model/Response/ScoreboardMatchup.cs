using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class ScoreboardMatchup
    {
        public List<ScoreboardTeam> Teams { get; set; }
        public string Winner { get; set; }
        public bool Bye { get; set; }
    }
}
