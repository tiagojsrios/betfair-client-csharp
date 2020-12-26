namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CountryCodeResult
    /// </summary>
    public class CountryCodeResult
    {
        public string CountryCode { get; set; }

        public int MarketCount { get; set; }
    }
}
