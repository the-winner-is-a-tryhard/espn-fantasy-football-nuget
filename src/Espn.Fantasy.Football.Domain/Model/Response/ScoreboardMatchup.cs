using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class ScoreboardMatchup
    {
        public IList<ScoreboardTeam> Teams { get; set; }
        public string Winner { get; set; }
        public bool Bye { get; set; }
    }
}
