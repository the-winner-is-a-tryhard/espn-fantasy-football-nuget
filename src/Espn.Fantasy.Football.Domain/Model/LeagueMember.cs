namespace Espn.Fantasy.Football.Domain.Model
{
    public class LeagueMember
    {
        public bool IsReverseItem { get; set; }
        public int StatId { get; set; }
        public decimal Points { get; set; }
        public bool IsTeamScoringItem { get; set; }
    }
}
