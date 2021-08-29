using BetfairClient.Models.Betting.Enums;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-PlaceInstruction
    /// </summary>
    public class PlaceInstruction
    {
        public OrderType OrderType { get; set; }

        public long SelectionId { get; set; }

        public double? Handicap { get; set; }

        public Side Side { get; set; }

        public LimitOrder? LimitOrder { get; set; }

        public LimitOnCloseOrder? LimitOnCloseOrder { get; set; }

        public MarketOnCloseOrder? MarketOnCloseOrder { get; set; }

        public string? CustomerOrderRef { get; set; }
    }
}
