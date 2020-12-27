namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-UpdateInstructionReport
    /// </summary>
    public class UpdateInstructionReport
    {
        public InstructionReportStatus Status { get; set; }

        public InstructionReportErrorCode ErrorCode { get; set; }

        public UpdateInstruction Instruction { get; set; }
    }
}
