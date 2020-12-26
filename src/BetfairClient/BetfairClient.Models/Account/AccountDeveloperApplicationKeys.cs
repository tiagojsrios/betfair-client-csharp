namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-DeveloperAppVersion
    /// </summary>
    public class AccountDeveloperApplicationKeys
    {
        public string Owner { get; set; }

        public long VersionId { get; set; }

        public string Version { get; set; }

        public string ApplicationKey { get; set; }

        public bool DelayData { get; set; }

        public bool SubscriptionRequired { get; set; }

        public bool OwnerManaged { get; set; }

        public bool Active { get; set; }

        public string VendorId { get; set; }

        public string VendorSecret { get; set; }
    }
}
