namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class Team
    {
        public int WaiverRank { get; set; }
        public Division Division { get; set; }
        public string TeamAbbrev { get; set; }
        public string TeamNickname { get; set; }
        public string LogoUrl { get; set; }
        public string TeamLocation { get; set; }
        public int TeamId { get; set; }
        public string LogoType { get; set; }
    }
}
