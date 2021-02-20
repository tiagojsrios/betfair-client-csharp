using BetfairClient.Clients.Interfaces;
using BetfairClient.Helpers;
using BetfairClient.Models.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BetfairClient.Clients
{
    /// <summary>
    ///     Implementation of <see cref="IBetfairSessionClient"/>
    /// </summary>
    public class BetfairSessionClient : IBetfairSessionClient
    {
        /// <summary>
        ///     Json serializer options
        /// </summary>
        private static JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        ///     Session Base Uri
        /// </summary>
        private static readonly string SessionUri = "api/login";

        /// <summary>
        ///     Session Base Uri
        /// </summary>
        private static readonly string KeepAliveUri = "api/keepAlive";

        /// <summary>
        ///     Session Base Uri
        /// </summary>
        private static readonly string LogoutUri = "api/logout";

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

            _jsonSerializerOptions = new JsonSerializerOptions()
            { 
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            _jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        }

        /// <inheritdoc/>
        public IBetfairSessionClient AddAuthenticationHeader(string authenticationHeader)
        {
            string currentAuthenticationHeaderValue = _httpClient.DefaultRequestHeaders.GetValues(BetfairConstants.AuthenticationHeaderName).FirstOrDefault();

            if (!string.IsNullOrEmpty(currentAuthenticationHeaderValue))
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
        public async Task<SessionResponse> GetSessionToken(SessionRequest bodyRequest)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsync(SessionUri, 
        new FormUrlEncodedContent(new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("username", bodyRequest.Username),
                    new KeyValuePair<string, string>("password", bodyRequest.Password)
                })
            );

            return JsonSerializer.Deserialize<SessionResponse>(await httpResponseMessage.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<SessionResponse> KeepAlive()
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(KeepAliveUri);
            return JsonSerializer.Deserialize<SessionResponse>(await httpResponseMessage.Content.ReadAsStringAsync(), _jsonSerializerOptions);
        }

        /// <inheritdoc/>
        public async Task<SessionResponse> Logout()
        {
            if (!ValidateAuthenticationHeader())
            {
                throw new InvalidOperationException($"{BetfairConstants.AuthenticationHeaderName} header is either not set or empty");
            }

            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(LogoutUri);
            return JsonSerializer.Deserialize<SessionResponse>(await httpResponseMessage.Content.ReadAsStringAsync(), _jsonSerializerOptions);
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
