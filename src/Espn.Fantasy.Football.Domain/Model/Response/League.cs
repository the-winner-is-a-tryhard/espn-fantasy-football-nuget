using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class League
	{
		public DraftDetail DraftDetail { get; set; }
		public int GameId { get; set; }
		public int Id { get; set; }
		public IList<Member> Members { get; set; }
		public IList<Schedule> Schedule { get; set; }
		public int ScoringPeriodId { get; set; }
		public int SeasonId { get; set; }
		public int SegmentId { get; set; }
		public Settings Settings { get; set; }
		public Status Status { get; set; }
		public IList<Team> Teams { get; set; }
	}
}