using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class AcquisitionSettings
	{
		public int AcquisitionBudget { get; set; }
		public int AcquisitionLimit { get; set; }
		public string AcquisitionType { get; set; }
		public bool IsUsingAcquisitionBudget { get; set; }
		public bool IsUsingVickeryRules { get; set; }
		public int MatchupAcquisitionLimit { get; set; }
		public bool MatchupLimitPerScoringPeriod { get; set; }
		public int MinimumBid { get; set; }
		public int WaiverHours { get; set; }
		public bool WaiverOrderReset { get; set; }
		public IList<string> WaiverProcessDays { get; set; }
		public int WaiverProcessHour { get; set; }
	}
}