using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-#KeyLineDescription
    /// </summary>
    public class KeyLineDescription
    {
        public IEnumerable<KeyLineSelection> KeyLine { get; set; }
    }
}
