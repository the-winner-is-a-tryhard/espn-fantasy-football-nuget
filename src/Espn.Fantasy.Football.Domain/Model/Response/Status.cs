using System;
using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Status
	{
		public long ActivatedDate { get; set; }
		public int CreatedAsLeagueType { get; set; }
		public int CurrentLeagueType { get; set; }
		public int CurrentMatchupPeriod { get; set; }
		public int FinalScoringPeriod { get; set; }
		public int FirstScoringPeriod { get; set; }
		public bool IsActive { get; set; }
		public bool IsExpired { get; set; }
		public bool IsFull { get; set; }
		public bool IsPlayoffMatchupEdited { get; set; }
		public bool IsToBeDeleted { get; set; }
		public bool IsViewable { get; set; }
		public bool IsWaiverOrderEdited { get; set; }
		public LastUpdateInfo LastUpdateInfo { get; set; }
		public int LatestScoringPeriod { get; set; }
		public IList<int> PreviousSeasons { get; set; }
		public long StandingsUpdateDate { get; set; }
		public int TeamsJoined { get; set; }
		public int TransactionScoringPeriod { get; set; }
		public long WaiverLastExecutionDate { get; set; }
		public Dictionary<DateTime, int> WaiverProcessStatus { get; set; }
	}
}