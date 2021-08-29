using BetfairClient.Models.Betting.Enums;
using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-Order
    /// </summary>
    public class Order
    {
        public string BetId { get; set; } = null!;

        public OrderType OrderType { get; set; }

        public OrderStatus Status { get; set; }

        public PersistenceType PersistenceType { get; set; }

        public Side Side { get; set; }

        public double Price { get; set; }

        public double Size { get; set; }

        public double BspLiability { get; set; }

        public DateTime PlacedDate { get; set; }

        public double? AvgPriceMatched { get; set; }

        public double? SizeMatched { get; set; }

        public double? SizeRemaining { get; set; }

        public double? SizeLapsed { get; set; }

        public double? SizeCancelled { get; set; }

        public double? SizeVoided { get; set; }

        public string? CustomerOrderRef { get; set; }

        public string? CustomerStrategyRef { get; set; }
    }
}
