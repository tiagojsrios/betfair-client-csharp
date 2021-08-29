namespace BetfairClient.Models.Betting.Enums
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-OrderStatus
    /// </summary>
    public enum OrderStatus
    {
        PENDING,
        EXECUTION_COMPLETE,
        EXECUTABLE,
        EXPIRED
    }
}
