using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-TimeRange
    /// </summary>
    public class TimeRange
    {
        /// <summary>
        ///     Where account statements should start
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        ///     Where account statements should finish
        /// </summary>
        public DateTime To { get; set; }
    }
}
