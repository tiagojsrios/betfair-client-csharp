using System;
using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-MarketCatalogue
    /// </summary>
    public class MarketCatalogue
    {
        public string MarketId { get; set; }

        public string MarketName { get; set; }

        public DateTime MarketStartTime { get; set; }

        public MarketDescription Description { get; set; }

        public double TotalMatched { get; set; }

        public IEnumerable<RunnerCatalog> Runners { get; set; }

        public EventType EventType { get; set; }

        public Competition Competition { get; set; }

        public Event Event { get; set; }
    }
}
