namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CancelInstruction
    /// </summary>
    public class CancelInstruction
    {
        public string? BetId { get; set; }

        public double? SizeReduction { get; set; }
    }
}
