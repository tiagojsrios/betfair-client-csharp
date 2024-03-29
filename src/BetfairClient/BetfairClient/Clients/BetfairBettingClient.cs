﻿using Ardalis.GuardClauses;
using BetfairClient.Clients.Interfaces;
using BetfairClient.Helpers;
using BetfairClient.Models.Betting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BetfairClient.Clients
{
    /// <summary>
    ///     Implementation of <see cref="IBetfairBettingClient"/>
    /// </summary>
    public class BetfairBettingClient : IBetfairBettingClient
    {
        /// <summary>
        ///     Json serializer options
        /// </summary>
        private static JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        ///     Betting Base Uri
        /// </summary>
        private static readonly string BettingUri = "exchange/betting/rest/v1.0";

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

            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IgnoreNullValues = true
            };
            _jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        }

        /// <inheritdoc/>
        public IBetfairBettingClient AddAuthenticationHeader(string authenticationHeader)
        {
            bool hasHeader = _httpClient.DefaultRequestHeaders.TryGetValues(BetfairConstants.AuthenticationHeaderName, out IEnumerable<string> values);
            string currentAuthenticationHeaderValue = values?.FirstOrDefault();

            if (hasHeader && !string.IsNullOrEmpty(currentAuthenticationHeaderValue))
            {
                if (authenticationHeader != currentAuthenticationHeaderValue)
                {
                    _httpClient.DefaultRequestHeaders.Remove(BetfairConstants.AuthenticationHeaderName);
                }
                else
                {
                    return this;
                }
            }

            _httpClient.DefaultRequestHeaders.Add(BetfairConstants.AuthenticationHeaderName, authenticationHeader);
            return this;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<EventTypes>> GetListEventTypes(MarketFilter marketFilter)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(marketFilter, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listEventTypes/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<EventTypes>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CompetitionResult>> GetListCompetitions(MarketFilter marketFilter)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(marketFilter, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listCompetitions/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<CompetitionResult>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TimeRangeResult>> GetListTimeRanges(MarketFilter marketFilter, TimeGranularity timeGranularity)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                Filter = marketFilter,
                Granularity = timeGranularity
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listTimeRanges/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<TimeRangeResult>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<EventResult>> GetListEvents(MarketFilter marketFilter, string? locale)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listEvents/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<EventResult>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MarketTypeResult>> GetListMarketTypes(MarketFilter marketFilter, string? locale)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.Null(marketFilter, nameof(marketFilter));

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listMarketTypes/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<MarketTypeResult>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CountryCodeResult>> GetListCountries(MarketFilter marketFilter, string? locale)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.Null(marketFilter, nameof(marketFilter));

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listCountries/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<CountryCodeResult>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<VenueResult>> GetListVenues(MarketFilter marketFilter, string? locale)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.Null(marketFilter, nameof(marketFilter));

            var bodyRequest = new
            {
                Filter = marketFilter,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listVenues/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<VenueResult>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MarketCatalogue>> GetListMarketCatalogue(MarketFilter marketFilter, IEnumerable<MarketProjection> marketProjection,
            MarketSort sort, int maxResults, string? locale)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.Null(marketFilter, nameof(marketFilter));
            Guard.Against.OutOfRange(maxResults, nameof(maxResults), 0, 1000);

            var bodyRequest = new
            {
                Filter = marketFilter,
                MarketProjection = marketProjection,
                Sort = sort,
                MaxResults = maxResults,
                Locale = locale
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listMarketCatalogue/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<MarketCatalogue>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MarketBook>> GetListMarketBook(IEnumerable<string> marketIds, PriceProjection priceProjection,
            OrderProjection orderProjection, MatchProjection matchProjection, bool includeOverallPosition, bool partitionMatchedByStrategyRef,
            IEnumerable<string> customerStrategyRefs, string? currencyCode, string? locale, DateTime matchedSince, IEnumerable<string> betIds)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.NullOrEmpty(marketIds, nameof(marketIds));

            var bodyRequest = new
            {
                MarketIds = marketIds,
                PriceProjection = priceProjection,
                OrderProjection = orderProjection,
                MatchProjection = matchProjection,
                IncludeOverallPosition = includeOverallPosition,
                PartitionMatchedByStrategyRef = partitionMatchedByStrategyRef,
                CustomerStrategyRefs = customerStrategyRefs,
                CurrencyCode = currencyCode,
                Locale = locale,
                MatchedSince = matchedSince,
                BetIds = betIds
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listMarketBook/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<MarketBook>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<MarketProfitAndLoss>> GetListMarketProfitAndLoss(IEnumerable<string> marketIds, bool includeSettledBets, bool includeBspBets, bool netOfCommission)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.NullOrEmpty(marketIds, nameof(marketIds));

            var bodyRequest = new
            {
                MarketIds = marketIds,
                IncludeSettledBets = includeSettledBets,
                IncludeBspBets = includeBspBets,
                NetOfCommission = netOfCommission
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listMarketProfitAndLoss/", bodyAsStringContent);

            return JsonSerializer.Deserialize<IEnumerable<MarketProfitAndLoss>>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<CurrentOrderSummaryReport> GetListCurrentOrders(IEnumerable<string> betIds, IEnumerable<string> marketIds, OrderProjection orderProjection,
            IEnumerable<string> customerOrderRefs, IEnumerable<string> customerStrategyRefs, TimeRange dateRange, OrderBy orderBy, SortDir sortDir, int fromRecord, int recordCount)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                BetIds = betIds,
                MarketIds = marketIds,
                OrderProjection = orderProjection,
                CustomerOrderRefs = customerOrderRefs,
                CustomerStrategyRefs = customerStrategyRefs,
                DateRange = dateRange,
                OrderBy = orderBy,
                SortDir = sortDir,
                FromRecord = fromRecord,
                RecordCount = recordCount
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listCurrentOrders/", bodyAsStringContent);

            return JsonSerializer.Deserialize<CurrentOrderSummaryReport>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<ClearedOrderSummaryReport> GetListClearedOrders(BetStatus betStatus, IEnumerable<string> eventTypeIds, IEnumerable<string> eventIds, 
            IEnumerable<string> marketIds, IEnumerable<string> runnerIds, IEnumerable<string> betIds, IEnumerable<string> customerOrderRefs, 
            IEnumerable<string> customerStrategyRefs, Side side, TimeRange settledDateRange, GroupBy groupBy, bool includeItemDescription, 
            string locale, int fromRecord, int recordCount)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                BetStatus = betStatus,
                EventTypeIds = eventTypeIds,
                EventIds = eventIds,
                MarketIds = marketIds,
                RunnerIds = runnerIds,
                BetIds = betIds,
                CustomerOrderRefs = customerOrderRefs,
                CustomerStrategyRefs = customerStrategyRefs,
                Side = side,
                SettledDateRange = settledDateRange,
                GroupBy = groupBy,
                IncludeItemDescription = includeItemDescription,
                Locale = locale,
                FromRecord = fromRecord,
                RecordCount = recordCount
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/listClearedOrders/", bodyAsStringContent);

            return JsonSerializer.Deserialize<ClearedOrderSummaryReport>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<PlaceExecutionReport> PlaceOrders(string marketId, IEnumerable<PlaceInstruction> instructions, string customerRef, 
            MarketVersion marketVersion, string customerStrategyRef, bool @async)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                MarketId = marketId,
                Instructions = instructions,
                CustomerRef = customerRef,
                MarketVersion = marketVersion,
                CustomerStrategyRef = customerStrategyRef,
                Async = @async
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/placeOrders/", bodyAsStringContent);

            return JsonSerializer.Deserialize<PlaceExecutionReport>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<CancelExecutionReport> CancelOrders(string marketId, IEnumerable<CancelInstruction> instructions, string customerRef)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                MarketId = marketId,
                Instructions = instructions,
                CustomerRef = customerRef
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/cancelOrders/", bodyAsStringContent);

            return JsonSerializer.Deserialize<CancelExecutionReport>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<ReplaceExecutionReport> ReplaceOrders(string marketId, IEnumerable<ReplaceInstruction> instructions, 
            string customerRef, MarketVersion marketVersion, bool @async)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                MarketId = marketId,
                Instructions = instructions,
                CustomerRef = customerRef,
                MarketVersion = marketVersion,
                Async = @async
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/replaceOrders/", bodyAsStringContent);

            return JsonSerializer.Deserialize<ReplaceExecutionReport>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<UpdateExecutionReport> UpdateOrders(string marketId, IEnumerable<UpdateInstruction> instructions, string customerRef)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            Guard.Against.NullOrEmpty(marketId, nameof(marketId));
            Guard.Against.NullOrEmpty(instructions, nameof(instructions));

            var bodyRequest = new
            {
                MarketId = marketId,
                Instructions = instructions,
                CustomerRef = customerRef
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, _jsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{BettingUri}/replaceOrders/", bodyAsStringContent);

            return JsonSerializer.Deserialize<UpdateExecutionReport>(await response.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <summary>
        ///     Validates if <see cref="BetfairConstants.AuthenticationHeaderName"/> exists and if it isn't either null or empty
        /// </summary>
        /// <returns></returns>
        private bool ValidateAuthenticationHeader()
        {
            return _httpClient.DefaultRequestHeaders.TryGetValues(BetfairConstants.AuthenticationHeaderName, out IEnumerable<string> headerValues)
                && headerValues.FirstOrDefault(x => !string.IsNullOrEmpty(x)) != null;
        }
    }
}
