using BetfairClient.Models.Betting.Enums;
using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CancelInstructionReport
    /// </summary>
    public class CancelInstructionReport
    {
        public InstructionReportStatus Status { get; set; }

        public InstructionReportErrorCode? ErrorCode { get; set; }

        public CancelInstruction? Instruction { get; set; }

        public double SizeCancelled { get; set; }

        public DateTime? CancelledDate { get; set; }
    }
}
