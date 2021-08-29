using System.Collections.Generic;
using System.Linq;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-ClearedOrderSummaryReport
    /// </summary>
    public class ClearedOrderSummaryReport
    {
        public IEnumerable<ClearedOrderSummary> ClearedOrders { get; set; } = Enumerable.Empty<ClearedOrderSummary>();

        public bool MoreAvailable { get; set; }
    }
}
