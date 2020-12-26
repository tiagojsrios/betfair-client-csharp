using System;

namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Represents date range to retrieve account statement
    /// </summary>
    public class AccountStatementItemDataRangeRequest
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
