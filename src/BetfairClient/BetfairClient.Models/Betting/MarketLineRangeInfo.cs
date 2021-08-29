namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-MarketLineRangeInfo
    /// </summary>
    public class MarketLineRangeInfo
    {
        public double MaxUnitValue { get; set; }

        public double MinUnitValue { get; set; }

        public double Interval { get; set; }

        public string MarketUnit { get; set; } = null!;
    }
}