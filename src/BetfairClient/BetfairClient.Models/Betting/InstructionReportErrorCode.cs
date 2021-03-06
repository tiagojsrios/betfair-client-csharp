﻿namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-InstructionReportErrorCode
    /// </summary>
    public enum InstructionReportErrorCode
    {
        INVALID_BET_SIZE,
        INVALID_RUNNER,
        BET_TAKEN_OR_LAPSED,
        BET_IN_PROGRESS,
        RUNNER_REMOVED,
        MARKET_NOT_OPEN_FOR_BETTING,
        LOSS_LIMIT_EXCEEDED,
        MARKET_NOT_OPEN_FOR_BSP_BETTING,
        INVALID_PRICE_EDIT,
        INVALID_ODDS,
        INSUFFICIENT_FUNDS,
        INVALID_PERSISTENCE_TYPE,
        ERROR_IN_MATCHER,
        INVALID_BACK_LAY_COMBINATION,
        ERROR_IN_ORDER,
        INVALID_BID_TYPE,
        INVALID_BET_ID,
        CANCELLED_NOT_PLACED,
        RELATED_ACTION_FAILED,
        NO_ACTION_REQUIRED,
        TIME_IN_FORCE_CONFLICT,
        UNEXPECTED_PERSISTENCE_TYPE,
        INVALID_ORDER_TYPE,
        UNEXPECTED_MIN_FILL_SIZE,
        INVALID_CUSTOMER_ORDER_REF,
        INVALID_MIN_FILL_SIZE,
        BET_LAPSED_PRICE_IMPROVEMENT_TOO_LARGE
    }
}
