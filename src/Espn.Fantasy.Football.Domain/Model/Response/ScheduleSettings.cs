using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class ScheduleSettings
	{
		public IList<Division> Divisions { get; set; }
		public int MatchupPeriodCount { get; set; }
		public int MatchupPeriodLength { get; set; }
		public Dictionary<string, IList<int>> MatchupPeriods { get; set; }
		public int PeriodTypeId { get; set; }
		public int PlayoffMatchupPeriodLength { get; set; }
		public string PlayoffSeedingRule { get; set; }
		public int PlayoffSeedingRuleBy { get; set; }
		public int PlayoffTeamCount { get; set; }
	}
}