using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-RunnerCatalog
    /// </summary>
    public class RunnerCatalog
    {
        public long SelectionId { get; set; }

        public string RunnnerName { get; set; }

        public double Handicap { get; set; }

        public int SortPriority { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}