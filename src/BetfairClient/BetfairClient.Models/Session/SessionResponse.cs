namespace BetfairClient.Models.Session
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Interactive+Login+-+API+Endpoint
    /// </summary>
    public class SessionResponse
    {
        /// <summary>
        ///     Session Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        ///     Product
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        ///     Session Status
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        ///     Error message
        /// </summary>
        public string Error { get; set; }
    }
}
