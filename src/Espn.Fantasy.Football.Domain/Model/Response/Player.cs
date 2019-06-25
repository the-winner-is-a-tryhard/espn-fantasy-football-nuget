using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Player
	{
		public bool Active { get; set; }
		public int DefaultPositionId { get; set; }
		public Dictionary<string, Ranking> DraftRanksByRankType { get; set; }
		public bool Droppable { get; set; }
		public IList<int> EligibleSlots { get; set; }
		public string FirstName { get; set; }
		public string FullName { get; set; }
		public int Id { get; set; }
		public bool Injured { get; set; }
		public string InjuryStatus { get; set; }
		public string Jersey { get; set; }
		public string LastName { get; set; }
		public long LastNewsDate { get; set; }
		public long LastVideoDate { get; set; }
		public Ownership Ownership { get; set; }
		public int ProTeamId { get; set; }
		public Dictionary<string, IList<Ranking>> Rankings { get; set; }
		public IList<Stat> Stats { get; set; }
		public int UniverseId { get; set; }
	}
}