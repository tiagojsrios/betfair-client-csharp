namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-PriceSize
    /// </summary>
    public class PriceSize
    {
        public double Price { get; set; }

        public double Size { get; set; }
    }
}