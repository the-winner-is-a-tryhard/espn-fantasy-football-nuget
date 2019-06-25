using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class DraftSettings
	{
		public int AuctionBudget { get; set; }
		public bool IsTradingEnabled { get; set; }
		public int KeeperCount { get; set; }
		public int KeeperCountFuture { get; set; }
		public long KeeperDeadlineFutureDate { get; set; }
		public string KeeperOrderType { get; set; }
		public string LeagueSubType { get; set; }
		public string OrderType { get; set; }
		public IList<int> PickOrder { get; set; }
		public int TimePerSelection { get; set; }
		public string Type { get; set; }
	}
}