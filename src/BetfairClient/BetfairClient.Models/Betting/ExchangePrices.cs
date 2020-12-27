using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ExchangePrices
    /// </summary>
    public class ExchangePrices
    {
        public IEnumerable<PriceSize> AvailableToBack { get; set; }

        public IEnumerable<PriceSize> AvailableToLay { get; set; }

        public IEnumerable<PriceSize> TradedVolume { get; set; }
    }
}
