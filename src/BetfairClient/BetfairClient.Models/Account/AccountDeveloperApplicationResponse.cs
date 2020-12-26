using System.Collections.Generic;

namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-DeveloperApp
    /// </summary>
    public class AccountDeveloperApplicationResponse
    {
        public string AppName { get; set; }

        public long AppId { get; set; }

        public IEnumerable<AccountDeveloperApplicationKeys> AppVersions { get; set; }
    }
}
