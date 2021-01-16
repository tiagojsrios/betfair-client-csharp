using System;

namespace BetfairClient.Models.Account
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+TypeDefinitions#AccountsTypeDefinitions-StatementLegacyData
    /// </summary>
    public class AccountStatementLegacyData
    {
        public double AvgPrice { get; set; }

        public decimal BetSize { get; set; }

        public string BetType { get; set; }

        public string BetCategoryType { get; set; }

        public string CommissionRate { get; set; }

        public long EventId { get; set; }

        public long EventIdType { get; set; }

        public string FullMarketName { get; set; }

        public double GrossBetAmount { get; set; }

        public string MarketName { get; set; }

        public AccountStatementLegacyDataMarketType MarketType { get; set; }

        public DateTime PlacedDate { get; set; }

        public long SelectionId { get; set; }

        public string SelectionName { get; set; }

        public DateTime StartDate { get; set; }

        public string TransactionType { get; set; }

        public long TransactionId { get; set; }

        public string WinLose { get; set; }

        public double? DeadHeatPriceDivisor { get; set; }

        public decimal AvgPriceRaw { get; set; }
    }
}
