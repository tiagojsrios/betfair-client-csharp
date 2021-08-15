using BetfairClient.Helpers;
using BetfairClient.Models.Account;
using System.Threading.Tasks;

namespace BetfairClient.Clients.Interfaces
{
    /// <summary>
    ///     Exposes available methods to work with Betfair Accounts API
    /// </summary>
    /// <remarks>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+API
    /// </remarks>
    public interface IBetfairAccountClient
    {
        /// <summary>
        ///     Adds X-Authentication header needed to request Betfair API
        /// </summary>
        /// <param name="authenticationHeader"></param>
        /// <returns></returns>
        IBetfairAccountClient AddAuthenticationHeader(string authenticationHeader);

        /// <summary>
        ///     Returns a collection of statements/operations associated to the current user.
        ///     The response is ordered chronologically and the pagination can be managed through <see cref="AccountStatementReport.MoreAvailable"/> property.
        ///     This endpoint requires the <see cref="BetfairConstants.AuthenticationHeaderName"/> header to be set.
        /// </summary>
        /// <remarks>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/getAccountStatement
        /// </remarks>
        Task<AccountStatementReport> GetAccountStatementAsync(string locale, int fromRecord, int recordCount, TimeRange itemDateRange, IncludeItem includeItem, Wallet wallet);

        /// <summary>
        ///     Returns the details of the current account.
        ///     This endpoint requires the <see cref="BetfairConstants.AuthenticationHeaderName"/> header to be set.
        /// </summary>
        /// <remarks>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/getAccountDetails
        /// </remarks>
        Task<AccountDetailsResponse> GetAccountDetailsAsync();

        /// <summary>
        ///     Returns existing developer application keys associated to the current account.
        ///     This endpoint requires the <see cref="BetfairConstants.AuthenticationHeaderName"/> header to be set.
        /// </summary>
        /// <remarks>
        ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/getDeveloperAppKeys
        /// </remarks>
        Task<DeveloperApp> GetDeveloperApplicationKeysAsync();
    }
}
