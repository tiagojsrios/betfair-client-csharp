namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-LimitOrder
    /// </summary>
    public class LimitOrder
    {
        public double Size { get; set; }

        public double Price { get; set; }

        public PersistenceType PersistenceType { get; set; }

        public TimeInForce TimeInForce { get; set; }

        public double MinFillSize { get; set; }

        public BetTargetType BetTargetType { get; set; }

        public double BetTargetSize { get; set; }
    }
}
