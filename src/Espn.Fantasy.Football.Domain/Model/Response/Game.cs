using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Game
	{
		public int Adjustment { get; set; }
		public CumulativeScore CumulativeScore { get; set; }
		public Dictionary<string, double> PointsByScoringPeriod { get; set; }
		public int TeamId { get; set; }
		public int Tiebreak { get; set; }
		public double TotalPoints { get; set; }
	}
}