using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-PriceProjection
    /// </summary>
    public class PriceProjection
    {
        public IEnumerable<PriceData> PriceData { get; set; }

        public ExBestOffersOverrides ExBestOffersOverrides { get; set; }

        public bool Virtualise { get; set; }

        public bool RolloverStakes { get; set; }
    }
}
