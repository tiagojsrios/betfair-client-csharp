using System.Collections.Generic;

namespace BetfairClient.Models.Account
{
    public class AccountStatementResponse
    {
        public IEnumerable<AccountStatementItem> AccountStatement { get; set; }

        public bool MoreAvailable { get; set; }
    }
}
