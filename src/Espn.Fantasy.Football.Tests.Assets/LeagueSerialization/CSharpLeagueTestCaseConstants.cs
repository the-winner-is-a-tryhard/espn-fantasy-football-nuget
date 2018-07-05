using System;
using System.Collections.Generic;
using Espn.Fantasy.Football.Domain.Model;

namespace Espn.Fantasy.Football.Tests.Assets.LeagueSerialization
{
    public static class CSharpLeagueTestCaseConstants
    {
        public static readonly League LEAGUE_OUTPUT_OBJECT = new League()
        {
            LeagueSettings = new LeagueSettings()
            {
                AccessTypeId = 1,
                AllowOutOfUniverseStatsAndTrades = false,
                AllowsTrades = true,
                CurrentKeeperCount = 0,
                DateDraftCompleted = new DateTime(2017, 8, 29, 0, 31, 37, 647),
                DateFutureKeeperLock = new DateTime(2019, 8, 1, 4, 0, 0),
                DefaultUniverseId = 0,
                DefaultWaiverOrder = 0,
                Divisions = new List<Division>
                {
                    new Division()
                    {
                        DivisionId = 0,
                        DivisionName = "Division 1",
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
                InviteKey = "4ec12",
                IsViewable = true,
                LeagueFormatTypeId = 0,
                LeagueMembers = new List<LeagueMember>
                {
                    new LeagueMember()
                    {
                        IsLeagueCreator = true,
                        LastName = "Meziere",
                        InviteId = 0,
                        IsLeagueManager = false,
                        UserProfileId = 26483835,
                        UserName = "Buttscreams",
                        FirstName = "Carl"
                    }
                },
                LeagueStatusTypeId = 1,
                LeagueSubTypeId = 0,
                LeagueTypeId = 0,
                LineupLocktimeType = 0,
                MatchupAcquisitionLimits = new List<MatchupAcquisitionLimit>
                {
                    new MatchupAcquisitionLimit()
                    {
                        Limit = -1,
                        MatchupPeriodId = 1
                    }
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
                    new PositionItem()
                    {
                        Max = 0,
                        PositionId = 0
                    }
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
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 0.04,
                        StatId = 3
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 4.0,
                        StatId = 4
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 2.0,
                        StatId = 19
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = -2.0,
                        StatId = 20
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 0.1,
                        StatId = 24
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 6.0,
                        StatId = 25
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 2.0,
                        StatId = 26
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 0.1,
                        StatId = 42
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 6.0,
                        StatId = 43
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 2.0,
                        StatId = 44
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 6.0,
                        StatId = 63
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = -1.0,
                        StatId = 68
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = -1.0,
                        StatId = 72
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 4.0,
                        StatId = 74
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 3.0,
                        StatId = 77
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = -1.0,
                        StatId = 79
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 2.0,
                        StatId = 80
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = -2.0,
                        StatId = 82
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 1.0,
                        StatId = 86
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = -2.0,
                        StatId = 88
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 89
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 90
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 91
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 92
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 4.0,
                        StatId = 93
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 2.0,
                        StatId = 95
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 1.0,
                        StatId = 96
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 2.0,
                        StatId = 97
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 2.0,
                        StatId = 98
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 0.5,
                        StatId = 99
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 6.0,
                        StatId = 101
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 4,
                        StatId = 101
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = false,
                        Points = 6.0,
                        StatId = 102
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 4.0,
                        StatId = 102
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 4.0,
                        StatId = 103
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 4.0,
                        StatId = 104
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 1.0,
                        StatId = 106
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 0.35,
                        StatId = 112
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = -0.25,
                        StatId = 120
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 121
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 122
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 123
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 124
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 12.5,
                        StatId = 125
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = -0.02,
                        StatId = 127
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 2.0,
                        StatId = 206
                    },
                    new ScoringItem()
                    {
                        IsReverseItem = false,
                        IsTeamScoringItem = true,
                        Points = 1.0,
                        StatId = 209
                    }
                },
                ScoringPeriodsByMatchupPeriod = new Dictionary<string, List<int>>
                {
                    {"1", new List<int> {1}},
                    {"2", new List<int> {2}},
                    {"3", new List<int> {3}},
                    {"4", new List<int> {4}},
                    {"5", new List<int> {5}},
                    {"6", new List<int> {6}},
                    {"7", new List<int> {7}},
                    {"8", new List<int> {8}},
                    {"9", new List<int> {9}},
                    {"10", new List<int> {10}},
                    {"11", new List<int> {11}},
                    {"12", new List<int> {12}},
                    {"13", new List<int> {13}},
                    {"14", new List<int> {14}},
                    {"15", new List<int> {15}},
                    {"16", new List<int> {16}}
                },
                ScoringTypeId = 1,
                Season = 2018,
                SeasonAcquisitionLimit = -1,
                Size = 12m,
                SlotCategoryItems = new List<SlotCategoryItem>
                {
                    new SlotCategoryItem()
                    {
                        Num = 1,
                        SlotCategoryId = 0
                    }
                },
                Teams = new Dictionary<string, TeamDetails>
                {
                    {"1", new TeamDetails()
                    {
                        DivisionStanding = 2,
                        Percentile = 0,
                        OverallStanding = 2,
                        TeamAbbrev = "TRSH",
                        WaiverRank = 12,
                        TeamNickname = "of the Law",
                        DraftPicks = new List<DraftPick>()
                        {
                            new DraftPick()
                            {
                                DraftPickId = 101,
                                OwningTeams = new List<int>()
                                {
                                    1
                                },
                                RoundSelection = 11,
                                IsTradeLocked = false,
                                IsKeeper = false,
                                Round = 1,
                                OverallSelection = 11,
                                PlayerPotentialTransactions = new PlayerPotentialTransactions()
                                {
                                    Trade = "7_101_1_-1_13_-1"
                                }
                            }
                        },
                        LogoUrl = "https://i.imgur.com/P0tCXCd.gif",
                        LogoType = "custom",
                        TeamId = 1,
                        TeamTransactions = new TeamTransactions()
                        {
                            MoveToIr = 0,
                            MatchupAcquisitionTotals = new List<MatchupAcquisitionTotal>()
                            {
                                new MatchupAcquisitionTotal()
                                {
                                    Total = 0,
                                    MatchupPeriodId = 1
                                }
                            },
                            MiscTeamCharges = 0,
                            AcquisitionBudgetSpent = 0,
                            AmountPaid = 0,
                            Drops = 0,
                            MoveToActive = 0,
                            Trades = 0,
                            OverallAcquisitionTotal = 0,
                            OffseasonAcquisitionTotal = 0
                        },
                        ScheduleItems = new List<ScheduleItem>()
                        {
                            new ScheduleItem()
                            {
                                Matchups = new List<Matchup>()
                                {
                                    new Matchup()
                                    {
                                        MatchupTypeId = 0,
                                        AwayTeamScores = new List<int>()
                                        {
                                            0
                                        },
                                        AwayTeam = new Team()
                                        {
                                            WaiverRank = 11,
                                            Division = new Division()
                                            {
                                                DivisionId = 0,
                                                DivisionName = "Division 1",
                                                Size = 12
                                            },
                                            TeamAbbrev = "BOOB",
                                            TeamNickname = "2",
                                            LogoUrl = "http://cdn.sportige.com/wp-content/uploads/2016/09/You-like-Dak-e1474290992590.jpg",
                                            TeamLocation = "Dezpacito",
                                            TeamId = 3,
                                            LogoType = "customValid"
                                        },
                                        AwayTeamAdjustment = 0,
                                        AwayTeamId = 3,
                                        IsBye = false,
                                        HomeTeamId = 1,
                                        HomeTeamAdjustment = 0,
                                        HomeTeamScores = new List<int>()
                                        {
                                            0
                                        },
                                        HomeTeamBonus = 0,
                                        Outcome = 0,
                                        HomeTeam = new Team()
                                        {
                                            WaiverRank = 12,
                                            Division = new Division()
                                            {
                                                DivisionId = 0,
                                                DivisionName = "Division 1",
                                                Size = 12
                                            },
                                            TeamAbbrev = "TRSH",
                                            TeamNickname = "of the Law",
                                            LogoUrl = "https://i.imgur.com/P0tCXCd.gif",
                                            TeamLocation = "The Schlong Arm",
                                            TeamId = 1,
                                            LogoType = "custom"
                                        }
                                    }
                                },
                                MatchupPeriodId = 1
                            }
                        },
                        Record = new Record()
                        {
                            AwayPercentage = 0,
                            DivisionStanding = 2,
                            OverallStanding = 2,
                            DivisionLosses = 0,
                            HomePercentage = 0,
                            AwayTies = 0,
                            DivisionWins = 0,
                            StreakType = 0,
                            OverallTies = 0,
                            HomeTies = 0,
                            HomeWins = 0,
                            DivisionTies = 0,
                            OverallPercentage = 0,
                            OverallWins = 0,
                            OverallLosses = 0,
                            StreakLength = 0,
                            PointsAgainst = 0,
                            AwayWins = 0,
                            DivisionPercentage = 0,
                            HomeLosses = 0,
                            PointsFor = 0,
                            AwayLosses = 0
                        },
                        Rank = 0,
                        Division = new Division()
                        {
                            DivisionId = 0,
                            DivisionName = "Division 1",
                            Size = 12
                        },
                        TeamLocation = "The Schlong Arm",
                        Owners = new List<Owner>()
                        {
                            new Owner()
                            {
                                LastName = "Meziere",
                                PrimaryOwner = true,
                                LeagueManager = true,
                                Joined = true,
                                InviteId = 0,
                                OwnerId = 26483835,
                                UserProfileId = 26483835,
                                PhotoUrl = "http://f.espncdn.com/avatars/Buttscreams/medium",
                                FirstName = "Carl"
                            }
                        }
                    }}
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
                    new WaiverDetail()
                    {
                        ProcessedCount = 2,
                        DateProcessed = 20140810
                    }
                },
                WaiverHours = 24,
                WaiverOrderSystemTypeId = 0,
                WaiverProcessDays = 123,
                WaiverProcessHour = 8
            },
            Metadata = new LeagueMetadata()
            {
                DateModifiedLeague = new DateTime(2018, 6, 20, 8, 30, 32, 963),
                DateModifiedUser = new DateTime(2018, 5, 24, 1, 54, 2, 457),
                Defaults = new Defaults(),
                LeagueId = 526113,
                SeasonId = 2018,
                ServerDate = new DateTime(2018, 6, 21, 1, 47, 3, 515),
                Status = "undrafted"
            }
        };
    }
}
