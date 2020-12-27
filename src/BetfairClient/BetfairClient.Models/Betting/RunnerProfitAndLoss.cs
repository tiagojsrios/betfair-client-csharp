namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-RunnerProfitAndLoss
    /// </summary>
    public class RunnerProfitAndLoss
    {
        public long SelectionId { get; set; }

        public double IfWin { get; set; }

        public double IfLose { get; set; }

        public double IfPlace { get; set; }
    }
}
