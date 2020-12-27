namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ExBestOffersOverrides
    /// </summary>
    public class ExBestOffersOverrides
    {
        public int BestPricesDepth { get; set; }

        public RollupModel RollupModel { get; set; }

        public int RollupLimit { get; set; }

        public double RollupLiabilityThreshold { get; set; }

        public int RollupLiabilityFactor { get; set; }
    }
}
