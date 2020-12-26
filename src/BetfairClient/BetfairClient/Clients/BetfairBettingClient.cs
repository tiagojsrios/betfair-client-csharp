using BetfairClient.Clients.Interfaces;
using BetfairClient.Models.Betting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BetfairClient.Clients
{
    /// <summary>
    ///     Implementation of <see cref="IBetfairBettingClient"/>
    /// </summary>
    public class BetfairBettingClient : IBetfairBettingClient
    {
        /// <summary>
        ///     Betting Base Uri
        /// </summary>
        private static readonly string BettingBaseUri = "betting/rest/v1.0";

        /// <summary>
        ///     Http client
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        ///     <see cref="BetfairBettingClient"/> constructor
        /// </summary>
        /// <param name="httpClient"></param>
        public BetfairBettingClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<EventTypes> GetListEventTypes(MarketFilter marketFilter)
        {
            var bodyAsStringContent = new StringContent(JsonSerializer.Serialize(marketFilter), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listEventTypes/", bodyAsStringContent);

            //if (!response.IsSuccessStatusCode)
            //{
            //    var errorObject = JsonSerializer.Deserialize<ErrorResponse>(await response.Content.ReadAsStringAsync());
            //}

            return JsonSerializer.Deserialize<EventTypes>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<CompetitionResult> GetListCompetitions(MarketFilter marketFilter)
        {
            var bodyAsStringContent = new StringContent(JsonSerializer.Serialize(marketFilter), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listCompetitions/", bodyAsStringContent);

            return JsonSerializer.Deserialize<CompetitionResult>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TimeRangeResult>> GetListTimeRanges(MarketFilter marketFilter, TimeGranularity timeGranularity)
        {
            var bodyRequest = new { 
                Filter = marketFilter,
                Granularity = timeGranularity 
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listTimeRanges/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<TimeRangeResult>>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<EventResult>> GetListEvents(MarketFilter marketFilter, string? locale)
        {
            if (marketFilter == null) { throw new ArgumentNullException(nameof(marketFilter)); }

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listEvents/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<EventResult>>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MarketTypeResult>> GetListMarketTypes(MarketFilter marketFilter, string? locale)
        {
            if (marketFilter == null) { throw new ArgumentNullException(nameof(marketFilter)); }

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listMarketTypes/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<MarketTypeResult>>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CountryCodeResult>> GetListCountries(MarketFilter marketFilter, string? locale)
        {
            if (marketFilter == null) { throw new ArgumentNullException(nameof(marketFilter)); }

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listCountries/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<CountryCodeResult>>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<VenueResult>> GetListVenues(MarketFilter marketFilter, string? locale)
        {
            if (marketFilter == null) { throw new ArgumentNullException(nameof(marketFilter)); }

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listVenues/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<VenueResult>>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MarketCatalogue>> GetListMarketCatalogue(MarketFilter marketFilter, IEnumerable<MarketProjection> marketProjection, 
            MarketSort sort, int maxResults, string? locale)
        {
            if (marketFilter == null) { throw new ArgumentNullException(nameof(marketFilter)); }

            if (maxResults < 0 || maxResults > 1000) { throw new ArgumentOutOfRangeException(nameof(maxResults)); }

            var bodyRequest = new
            {
                Filter = marketFilter,
                MarketProjection = marketProjection,
                Sort = sort,
                MaxResults = maxResults,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingBaseUri}/listMarketCatalogue/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<MarketCatalogue>>(await response.Content.ReadAsStringAsync());
        }
    }
}
