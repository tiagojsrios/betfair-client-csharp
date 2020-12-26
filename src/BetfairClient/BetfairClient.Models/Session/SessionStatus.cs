namespace BetfairClient.Models.Session
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Interactive+Login+-+API+Endpoint
    /// </summary>
    public enum SessionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,

        /// <summary>
        /// 
        /// </summary>
        LimitedAccess,

        /// <summary>
        /// 
        /// </summary>
        LoginRestricted,
        
        /// <summary>
        /// 
        /// </summary>
        Fail
    }
}
