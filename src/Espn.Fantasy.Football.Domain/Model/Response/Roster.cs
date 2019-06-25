using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Roster
	{
		public double AppliedStatTotal { get; set; }
		public IList<Entry> Entries { get; set; }
	}
}