using System;
using System.Collections.Generic;
using Espn.Fantasy.Football.Domain.Model.Response;

namespace Espn.Fantasy.Football.Tests.Assets.ScoreboardSerialization
{
    public static class CSharpScoreboardTestCaseConstants
    {
        public static LeagueScoreboard SCOREBOARD_OUTPUT_OBJECT = new LeagueScoreboard()
        {
            Scoreboard = new Scoreboard()
            {
                ProGamesInProgress = false,
                ScoringPeriodId = 18,
                Matchups = new List<ScoreboardMatchup>()
                {
                    new ScoreboardMatchup()
                    {
                        Teams = new List<ScoreboardTeam>()
                        {
                            new ScoreboardTeam()
                            {
                                Home = true,
                                Score = 53.7m,
                                Team = new TeamRecord()
                                {
                                    Record = new Record()
                                    {
                                        AwayPercentage = 0,
                                        DivisionStanding = 4,
                                        OverallStanding = 4,
                                        DivisionLosses = 5,
                                        HomePercentage = 0,
                                        AwayTies = 0,
                                        DivisionWins = 8,
                                        StreakType = 1,
                                        OverallTies = 0,
                                        HomeTies = 0,
                                        HomeWins = 6,
                                        DivisionTies = 0,
                                        OverallPercentage = 0.61538m,
                                        OverallWins = 8,
                                        OverallLosses = 5,
                                        StreakLength = 1,
                                        PointsAgainst = 1087.25m,
                                        AwayWins = 2,
                                        DivisionPercentage = 0.61538m,
                                        HomeLosses = 2,
                                        PointsFor = 1180.35m,
                                        AwayLosses = 3
                                    },
                                    WaiverRank = 12,
                                    Division = new Division()
                                    {
                                        DivisionName = "Division 1",
                                        DivisionId = 0,
                                        Size = 12
                                    },
                                    TeamAbbrev = "TRSH",
                                    TeamNickname = "of the Law",
                                    LogoUrl = "https://i.imgur.com/P0tCXCd.gif",
                                    TeamLocation = "The Schlong Arm",
                                    TeamId = 1,
                                    LogoType = "custom"
                                },
                                TeamId = 1,
                                PlayerIds = new List<int>()
                                {
                                    17797,
                                    17834,
                                    16731,
                                    12563,
                                    17832,
                                    18306,
                                    60033,
                                    16504,
                                    18314,
                                    15168,
                                    14877,
                                    16724,
                                    18462,
                                    17175,
                                    18233
                                }
                            }
                        },
                        Winner = "away",
                        Bye = false
                    },
                },
                MatchupPeriodId = 16
            },
            Metadata = new LeagueMetadata()
            {
                LeagueId = 526113,
                Defaults = new Defaults(),
                Status = "offseason",
                DateModifiedLeague = new DateTime(2018, 4, 13, 8, 43, 16, 227),
                SeasonId = 2017,
                ServerDate = new DateTime(2018, 7, 5, 19, 19, 48, 879)
            }
        };
    }
}