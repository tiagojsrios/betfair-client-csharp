using BetfairClient.Models.Account;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBetfairAccountClient
    {
        /// <summary>
        ///     Adds X-Authentication header needed to request Betfair API
        /// </summary>
        /// <param name="authenticationHeader"></param>
        /// <returns></returns>
        IBetfairAccountClient AddAuthenticationHeader(string authenticationHeader);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyRequest"></param>
        /// <returns></returns>
        Task<AccountStatementResponse> GetAccountStatement(AccountStatementRequest bodyRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<AccountDetailsResponse> GetAccountDetails();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<AccountDetailsResponse> GetDeveloperApplicationKeys();
    }
}
