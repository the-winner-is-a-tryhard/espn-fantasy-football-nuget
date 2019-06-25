using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class RosterSettings
	{
		public bool IsBenchUnlimited { get; set; }
		public bool IsUsingUndroppableList { get; set; }
		public string LineupLocktimeType { get; set; }
		public Dictionary<string, int> LineupSlotCounts { get; set; }
		public Dictionary<string, int> LineupSlotStatLimits { get; set; }
		public int MoveLimit { get; set; }
		public Dictionary<string, int> PositionLimits { get; set; }
		public string RosterLocktimeType { get; set; }
		public IList<int> UniverseIds { get; set; }
	}
}