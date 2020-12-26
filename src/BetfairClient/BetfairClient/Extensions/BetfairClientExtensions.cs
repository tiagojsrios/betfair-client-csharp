using BetfairClient.Clients;
using BetfairClient.Clients.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace BetfairClient.Extensions
{
    /// <summary>
    ///     Class that handles extension methods to configure HTTP clients that will request Betfair API
    /// </summary>
    public static class BetfairClientExtensions
    {
        /// <summary>
        ///     <see cref="IServiceCollection"/> extension method that configures typed HTTP client for <see cref="BetfairSessionClient"/>
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientConfiguration"></param>
        public static void AddBetfairSessionClient(this IServiceCollection services, Action<HttpClient> clientConfiguration)
        {
            services
                .AddHttpClient(nameof(BetfairSessionClient), clientConfiguration)
                .AddTypedClient<IBetfairSessionClient>((client, sp) => new BetfairSessionClient(client));
        }

        /// <summary>
        ///     <see cref="IServiceCollection"/> extension method that configures typed HTTP client for <see cref="BetfairAccountClient"/>
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientConfiguration"></param>
        public static void AddBetfairAccountClient(this IServiceCollection services, Action<HttpClient> clientConfiguration)
        {
            services
                .AddHttpClient(nameof(BetfairAccountClient), clientConfiguration)
                .AddTypedClient<IBetfairAccountClient>((client, sp) => new BetfairAccountClient(client));
        }

        /// <summary>
        ///     <see cref="IServiceCollection"/> extension method that configures typed HTTP client for <see cref="BetfairBettingClient"/>
        /// </summary>
        /// <param name="services"></param>
        /// <param name="clientConfiguration"></param>
        public static void AddBetfairBettingClient(this IServiceCollection services, Action<HttpClient> clientConfiguration)
        {
            services
                .AddHttpClient(nameof(BetfairBettingClient), clientConfiguration)
                .AddTypedClient<IBetfairBettingClient>((client, sp) => new BetfairBettingClient(client));
        }
    }
}
