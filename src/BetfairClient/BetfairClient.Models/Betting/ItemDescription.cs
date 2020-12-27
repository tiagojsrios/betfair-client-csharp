using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ItemDescription
    /// </summary>
    public class ItemDescription
    {
        public string EventTypeDesc { get; set; }

        public string EventDesc { get; set; }

        public string MarketDesc { get; set; }

        public string MarketType { get; set; }

        public DateTime MarketStartTime { get; set; }

        public string RunnerDesc { get; set; }

        public int NumberOfWinners { get; set; }

        public double EachWayDivisor { get; set; }
    }
}
