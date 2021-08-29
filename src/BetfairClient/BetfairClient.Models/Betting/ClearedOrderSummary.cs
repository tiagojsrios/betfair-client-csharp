using BetfairClient.Models.Betting.Enums;
using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ClearedOrderSummary
    /// </summary>
    public class ClearedOrderSummary
    {
        public string EventTypeId { get; set; }

        public string EventId { get; set; }

        public string MarketId { get; set; }

        public long SelectionId { get; set; }

        public double Handicap { get; set; }

        public string BetId { get; set; }

        public DateTime PlacedDate { get; set; }

        public PersistenceType PersistenceType { get; set; }

        public OrderType OrderType { get; set; }

        public Side Side { get; set; }

        public ItemDescription ItemDescription { get; set; }

        public string BetOutcome { get; set; }

        public double PriceRequested { get; set; }

        public DateTime SettleDate { get; set; }

        public DateTime LastMatchedDate { get; set; }

        public int BetCount { get; set; }

        public double Commission { get; set; }

        public double PriceMatched { get; set; }

        public bool PriceReduced { get; set; }

        public double SizeSettled { get; set; }

        public double Profit { get; set; }

        public double SizeCancelled { get; set; }

        public string CustomerOrderRef { get; set; }

        public string CustomerStrategyRef { get; set; }
    }
}
