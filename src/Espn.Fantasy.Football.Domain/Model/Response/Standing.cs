namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Standing
	{
		public int GamesBack { get; set; }
		public int Losses { get; set; }
		public double Percentage { get; set; }
		public int PointsAgainst { get; set; }
		public int PointsFor { get; set; }
		public int StreakLength { get; set; }
		public string StreakType { get; set; }
		public int Ties { get; set; }
		public int Wins { get; set; }
	}
}