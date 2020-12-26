using BetfairClient.Models.Betting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBetfairBettingClient
    {
        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listEventTypes
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <returns></returns>
        Task<EventTypes> GetListEventTypes(MarketFilter marketFilter);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listCompetitions
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <returns></returns>
        Task<CompetitionResult> GetListCompetitions(MarketFilter marketFilter);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listTimeRanges
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="timeGranularity"></param>
        /// <returns></returns>
        Task<IEnumerable<TimeRangeResult>> GetListTimeRanges(MarketFilter marketFilter, TimeGranularity timeGranularity);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listEvents
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<EventResult>> GetListEvents(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listMarketTypes
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<MarketTypeResult>> GetListMarketTypes(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listCountries
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<CountryCodeResult>> GetListCountries(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listVenues
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<VenueResult>> GetListVenues(MarketFilter marketFilter, string? locale);

        /// <summary>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/listMarketCatalogue
        /// </summary>
        /// <param name="marketFilter"></param>
        /// <param name="marketProjection"></param>
        /// <param name="sort"></param>
        /// <param name="maxResults"></param>
        /// <param name="locale"></param>
        /// <returns></returns>
        Task<IEnumerable<MarketCatalogue>> GetListMarketCatalogue(MarketFilter marketFilter, 
            IEnumerable<MarketProjection> marketProjection, MarketSort sort, int maxResults, string? locale);
    }
}
