namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-UpdateInstruction
    /// </summary>
    public class UpdateInstruction
    {
        public string BetId { get; set; }

        public PersistenceType NewPersistenceType { get; set; }
    }
}
