using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-Match
    /// </summary>
    public class Match
    {
        public string BetId { get; set; }

        public string MatchId { get; set; }

        public Side Side { get; set; }

        public double Price { get; set; }

        public double Size { get; set; }

        public DateTime MatchDate { get; set; }
    }
}
