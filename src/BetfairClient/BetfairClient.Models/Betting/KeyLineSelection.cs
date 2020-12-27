namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-KeyLineSelection
    /// </summary>
    public class KeyLineSelection
    {
        public long SelectionId { get; set; }

        public double Handicap { get; set; }
    }
}
