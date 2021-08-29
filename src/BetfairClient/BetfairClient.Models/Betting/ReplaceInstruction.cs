namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ReplaceInstruction
    /// </summary>
    public class ReplaceInstruction
    {
        public string BetId { get; set; } = null!;

        public double NewPrice { get; set; }
    }
}
