using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class CumulativeScore
	{
		public int Losses { get; set; }
		public Dictionary<string, ScoreByStat> ScoreByStat { get; set; }
		public object StatBySlot { get; set; }
		public int Ties { get; set; }
		public int Wins { get; set; }
	}
}