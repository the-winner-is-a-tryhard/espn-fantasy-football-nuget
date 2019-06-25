namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Ranking
	{
		public int AuctionValue { get; set; }
		public int Rank { get; set; }
		public int RankSourceId { get; set; }
		public string RankType { get; set; }
		public int SlotId { get; set; }
	}
}