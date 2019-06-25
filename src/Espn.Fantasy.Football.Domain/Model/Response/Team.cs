using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Team
	{
		public string Abbrev { get; set; }
		public int DivisionId { get; set; }
		public int Id { get; set; }
		public bool IsActive { get; set; }
		public string Location { get; set; }
		public string Logo { get; set; }
		public string LogoType { get; set; }
		public string Nickname { get; set; }
		public IList<string> Owners { get; set; }
		public int PlayoffSeed { get; set; }
		public double Points { get; set; }
		public int PointsAdjusted { get; set; }
		public int PointsDelta { get; set; }
		public string PrimaryOwner { get; set; }
		public int RankCalculatedFinal { get; set; }
		public int RankFinal { get; set; }
		public Record Record { get; set; }
		public Roster Roster { get; set; }
		public TradeBlock TradeBlock { get; set; }
		public TransactionCounter TransactionCounter { get; set; }
		public Dictionary<string, int> ValuesByStat { get; set; }
		public int WaiverRank { get; set; }
	}
}