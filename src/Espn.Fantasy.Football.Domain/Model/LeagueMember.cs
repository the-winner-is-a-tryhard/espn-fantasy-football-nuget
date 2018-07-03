namespace Espn.Fantasy.Football.Domain.Model
{
    public class LeagueMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsLeagueManager { get; set; }
        public int InviteId { get; set; }
        public bool IsLeagueCreator { get; set; }
        public int UserProfileId { get; set; }
        public string UserName { get; set; }
    }
}
