using System;
using System.Collections.Generic;
using Espn.Fantasy.Football.Domain.Model.Response;

namespace Espn.Fantasy.Football.Tests.Assets.RecentActivitySerialization
{
    public static class CSharpRecentActivityTestCaseConstants
    {
        public static readonly RecentActivity RECENT_ACTIVITY_OUTPUT_OBJECT = new RecentActivity()
        {
            Items = new List<RecentActivityItem>()
            {
                new RecentActivityItem()
                {
                    Date = new DateTime(2018, 11, 4, 15, 23, 57, 755),
                    TransactionLogItemTypeId = 2,
                    ParentPendingMoveBatchId = 0,
                    Rating = 0,
                    DateAccepted = null,
                    ProposingTeamId = 1,
                    ActingAsTeamOwner = false,
                    DateToProcess = null,
                    UsersProtestTrade = null,
                    TradeProposalExpirationDays = 0,
                    ProposingUserProfileId = 26483835,
                    ScoringPeriodToProcess = 0,
                    PendingMoveBatchId = 0,
                    BidAmount = 0,
                    SkipTransactionCounters = false,
                    DateModified = null,
                    TeamsVotedApproveTrade = null,
                    BatchProcessed = true,
                    TeamsInvolved = new List<int>()
                    {
                        1
                    },
                    DateProposed = null,
                    StatusId = 1,
                    ByLm = false,
                    TeamsVotedVetoTrade = null,
                    TypeId = 5,
                    UserProfileId = 26483835,
                    TeamsAcceptedTrade = null,
                    ActivityType = "2",
                    PendingMoveItems = new List<PendingMoveItem>()
                    {
                         new PendingMoveItem()
                         {
                             FromSlotCategoryId = 1001,
                             MoveTypeId = 2,
                             ToTeamId = 1,
                             Keeper = false,
                             FromTeamId = -1,
                             Rating = 0,
                             ToSlotCategoryId = 20,
                             DraftOverallSelection = 0,
                             PlayerId = 18733
                         },
                        new PendingMoveItem()
                        {
                            FromSlotCategoryId = 23,
                            MoveTypeId = 3,
                            ToTeamId = -1,
                            Keeper = false,
                            FromTeamId = 1,
                            Rating = 0,
                            ToSlotCategoryId = 1001,
                            DraftOverallSelection = 0,
                            PlayerId = 18313
                        }
                    }
                }
            }
        };
    }
}