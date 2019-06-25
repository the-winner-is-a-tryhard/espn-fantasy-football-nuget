namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class ScoreByStat
	{
		public bool Ineligible { get; set; }
		public int Rank { get; set; }
		public object Result { get; set; }
		public int Score { get; set; }	
	}
}