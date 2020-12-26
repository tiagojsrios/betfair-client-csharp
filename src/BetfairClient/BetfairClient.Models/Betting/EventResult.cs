namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-EventResult
    /// </summary>
    public class EventResult
    {
        public Event Event { get; set; }

        public int MarketCount { get; set; }
    }
}
