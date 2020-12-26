using System;
using System.Collections.Generic;

namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair Documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-StatementItem
    /// </summary>
    public class AccountStatementItem
    {
        public string RefId { get; set; }

        public DateTime ItemDate { get; set; }

        public decimal Amount { get; set; }

        public double Balance { get; set; }

        public string ItemClass { get; set; }

        public Dictionary<string, string> ItemClassData { get; set; }

        public AccountStatementLegacyData LegacyData { get; set; }
    }
}
