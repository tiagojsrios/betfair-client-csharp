using BetfairClient.Clients.Interfaces;
using BetfairClient.Models.Session;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BetfairClient.Clients
{
    /// <summary>
    ///     Implementation of <see cref="IBetfairSessionClient"/>
    /// </summary>
    public class BetfairSessionClient : IBetfairSessionClient
    {
        /// <summary>
        ///     Session Base Uri
        /// </summary>
        private static readonly string SessionBaseUri = "api/login";

        /// <summary>
        ///     Http client
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        ///     <see cref="BetfairSessionClient"/> constructor
        /// </summary>
        /// <param name="httpClient">Typed HTTP client configured on <see cref="Extensions.BetfairClientExtensions"/></param>
        public BetfairSessionClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<SessionResponse> GetSessionToken(SessionRequest bodyRequest)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsync(SessionBaseUri, 
        new FormUrlEncodedContent(new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("username", bodyRequest.Username),
                    new KeyValuePair<string, string>("password", bodyRequest.Password)
                })
            );

            return JsonSerializer.Deserialize<SessionResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
        }
    }
}
