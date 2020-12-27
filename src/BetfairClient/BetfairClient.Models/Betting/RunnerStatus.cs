namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-RunnerStatus
    /// </summary>
    public enum RunnerStatus
    {
        Active,
        Winner,
        Loser,
        Placed,
        RemovedVacant,
        Removed,
        Hidden
    }
}
