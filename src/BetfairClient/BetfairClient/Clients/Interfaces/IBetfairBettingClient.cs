using BetfairClient.Models.Betting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    /// <summary>
    ///     Exposes available methods to work with Betfair Betting API
    /// </summary>
    /// <remarks>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+API
    /// </remarks>
    public interface IBetfairBettingClient
    {
        /// <summary>
        ///     Adds X-Authentication header needed to request Betfair API
        /// </summary>
        /// <param name="authenticationHeader"></param>
        /// <returns></returns>
        IBetfairBettingClient AddAuthenticationHeader(string authenticationHeader);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listEventTypes
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <returns></returns>
        Task<IEnumerable<EventTypes>> GetListEventTypesAsync(MarketFilter marketFilter);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listCompetitions
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <returns></returns>
        Task<IEnumerable<CompetitionResult>> GetListCompetitionsAsync(MarketFilter marketFilter);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listTimeRanges
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="timeGranularity"></param>
        /// <returns></returns>
        Task<IEnumerable<TimeRangeResult>> GetListTimeRangesAsync(MarketFilter marketFilter, TimeGranularity timeGranularity);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listEvents
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<EventResult>> GetListEventsAsync(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listMarketTypes
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<MarketTypeResult>> GetListMarketTypesAsync(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listCountries
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<CountryCodeResult>> GetListCountriesAsync(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listVenues
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<VenueResult>> GetListVenuesAsync(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listMarketCatalogue
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="marketProjection"></param>
        /// <param name="sort"></param>
        /// <param name="maxResults"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<MarketCatalogue>> GetListMarketCatalogueAsync(MarketFilter marketFilter, 
            IEnumerable<MarketProjection> marketProjection, MarketSort sort, int maxResults, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listMarketBook
        /// </summary>
        /// <param name="marketIds"></param>
        /// <param name="priceProjection"></param>
        /// <param name="orderProjection"></param>
        /// <param name="matchProjection"></param>
        /// <param name="includeOverallPosition"></param>
        /// <param name="partitionMatchedByStrategyRef"></param>
        /// <param name="customerStrategyRefs"></param>
        /// <param name="currencyCode"></param>
        /// <param name="locale"></param>
        /// <param name="matchedSince"></param>
        /// <param name="betIds"></param>
        /// <returns></returns>
        Task<IEnumerable<MarketBook>> GetListMarketBookAsync(IEnumerable<string> marketIds, PriceProjection priceProjection,
            OrderProjection orderProjection, MatchProjection matchProjection, bool includeOverallPosition, bool partitionMatchedByStrategyRef,
            IEnumerable<string> customerStrategyRefs, string? currencyCode, string? locale, DateTime matchedSince, IEnumerable<string> betIds);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listMarketProfitAndLoss
        /// </summary>
        /// <param name="marketIds"></param>
        /// <param name="includeSettledBets"></param>
        /// <param name="includeBspBets"></param>
        /// <param name="netOfCommission"></param>
        /// <returns></returns>
        Task<IEnumerable<MarketProfitAndLoss>> GetListMarketProfitAndLossAsync(IEnumerable<string> marketIds, bool includeSettledBets, bool includeBspBets, bool netOfCommission);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listCurrentOrders
        /// </summary>
        /// <param name="betIds"></param>
        /// <param name="marketIds"></param>
        /// <param name="orderProjection"></param>
        /// <param name="customerOrderRefs"></param>
        /// <param name="customerStrategyRefs"></param>
        /// <param name="dateRange"></param>
        /// <param name="orderBy"></param>
        /// <param name="sortDir"></param>
        /// <param name="fromRecord"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        Task<CurrentOrderSummaryReport> GetListCurrentOrdersAsync(IEnumerable<string> betIds, IEnumerable<string> marketIds, OrderProjection orderProjection,
            IEnumerable<string> customerOrderRefs, IEnumerable<string> customerStrategyRefs, TimeRange dateRange, OrderBy orderBy, SortDir sortDir, int fromRecord, int recordCount);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listClearedOrders
        /// </summary>
        /// <param name="betStatus"></param>
        /// <param name="eventTypeIds"></param>
        /// <param name="eventIds"></param>
        /// <param name="marketIds"></param>
        /// <param name="runnerIds"></param>
        /// <param name="betIds"></param>
        /// <param name="customerOrderRefs"></param>
        /// <param name="customerStrategyRefs"></param>
        /// <param name="side"></param>
        /// <param name="settledDateRange"></param>
        /// <param name="groupBy"></param>
        /// <param name="includeItemDescription"></param>
        /// <param name="locale"></param>
        /// <param name="fromRecord"></param>
        /// <param name="recordCount"></param>
        /// <returns></returns>
        Task<ClearedOrderSummaryReport> GetListClearedOrdersAsync(BetStatus betStatus, IEnumerable<string> eventTypeIds, IEnumerable<string> eventIds,
            IEnumerable<string> marketIds, IEnumerable<string> runnerIds, IEnumerable<string> betIds, IEnumerable<string> customerOrderRefs,
            IEnumerable<string> customerStrategyRefs, Side side, TimeRange settledDateRange, GroupBy groupBy, bool includeItemDescription,
            string locale, int fromRecord, int recordCount);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/placeOrders
        /// </summary>
        /// <param name="marketId"></param>
        /// <param name="instructions"></param>
        /// <param name="customerRef"></param>
        /// <param name="marketVersion"></param>
        /// <param name="customerStrategyRef"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Task<PlaceExecutionReport> PlaceOrdersAsync(string marketId, IEnumerable<PlaceInstruction> instructions, string customerRef,
            MarketVersion marketVersion, string customerStrategyRef, bool @async);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/cancelOrders
        /// </summary>
        /// <param name="marketId"></param>
        /// <param name="instructions"></param>
        /// <param name="customerRef"></param>
        /// <returns></returns>
        Task<CancelExecutionReport> CancelOrdersAsync(string marketId, IEnumerable<CancelInstruction> instructions, string customerRef);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/replaceOrders
        /// </summary>
        /// <param name="marketId"></param>
        /// <param name="instructions"></param>
        /// <param name="customerRef"></param>
        /// <param name="marketVersion"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Task<ReplaceExecutionReport> ReplaceOrdersAsync(string marketId, IEnumerable<ReplaceInstruction> instructions,
            string customerRef, MarketVersion marketVersion, bool @async);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/updateOrders
        /// </summary>
        /// <param name="marketId"></param>
        /// <param name="instructions"></param>
        /// <param name="customerRef"></param>
        /// <returns></returns>
        Task<UpdateExecutionReport> UpdateOrdersAsync(string marketId, IEnumerable<UpdateInstruction> instructions, string customerRef);
    }
}
