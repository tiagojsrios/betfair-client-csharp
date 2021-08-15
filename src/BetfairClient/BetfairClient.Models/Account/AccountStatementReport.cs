using System.Collections.Generic;

namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-AccountStatementReport
    /// </summary>
    public class AccountStatementReport
    {
        public IEnumerable<StatementItem> AccountStatement { get; set; }

        public bool MoreAvailable { get; set; }
    }
}
