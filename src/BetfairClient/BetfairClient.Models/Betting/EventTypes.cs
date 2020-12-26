namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-EventTypeResult
    /// </summary>
    public class EventTypes
    {
        public EventType EventType { get; set; }

        public int MarketCount { get; set; }
    }
}
