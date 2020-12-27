using BetfairClient.Clients.Interfaces;
using BetfairClient.Models.Account;
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
        private static readonly string AccountBaseUri = "account/rest/v1.0";

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
        public async Task<AccountStatementResponse> GetAccountStatement(AccountStatementRequest bodyRequest)
        {
            StringContent bodyAsStringContent = new StringContent(JsonSerializer.Serialize(bodyRequest), Encoding.UTF8, MediaTypeNames.Application.Json);
            HttpResponseMessage response = await _httpClient.PostAsync($"{AccountBaseUri}/getAccountStatement/", bodyAsStringContent);

            return JsonSerializer.Deserialize<AccountStatementResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<AccountDetailsResponse> GetAccountDetails()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{AccountBaseUri}/getAccountDetails/");

            return JsonSerializer.Deserialize<AccountDetailsResponse>(await response.Content.ReadAsStringAsync());
        }

        /// <inheritdoc/>
        public async Task<AccountDetailsResponse> GetDeveloperApplicationKeys()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{AccountBaseUri}/getDeveloperAppKeys/");

            return JsonSerializer.Deserialize<AccountDetailsResponse>(await response.Content.ReadAsStringAsync());
        }
    }
}
