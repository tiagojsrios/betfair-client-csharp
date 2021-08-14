using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-MarketDescription
    /// </summary>
    public class MarketDescription
    {
        public bool PersistenceEnabled { get; set; }

        public bool BspMarket { get; set; }
        
        public DateTime MarketTime { get; set; }

        public DateTime SuspendTime { get; set; }

        public DateTime SettleTime { get; set; }

        public MarketBettingType BettingType { get; set; }

        public DateTime TurnInPlayEnabled { get; set; }
        
        public string MarketType { get; set; }

        public string Regulator { get; set; }

        public double MarketBaseRate { get; set; }
        
        public bool DiscountAllowed { get; set; }

        public string Wallet { get; set; }
        
        public string Rules { get; set; }

        public bool RulesHasDate { get; set; }

        public double EachWayDivisor { get; set; }

        public string Clarifications { get; set; }

        public MarketLineRangeInfo LineRangeInfo { get; set; }

        public string RaceType { get; set; }

        public PriceLadderDescription PriceLadderDescription { get; set; }
    }
}
