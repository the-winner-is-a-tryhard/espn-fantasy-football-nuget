using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class PlayerPoolEntry
	{
		public int AppliedStatTotal { get; set; }
		public int Id { get; set; }
		public int KeeperValue { get; set; }
		public int KeeperValueFuture { get; set; }
		public bool LineupLocked { get; set; }
		public int OnTeamId { get; set; }
		public Player Player { get; set; }
		public Dictionary<string, Rating> Ratings { get; set; }
		public bool RosterLocked { get; set; }
		public string Status { get; set; }
		public bool TradeLocked { get; set; }
	}
}