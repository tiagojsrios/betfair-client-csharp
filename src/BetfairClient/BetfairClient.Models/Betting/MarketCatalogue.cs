using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-MarketCatalogue
    /// </summary>
    public class MarketCatalogue
    {
        public string TextQuery { get; set; }

        public IEnumerable<string> ExchangeIds { get; set; }

        public IEnumerable<string> EventTypeIds { get; set; }

        public IEnumerable<string> EventIds { get; set; }

        public IEnumerable<string> CompetitionIds { get; set; }

        public IEnumerable<string> MarketIds { get; set; }

        public IEnumerable<string> Venues { get; set; }

        public bool BspOnly { get; set; }

        public bool TurnInPlayEnabled { get; set; }

        public bool InPlayOnly { get; set; }

        public IEnumerable<MarketBettingType> MarketBettingTypes { get; set; }

        public IEnumerable<string> MarketCountries { get; set; }

        public IEnumerable<string> MarketTypeCodes { get; set; }

        public TimeRange MarketStartTime { get; set; }

        public IEnumerable<OrderStatus> WithOrders { get; set; }

        public IEnumerable<string> RaceTypes { get; set; }
    }
}
