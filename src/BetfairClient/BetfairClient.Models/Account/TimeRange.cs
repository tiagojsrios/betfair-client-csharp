using System;

namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Represents date range to retrieve account statement
    /// </summary>
    /// <remarks>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-TimeRange
    /// </remarks>
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
