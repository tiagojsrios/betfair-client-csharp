using BetfairClient.Models.Betting.Enums;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ReplaceInstructionReport
    /// </summary>
    public class ReplaceInstructionReport
    {
        public InstructionReportStatus Status { get; set; }

        public InstructionReportErrorCode? ErrorCode { get; set; }

        public CancelInstructionReport? CancelInstructionReport { get; set; }

        public PlaceInstructionReport? PlaceInstructionReport { get; set; }
    }
}
