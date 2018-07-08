using System;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class LeagueMetadata
    {
        public int LeagueId { get; set; }
        public Defaults Defaults { get; set; }
        public string Status { get; set; }
        public DateTime DateModifiedLeague { get; set; }
        public int SeasonId { get; set; }
        public DateTime ServerDate { get; set; }
        public DateTime DateModifiedUser { get; set; }
    }
}
