using System;
using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class RecentActivityItem
    {
        public DateTime Date { get; set; }
        public int TransactionLogItemTypeId { get; set; }
        public int ParentPendingMoveBatchId { get; set; }
        public int Rating { get; set; }
        public DateTime? DateAccepted { get; set; }
        public int ProposingTeamId { get; set; }
        public bool ActingAsTeamOwner { get; set; }
        public DateTime? DateToProcess { get; set; }
        public IList<int> UsersProtestTrade { get; set; }
        public int TradeProposalExpirationDays { get; set; }
        public int ProposingUserProfileId { get; set; }
        public int ScoringPeriodToProcess { get; set; }
        public int PendingMoveBatchId { get; set; }
        public int BidAmount { get; set; }
        public bool SkipTransactionCounters { get; set; }
        public DateTime? DateModified { get; set; }
        public IList<int> TeamsVotedApproveTrade { get; set; }
        public IList<PendingMoveItem> PendingMoveItems { get; set; }
        public bool BatchProcessed { get; set; }
        public IList<int> TeamsInvolved { get; set; }
        public DateTime? DateProposed { get; set; }
        public int StatusId { get; set; }
        public bool ByLm { get; set; }
        public IList<int> TeamsVotedVetoTrade { get; set; }
        public int TypeId { get; set; }
        public int UserProfileId { get; set; }
        public IList<int> TeamsAcceptedTrade { get; set; }
        public string ActivityType { get; set; }
    }
}