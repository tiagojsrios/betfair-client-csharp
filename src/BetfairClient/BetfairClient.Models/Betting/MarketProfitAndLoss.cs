using System.Collections.Generic;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-MarketProfitAndLoss
    /// </summary>
    public class MarketProfitAndLoss
    {
        public string MarketId { get; set; }

        public double CommissionApplied { get; set; }

        public IEnumerable<RunnerProfitAndLoss> ProfitAndLosses { get; set; }
    }
}
