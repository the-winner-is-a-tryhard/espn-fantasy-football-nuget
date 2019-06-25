namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class FinanceSettings
	{
		public int EntryFee { get; set; }
		public int MiscFee { get; set; }
		public int PerLoss { get; set; }
		public int PerTrade { get; set; }
		public int PlayerAcquisition { get; set; }
		public int PlayerDrop { get; set; }
		public int PlayerMoveToActive { get; set; }
		public int PlayerMoveToIr { get; set; }
	}
}