namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-ExecutionReportErrorCode
    /// </summary>
    public enum ExecutionReportErrorCode
    {
        ERROR_IN_MATCHER,
        PROCESSED_WITH_ERRORS,
        BET_ACTION_ERROR,
        INVALID_ACCOUNT_STATE,
        INVALID_WALLET_STATUS,
        INSUFFICIENT_FUNDS,
        LOSS_LIMIT_EXCEEDED,
        MARKET_SUSPENDED,
        MARKET_NOT_OPEN_FOR_BETTING,
        DUPLICATE_TRANSACTION,
        INVALID_ORDER,
        INVALID_MARKET_ID,
        PERMISSION_DENIED,
        DUPLICATE_BETIDS,
        NO_ACTION_REQUIRED,
        SERVICE_UNAVAILABLE,
        REJECTED_BY_REGULATOR,
        NO_CHASING,
        REGULATOR_IS_NOT_AVAILABLE,
        TOO_MANY_INSTRUCTIONS,
        INVALID_MARKET_VERSION,
        INVALID_PROFIT_RATIO
    }
}
