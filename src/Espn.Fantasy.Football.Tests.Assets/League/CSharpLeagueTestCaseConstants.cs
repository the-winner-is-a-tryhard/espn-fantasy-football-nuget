using System;
using System.Collections.Generic;
using Espn.Fantasy.Football.Domain.Model;

namespace Espn.Fantasy.Football.Tests.Assets.League
{
    public static class CSharpLeagueTestCaseConstants
    {
        public static readonly Domain.Model.League LEAGUE_OUTPUT_OBJECT = new Domain.Model.League()
        {
            LeagueSettings = new LeagueSettings()
            {
                AccessTypeId = 1,
                AllowOutOfUniverseStatsAndTrades = false,
                AllowsTrades = true,
                CurrentKeeperCount = 0,
                DateDraftCompleted = new DateTime(2017, 8, 29, 0, 31, 37),
                DateFutureKeeperLock = new DateTime(2019, 8, 1, 4, 0, 0),
                DefaultUniverseId = 0,
                DefaultWaiverOrder = 0,
                Divisions = new List<Division>
                {
                    new Division()
                    {
                        DivisionId = 0,
                        Name = "Division 1",
                        Size = 12
                    }
                },
                DraftAuctionBudget = 200,
                DraftOrder = new List<int>
                {
                    3,
                    10,
                    4,
                    8,
                    6,
                    13,
                    2,
                    5,
                    12,
                    9,
                    1,
                    11
                },
                DraftOrderTypeId = 0,
                DraftPickTradingEnabled = false,
                DraftStatusTypeId = 1,
                DraftTypeId = 0,
                FinalMatchupPeriodId = 16,
                FinalRegularSeasonMatchupPeriodId = 13,
                FinalScoringPeriodId = 16,
                Finance = new Finance
                {
                    Acquisition = 0,
                    Drop = 0,
                    EntryFee = 0,
                    Loss = 0,
                    MiscFee = 0,
                    MoveToActive = 0,
                    MoveToIr = 0,
                    Trade = 0
                },
                FirstMatchupPeriodId = 1,
                FirstScoringPeriodId = 1,
                FutureKeeperCount = 2,
                HomeTeamBonus = 0m,
                Id = 526113,
                InviteKey = null,
                IsViewable = true,
                LeagueFormatTypeId = 0,
                LeagueMembers = new List<LeagueMember>
                {

                },
                LeagueStatusTypeId = 1,
                LeagueSubTypeId = 0,
                LeagueTypeId = 0,
                LineupLocktimeType = 0,
                MatchupAcquisitionLimits = new List<MatchupAcquisitionLimit>
                {

                },
                MatchupPeriodTypeId = 1,
                MinimumBidAmount = 1,
                Name = "The Winner is a Tryhard",
                PlayerAcquisitionBudget = 100,
                PlayerAcquisitionType = 1,
                PlayoffHomeTeamBonus = 0m,
                PlayoffMatchupLength = 1,
                PlayoffSeedingTieRule = 1,
                PlayoffSeedingTieRuleRawStatId = 0,
                PlayoffSeedings = new List<int>
                {
                    11,
                    1,
                    9,
                    12,
                    5,
                    2,
                    13,
                    6,
                    8,
                    4,
                    10,
                    3
                },
                PlayoffTeamCount = 6,
                PlayoffTieRule = 1,
                PlayoffTieRuleRawStatId = 0,
                PositionItems = new List<PositionItem>
                {

                },
                PremiumTypeId = 0,
                RegularSeasonMatchupLength = 1,
                RegularSeasonMatchupPeriodCount = 13,
                RestrictionTypeId = 0,
                RosterLocktimeType = 0,
                RosterMoveLimit = -1,
                ScoringDecimalPlaces = 2,
                ScoringItems = new List<ScoringItem>
                {

                },
                ScoringPeriodsByMatchupPeriod = new Dictionary<string, List<int>>
                {

                },
                ScoringTypeId = 1,
                Season = 2018,
                SeasonAcquisitionLimit = -1,
                Size = 12m,
                SlotCategoryItems = new List<SlotCategoryItem>
                {

                },
                Teams = new Dictionary<string, TeamDetails>
                {

                },
                TieRule = 0,
                TieRuleRawStatId = -1,
                TimePerDraftSelection = 60,
                TradeDeadline = new DateTime(2018, 11, 21, 17, 0, 0),
                TradeLimit = -1,
                TradeRevisionHours = 24,
                UsesPlayerAcquisitionBudget = false,
                UsingUndroppableList = true,
                VetoVotesRequired = 4,
                WaiverDetails = new List<WaiverDetail>
                {

                },
                WaiverHours = 24,
                WaiverOrderSystemTypeId = 0,
                WaiverProcessDays = 123,
                WaiverProcessHour = 8
            },
            Metadata = new LeagueMetadata()
            {
                DateModifiedLeague = new DateTime(2018, 6, 20, 8, 30, 32),
                DateModifiedUser = new DateTime(1, 1, 1, 0, 0, 0),
                Defaults = new Defaults(),
                LeagueId = 526113,
                SeasonId = 2018,
                ServerDate = new DateTime(2018, 6, 21, 2, 16, 3),
                Status = "undrafted"
            }
        };
    }
}
