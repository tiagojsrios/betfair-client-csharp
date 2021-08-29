using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-StartingPrices
    /// </summary>
    public class StartingPrices
    {
        public double NearPrice { get; set; }

        public double FarPrice { get; set; }

        public IEnumerable<PriceSize> BackStakeTaken { get; set; }

        public IEnumerable<PriceSize> LayLiabilityTaken { get; set; }

        public double ActualSP { get; set; }
    }
}