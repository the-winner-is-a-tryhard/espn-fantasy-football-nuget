namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class Owner
    {
        public string LastName { get; set; }
        public bool PrimaryOwner { get; set; }
        public bool LeagueManager { get; set; }
        public bool Joined { get; set; }
        public int InviteId { get; set; }
        public int OwnerId { get; set; }
        public int UserProfileId { get; set; }
        public string PhotoUrl { get; set; }
        public string FirstName { get; set; }
    }
}
