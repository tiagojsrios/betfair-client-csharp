using BetfairClient.Clients.Interfaces;
using BetfairClient.Helpers;
using BetfairClient.Models.Account;
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
    ///     Implementation of <see cref="IBetfairAccountClient"/>
    /// </summary>
    public class BetfairAccountClient : IBetfairAccountClient
    {
        /// <summary>
        ///     Json serializer options
        /// </summary>
        private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true,
            Converters = { new JsonStringEnumConverter() }
        };

        /// <summary>
        ///     Account Base Uri
        /// </summary>
        private static readonly string AccountUri = "exchange/account/rest/v1.0";

        /// <summary>
        ///     Http client
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        ///     <see cref="BetfairAccountClient"/> constructor
        /// </summary>
        /// <param name="httpClient"></param>
        public BetfairAccountClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public IBetfairAccountClient AddAuthenticationHeader(string authenticationHeader)
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

        /// <inheritdoc cref="IBetfairAccountClient.GetAccountStatementAsync"/>
        public async Task<AccountStatementReport> GetAccountStatementAsync(string locale, int fromRecord, int recordCount, TimeRange itemDateRange, IncludeItem includeItem, Wallet wallet)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            var bodyRequest = new
            {
                Locale = locale,
                FromRecord = fromRecord,
                RecordCount = recordCount,
                ItemDateRange = itemDateRange,
                IncludeItem = includeItem,
                Wallet = wallet
            };

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest, JsonSerializerOptions), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{AccountUri}/getAccountStatement/", bodyAsStringContent).ConfigureAwait(false);

            return JsonSerializer.Deserialize<AccountStatementReport>(await response.Content.ReadAsStringAsync(), JsonSerializerOptions);
        }

        /// <inheritdoc cref="IBetfairAccountClient.GetAccountDetailsAsync"/>
        public async Task<AccountDetailsResponse> GetAccountDetailsAsync()
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            HttpResponseMessage response = await _httpClient.GetAsync($"{AccountUri}/getAccountDetails/").ConfigureAwait(false);

            return JsonSerializer.Deserialize<AccountDetailsResponse>(await response.Content.ReadAsStringAsync(), JsonSerializerOptions);
        }

        /// <inheritdoc cref="IBetfairAccountClient.GetDeveloperApplicationKeysAsync"/>
        public async Task<DeveloperApp> GetDeveloperApplicationKeysAsync()
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            HttpResponseMessage response = await _httpClient.GetAsync($"{AccountUri}/getDeveloperAppKeys/").ConfigureAwait(false);

            return JsonSerializer.Deserialize<DeveloperApp>(await response.Content.ReadAsStringAsync(), JsonSerializerOptions);
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
