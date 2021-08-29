using BetfairClient.Models.Betting.Enums;
using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CurrentOrderSummary
    /// </summary>
    public class CurrentOrderSummary
    {
        public string BetId { get; set; } = null!;

        public string MarketId { get; set; } = null!;

        public long SelectionId { get; set; }

        public double Handicap { get; set; }

        public PriceSize PriceSize { get; set; } = null!;

        public double BspLiability { get; set; }

        public Side Side { get; set; }

        public OrderStatus Status { get; set; }

        public PersistenceType PersistenceType { get; set; }

        public OrderType OrderType { get; set; }

        public DateTime PlacedDate { get; set; }

        public DateTime MatchedDate { get; set; }

        public double? AveragePriceMatched { get; set; }

        public double? SizeMatched { get; set; }

        public double? SizeRemaining { get; set; }

        public double? SizeLapsed { get; set; }

        public double? SizeCancelled { get; set; }

        public double? SizeVoided { get; set; }

        public string? RegulatorAuthCode { get; set; }

        public string? RegulatorCode { get; set; }

        public string? CustomerOrderRef { get; set; }

        public string? CustomerStrategyRef { get; set; }

        public CurrentItemDescription? CurrentItemDescription { get; set; }
    }
}
