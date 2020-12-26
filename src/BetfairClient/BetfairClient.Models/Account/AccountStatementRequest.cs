namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Model request to retrieve account statement
    /// </summary>
    public class AccountStatementRequest
    {
        public static int MaximumRecordsPerPage = 100;

        /// <summary>
        ///     Locale
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        ///     Number of the page record it should be retrieved from
        /// </summary>
        public int FromRecord { get; set; } = 0;

        /// <summary>
        ///     Number of records to be retrieved. <see cref="MaximumRecordsPerPage"/>
        /// </summary>
        public int RecordCount { get; set; } = MaximumRecordsPerPage;

        /// <summary>
        ///     Include Item
        /// </summary>
        public string IncludeItem { get; set; }

        /// <summary>
        ///     Wallet (e.g.: UK, AUS)
        /// </summary>
        public string Wallet { get; set; }

        /// <summary>
        ///     Range of dates where
        /// </summary>
        public AccountStatementItemDataRangeRequest ItemDateRange { get; set; }
    }
}
