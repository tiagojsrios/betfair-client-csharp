using BetfairClient.Models.Betting.Enums;
using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-PlaceInstructionReport
    /// </summary>
    public class PlaceInstructionReport
    {
        public InstructionReportStatus Status { get; set; }

        public InstructionReportErrorCode? ErrorCode { get; set; }

        public OrderStatus? OrderStatus { get; set; }

        public PlaceInstruction Instruction { get; set; } = null!;

        public string? BetId { get; set; }

        public DateTime? PlacedDate { get; set; }

        public double? AveragePriceMatched { get; set; }

        public double? SizeMatched { get; set; }
    }
}
