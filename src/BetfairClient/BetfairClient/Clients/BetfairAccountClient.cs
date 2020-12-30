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
using System.Threading.Tasks;

namespace BetfairClient.Clients
{
    /// <summary>
    ///     Implementation of <see cref="IBetfairAccountClient"/>
    /// </summary>
    public class BetfairAccountClient : IBetfairAccountClient
    {
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
            _httpClient.DefaultRequestHeaders.Add(BetfairConstants.AuthenticationHeaderName, authenticationHeader);
            return this;
        }

        /// <inheritdoc/>
        public async Task<AccountStatementResponse> GetAccountStatement(AccountStatementRequest bodyRequest)
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{AccountUri}/getAccountStatement/", bodyAsStringContent);

            return JsonSerializer.Deserialize<AccountStatementResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<AccountDetailsResponse> GetAccountDetails()
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            HttpResponseMessage response = await _httpClient.GetAsync($"{AccountUri}/getAccountDetails/");

            return JsonSerializer.Deserialize<AccountDetailsResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<AccountDetailsResponse> GetDeveloperApplicationKeys()
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            HttpResponseMessage response = await _httpClient.GetAsync($"{AccountUri}/getDeveloperAppKeys/");

            return JsonSerializer.Deserialize<AccountDetailsResponse>(await response.Content.ReadAsStringAsync());
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
