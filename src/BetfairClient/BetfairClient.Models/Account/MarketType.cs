namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-legacydata
    /// </summary>
    public enum MarketType
    {
        /// <summary>
        ///     Not Applicable
        /// </summary>
        NOT_APPLICABLE,

        /// <summary>
        ///     Asian Handicap
        /// </summary>
        A,

        /// <summary>
        ///     Line Market
        /// </summary>
        L,

        /// <summary>
        ///     Odds Market
        /// </summary>
        O,

        /// <summary>
        ///     Range Market
        /// </summary>
        R
    }
}
