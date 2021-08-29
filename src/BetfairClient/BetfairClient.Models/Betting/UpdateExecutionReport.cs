using BetfairClient.Models.Betting.Enums;
using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-UpdateExecutionReport
    /// </summary>
    public class UpdateExecutionReport
    {
        public string? CustomerRef { get; set; }

        public ExecutionReportStatus Status { get; set; }

        public ExecutionReportErrorCode? ErrorCode { get; set; }

        public string? MarketId { get; set; }

        public IEnumerable<UpdateInstructionReport>? InstructionReports { get; set; }
    }
}
