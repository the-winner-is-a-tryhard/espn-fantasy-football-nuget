using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class TransactionCounter
	{
		public int AcquisitionBudgetSpent { get; set; }
		public int Acquisitions { get; set; }
		public int Drops { get; set; }
		public Dictionary<string, int> MatchupAcquisitionTotals { get; set; }
		public int Misc { get; set; }
		public int MoveToActive { get; set; }
		public int MoveToIR { get; set; }
		public int Paid { get; set; }
		public int TeamCharges { get; set; }
		public int Trades { get; set; }
	}
}