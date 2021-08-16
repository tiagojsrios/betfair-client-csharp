using BetfairClient.Clients;
using BetfairClient.Clients.Interfaces;
using BetfairClient.Models.Betting;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using Xunit;

namespace BetfairClient.UnitTests
{
    public class BetfairBettingClientTests
    {
        private readonly Mock<HttpClient> _httpClientMock;

        public BetfairBettingClientTests()
        {
            var httpMessageHandlerStub = new HttpMessageHandlerStub(async (request, cancellationToken) =>
            {
                var responseMessage = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("[]")
                };

                return await Task.FromResult(responseMessage);
            });


            _httpClientMock = new Mock<HttpClient>(httpMessageHandlerStub) { CallBase = true };
            _httpClientMock.SetupAllProperties();

            _httpClientMock.Object.BaseAddress = new Uri("https://fake.url");
            _httpClientMock.Object.DefaultRequestHeaders.Add("Accept", MediaTypeNames.Application.Json);
            _httpClientMock.Object.DefaultRequestHeaders.Add("X-Application", "FakeApplicationKey");
        }

        [Fact]
        public async Task AuthenticationHeaderShouldNotBeEmptyAndRequestBeSuccessful()
        {
            IBetfairBettingClient betfairBettingClient = new BetfairBettingClient(_httpClientMock.Object);

            IEnumerable<CountryCodeResult> getListCountriesResponse = await betfairBettingClient
                .AddAuthenticationHeader("FakeAuthenticationHeader")
                .GetListCountriesAsync(new MarketFilter(), null);

            // Assert
            getListCountriesResponse.Should().BeEmpty();
        }

        [Fact]
        public void AuthenticationHeaderShouldBeEmptyAndRequestThrowAnException()
        {
            IBetfairBettingClient betfairBettingClient = new BetfairBettingClient(_httpClientMock.Object);

            // Assert
            Func<Task> action = async () => await betfairBettingClient.GetListCountriesAsync(new MarketFilter(), null);
            action.Should().ThrowExactly<InvalidOperationException>();
        }
    }
}
