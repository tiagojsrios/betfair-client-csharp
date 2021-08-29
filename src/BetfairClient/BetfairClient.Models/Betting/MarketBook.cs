using BetfairClient.Models.Betting.Enums;
using System;
using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-MarketBook
    /// </summary>
    public class MarketBook
    {
        public string MarketId { get; set; } = null!;

        public bool IsMarketDataDelayed { get; set; }

        public MarketStatus? Status { get; set; }

        public int? BetDelay { get; set; }

        public bool? BspReconciled { get; set; }

        public bool? Complete { get; set; }

        public bool? Inplay { get; set; }

        public int? NumberOfWinners { get; set; }

        public int? NumberOfRunners { get; set; }

        public int? NumberOfActiveRunners { get; set; }

        public DateTime? LastMatchTime { get; set; }

        public double? TotalMatched { get; set; }

        public double? TotalAvailable { get; set; }

        public bool? CrossMatching { get; set; }

        public bool? RunnersVoidable { get; set; }

        public long? Version { get; set; }

        public List<Runner>? Runners { get; set; }

        public KeyLineDescription? KeyLineDescription { get; set; }
    }
}
