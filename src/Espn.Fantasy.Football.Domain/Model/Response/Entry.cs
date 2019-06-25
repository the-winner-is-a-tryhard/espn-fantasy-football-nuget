namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Entry
	{
		public long AcquisitionDate { get; set; }
		public string AcquisitionType { get; set; }
		public string InjuryStatus { get; set; }
		public int LineupSlotId { get; set; }
		public object PendingTransactionIds { get; set; }
		public int PlayerId { get; set; }
		public PlayerPoolEntry PlayerPoolEntry { get; set; }
		public string Status { get; set; }
	}
}