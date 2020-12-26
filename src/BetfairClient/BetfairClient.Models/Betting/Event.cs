using System;

namespace BetfairClient.Models.Betting
{
    /// <summary>
    ///     Betfair documentation: https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-Event
    /// </summary>
    public class Event
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string Timezone { get; set; }

        public string Venue { get; set; }

        public DateTime OpenDate { get; set; }
    }
}
