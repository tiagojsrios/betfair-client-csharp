namespace BetfairClient.Models.Session
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Interactive+Login+-+API+Endpoint
    /// </summary>
    public class SessionRequest
    {
        /// <summary>
        ///     Username
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        ///     Password
        /// </summary>
        public string Password { get; set; } = null!;
    }
}
