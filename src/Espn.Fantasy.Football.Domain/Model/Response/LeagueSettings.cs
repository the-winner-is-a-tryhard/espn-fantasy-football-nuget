using System;
using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class LeagueSettings
    {
        public decimal PlayoffHomeTeamBonus { get; set; }
        public int DraftStatusTypeId { get; set; }
        public int PlayerAcquisitionType { get; set; }
        public int DraftOrderTypeId { get; set; }
        public IList<Division> Divisions { get; set; }
        public int LeagueStatusTypeId { get; set; }
        public decimal HomeTeamBonus { get; set; }
        public IList<ScoringItem> ScoringItems { get; set; }
        public int RosterMoveLimit { get; set; }
        public DateTime DateDraftCompleted { get; set; }
        public int FinalRegularSeasonMatchupPeriodId { get; set; }
        public IList<int> PlayoffSeedings { get; set; }
        public int WaiverProcessHour { get; set; }
        public DateTime DateFutureKeeperLock { get; set; }
        public Dictionary<string, IList<int>> ScoringPeriodsByMatchupPeriod { get; set; }
        public IList<WaiverDetail> WaiverDetails { get; set; }
        public int PlayoffTieRuleRawStatId { get; set; }
        public int MatchupPeriodTypeId { get; set; }
        public int RestrictionTypeId { get; set; }
        public bool UsingUndroppableList { get; set; }
        public bool DraftPickTradingEnabled { get; set; }
        public int WaiverProcessDays { get; set; }
        public DateTime TradeDeadline { get; set; }
        public int WaiverHours { get; set; }
        public int PlayoffMatchupLength { get; set; }
        public int VetoVotesRequired { get; set; }
        public decimal Size { get; set; }
        public int ScoringDecimalPlaces { get; set; }
        public Dictionary<string, TeamDetails> Teams { get; set; }
        public int MinimumBidAmount { get; set; }
        public int WaiverOrderSystemTypeId { get; set; }
        public int PlayoffSeedingTieRule { get; set; }
        public int TradeLimit { get; set; }
        public bool AllowsTrades { get; set; }
        public int Season { get; set; }
        public int PlayoffTeamCount { get; set; }
        public int TimePerDraftSelection { get; set; }
        public int LineupLocktimeType { get; set; }
        public string InviteKey { get; set; }
        public int FinalMatchupPeriodId { get; set; }
        public int RegularSeasonMatchupPeriodCount { get; set; }
        public int AccessTypeId { get; set; }
        public int Id { get; set; }
        public int ScoringTypeId { get; set; }
        public int FutureKeeperCount { get; set; }
        public int TieRule { get; set; }
        public int DefaultWaiverOrder { get; set; }
        public int DefaultUniverseId { get; set; }
        public int PlayerAcquisitionBudget { get; set; }
        public string Name { get; set; }
        public int DraftTypeId { get; set; }
        public int DraftAuctionBudget { get; set; }
        public IList<PositionItem> PositionItems { get; set; }
        public int TieRuleRawStatId { get; set; }
        public int PremiumTypeId { get; set; }
        public int LeagueSubTypeId { get; set; }
        public int LeagueFormatTypeId { get; set; }
        public int TradeRevisionHours { get; set; }
        public int PlayoffSeedingTieRuleRawStatId { get; set; }
        public IList<int> DraftOrder { get; set; }
        public bool IsViewable { get; set; }
        public bool UsesPlayerAcquisitionBudget { get; set; }
        public IList<LeagueMember> LeagueMembers { get; set; }
        public int FirstScoringPeriodId { get; set; }
        public int RegularSeasonMatchupLength { get; set; }
        public int PlayoffTieRule { get; set; }
        public bool AllowOutOfUniverseStatsAndTrades { get; set; }
        public int FirstMatchupPeriodId { get; set; }
        public int LeagueTypeId { get; set; }
        public int FinalScoringPeriodId { get; set; }
        public int SeasonAcquisitionLimit { get; set; }
        public int RosterLocktimeType { get; set; }
        public IList<SlotCategoryItem> SlotCategoryItems { get; set; }
        public Finance Finance { get; set; }
        public IList<MatchupAcquisitionLimit> MatchupAcquisitionLimits { get; set; }
        public int CurrentKeeperCount { get; set; }
    }
}
