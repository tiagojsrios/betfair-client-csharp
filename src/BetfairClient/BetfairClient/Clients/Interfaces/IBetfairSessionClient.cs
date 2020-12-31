using BetfairClient.Models.Session;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    public interface IBetfairSessionClient
    {
        /// <summary>
        ///     Adds X-Authentication header needed to request Betfair API
        /// </summary>
        /// <param name="authenticationHeader"></param>
        /// <returns></returns>
        IBetfairSessionClient AddAuthenticationHeader(string authenticationHeader);

        /// <summary>
        ///     Retrieves a session token
        /// </summary>
        /// <param name="bodyRequest"></param>
        /// <returns></returns>
        Task<SessionResponse> GetSessionToken(SessionRequest bodyRequest);

        /// <summary>
        ///     Extends the session timeout period
        /// </summary>
        /// <returns></returns>
        Task<SessionResponse> KeepAlive();

        /// <summary>
        ///     Logout to terminate current session
        /// </summary>
        /// <returns></returns>
        Task<SessionResponse> Logout();
    }
}
