namespace BetfairClient.Models.Betting.Enums
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-RunnerStatus
    /// </summary>
    public enum RunnerStatus
    {
        ACTIVE,
        WINNER,
        LOSER,
        PLACED,
        REMOVED_VACANT,
        REMOVED,
        HIDDEN
    }
}
