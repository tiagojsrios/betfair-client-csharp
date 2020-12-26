namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-AccountDetailsResponse
    /// </summary>
    public class AccountDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LocaleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double DiscountRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PointsBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CountryCode { get; set; }
    }
}
