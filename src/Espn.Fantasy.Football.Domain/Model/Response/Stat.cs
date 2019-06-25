using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Stat
	{
		public double AppliedAverage { get; set; }
		public Dictionary<string, double> AppliedStats { get; set; }
		public double AppliedTotal { get; set; }
		public string ExternalId { get; set; }
		public string Id { get; set; }
		public int ProTeamId { get; set; }
		public int ScoringPeriodId { get; set; }
		public int SeasonId { get; set; }
		public int StatSourceId { get; set; }
		public int StatSplitTypeId { get; set; }
		public Dictionary<string, double> Stats { get; set; }
	}
}