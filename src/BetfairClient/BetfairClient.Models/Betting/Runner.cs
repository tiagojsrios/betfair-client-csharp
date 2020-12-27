using System;
using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-Runner
    /// </summary>
    public class Runner
    {
        public long SelectionId { get; set; }

        public double Handicap { get; set; }

        public RunnerStatus Status { get; set; }

        public double adjustmentFactor { get; set; }

        public double LastPriceTraded { get; set; }

        public double TotalMatched { get; set; }
        
        public DateTime RemovalDate { get; set; }

        public StartingPrices Sp { get; set; }

        public ExchangePrices Ex { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public IEnumerable<Match> Matches { get; set; }

        public Dictionary<string, IEnumerable<Match>> MatchesByStrategy { get; set; }
    }
}
