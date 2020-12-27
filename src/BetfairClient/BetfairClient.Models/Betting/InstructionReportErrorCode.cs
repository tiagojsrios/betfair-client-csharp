namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-InstructionReportErrorCode
    /// </summary>
    public enum InstructionReportErrorCode
    {
        InvalidBetSize,
        InvalidRunner,
        BetTakenOrLapsed,
        BetInProgress,
        RunnerRemoved,
        MarketNotOpenForBetting,
        LossLimitExceeded,
        MarketNotOpenForBspBetting,
        InvalidPriceEdit,
        InvalidOdds,
        InsufficientFunds,
        InvalidPersistenceType,
        ErrorInMatcher,
        InvalidBackLayCombination,
        ErrorInOrder,
        InvalidBidType,
        InvalidBetId,
        CancelledNotPlaced,
        RelatedActionFailed,
        NoActionRequired,
        TimeInForceConflict,
        UnexpectedPersistenceType,
        InvalidOrderType,
        UnexpectedMinFillSize,
        InvalidCustomerOrderRef,
        InvalidMinFillSize,
        BetLapsedPriceImprovementTooLarge
    }
}
