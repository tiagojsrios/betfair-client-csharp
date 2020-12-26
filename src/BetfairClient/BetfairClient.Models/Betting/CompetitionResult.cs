namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CompetitionResult
    /// </summary>
    public class CompetitionResult
    {
        public Competition Competition { get; set; }

        public int MarketCount { get; set; }

        public string CompetitionRegion { get; set; }
    }
}