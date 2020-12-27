namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-ExecutionReportErrorCode
    /// </summary>
    public enum ExecutionReportErrorCode
    {
        ErrorInMatcher,
        ProcessedWithErrors,
        BetActionError,
        InvalidAccountState,
        InvalidWalletStatus,
        InsufficientFunds,
        LossLimitExceeded,
        MarketSuspended,
        MarketNotOpenForBetting,
        DuplicateTransaction,
        InvalidOrder,
        InvalidMarketId,
        PermissionDenied,
        DuplicateBetids,
        NoActionRequired,
        ServiceUnavailable,
        RejectedByRegulator,
        NoChasing,
        RegulatorIsNotAvailable,
        TooManyInstructions,
        InvalidMarketVersion,
        InvalidProfitRatio
    }
}
