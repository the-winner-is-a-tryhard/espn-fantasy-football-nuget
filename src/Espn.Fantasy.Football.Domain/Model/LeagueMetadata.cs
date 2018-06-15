using System;

namespace Espn.Fantasy.Football.Domain.Model
{
    public class LeagueMetadata
    {
        public string LeagueId { get; set; }
        public string Defaults { get; set; }
        public string Status { get; set; }
        public DateTime DateModifiedLeague { get; set; }
        public string SeasonId { get; set; }
        public DateTime ServerDate { get; set; }
        public DateTime DateModifiedUser { get; set; }
    }
}
