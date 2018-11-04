using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class TeamTransactions
    {
        public int MoveToIr { get; set; }
        public IList<MatchupAcquisitionTotal> MatchupAcquisitionTotals { get; set; }
        public int MiscTeamCharges { get; set; }
        public int AcquisitionBudgetSpent { get; set; }
        public int AmountPaid { get; set; }
        public int Drops { get; set; }
        public int MoveToActive { get; set; }
        public int Trades { get; set; }
        public int OverallAcquisitionTotal { get; set; }
        public int OffseasonAcquisitionTotal { get; set; }
    }
}
