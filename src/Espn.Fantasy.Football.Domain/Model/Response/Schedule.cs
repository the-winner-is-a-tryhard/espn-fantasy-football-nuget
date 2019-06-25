namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Schedule
	{
		public Game Away { get; set; }
		public Game Home { get; set; }
		public int Id { get; set; }
		public int MatchupPeriodId { get; set; }
		public string PlayoffTierType { get; set; }
		public string Winner { get; set; }
	}
}