using BetfairClient.Models.Session;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    public interface IBetfairSessionClient
    {
        /// <summary>
        ///     Retrieves a session token
        /// </summary>
        /// <param name="bodyRequest"></param>
        /// <returns></returns>
        Task<SessionResponse> GetSessionToken(SessionRequest bodyRequest);
    }
}
