using System;

namespace BetfairClient.Models.Betting.Enums
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-OrderBy
    /// </summary>
    public enum OrderBy
    {
        [Obsolete("You should use BY_PLACE_TIME instead. Order by placed time, then bet id")]
        BY_BET,
        BY_MARKET,
        BY_MATCH_TIME,
        BY_PLACE_TIME,
        BY_SETTLED_TIME,
        BY_VOID_TIME
    }
}
