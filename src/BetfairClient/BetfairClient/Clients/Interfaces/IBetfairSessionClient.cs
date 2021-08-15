using BetfairClient.Helpers;
using BetfairClient.Models.Session;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    /// <summary>
    ///     Exposes available methods to work with Betfair Session API
    /// </summary>
    /// <remarks>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Interactive+Login+-+API+Endpoint
    /// </remarks>
    public interface IBetfairSessionClient
    {
        /// <summary>
        ///     Adds X-Authentication header needed to request Betfair API
        /// </summary>
        /// <param name="authenticationHeader"></param>
        /// <returns></returns>
        IBetfairSessionClient AddAuthenticationHeader(string authenticationHeader);

        /// <summary>
        ///     Retrieves a session token with the given <see cref="SessionRequest.Username"/> and <see cref="SessionRequest.Password"/>.
        /// </summary>
        Task<SessionResponse> GetSessionTokenAsync(SessionRequest bodyRequest);

        /// <summary>
        ///     Keeps the session token, passed on <see cref="BetfairConstants.AuthenticationHeaderName"/> header, alive for another day
        /// </summary>
        /// <returns></returns>
        Task<SessionResponse> KeepAliveAsync();

        /// <summary>
        ///     Invalidates the session token, passed on <see cref="BetfairConstants.AuthenticationHeaderName"/>
        /// </summary>
        /// <returns></returns>
        Task<SessionResponse> LogoutAsync();
    }
}
