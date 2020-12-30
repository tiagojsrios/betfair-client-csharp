# .NET Core Betfair Client

Unofficial .NET Core 3.1 Betfair REST API HTTP client. The official documentation from Betfair can be found [here](https://docs.developer.betfair.com/).

## Betfair API covered

|             | Base Address | Supported | Will it be supported? |
| :---        |    :----:    |   :---:   |         :---:         |
| [**Session**](https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+API) |    https://identitysso.betfair.com/ | Yes    |          -         |
| [**Account**](https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Accounts+API) |    https://api.betfair.com/ | Yes    |          -         |
| [**Betting**](https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+API)  |    https://api.betfair.com/ | Yes    |          -         |

Base Address's column contains the base urls that can be used to configure the HttpClient. I refered the internacional exchange ones (.com), however you can use other ones as you may know. Please refer to the official documentation for more information.

## How to use Betfair clients?

Depending on which API from Betfair you want to use, you need to register the client on the dependency injection container. In order to accomplish that, you need to use the IServiceCollection extension methods found on [BetfairClientExtensions](https://github.com/tiagojsrios/betfair-client-csharp/blob/main/src/BetfairClient/BetfairClient/Extensions/BetfairClientExtensions.cs) class.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddBetfairSessionClient((client) => {
        client.BaseAddress = "BaseSessionAddress";
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        client.DefaultRequestHeaders.Add("X-Application", "YourApplicationToken");
    });
}
```

As the library creates a typed HttpClient, these extension methods receive an Action\<HttpClient\> that allows you to configure the HttpClient object.

Then you can easily inject [IBetfairSessionClient](https://github.com/tiagojsrios/betfair-client-csharp/blob/main/src/BetfairClient/BetfairClient/Clients/Interfaces/IBetfairSessionClient.cs) in your class' constructor, as shown below:

```csharp
public class Example
{
    private readonly IBetfairSessionClient _client;

    public Example(IBetfairSessionClient client)
    {
        _client = client;
    }
}
```

This example can be applied to correctly use the other clients.

## What is X-Authentication header?

Most of endpoints require the **X-Authentication** header to be set. Its value should be the session token retrieved after a successful call made to the login endpoint. All clients provide the method *AddAuthenticationHeader(string authenticationHeader)*, 

```csharp
public class Example
{
    private readonly IBetfairAccountClient _client;

    public Example(IBetfairAccountClient client)
    {
        _client = client;
    }
    
    public async Task<object> ExampleCall()
    {
        return await _client.AddAuthenticationHeader("YourAuthenticationTokenValue").GetAccountDetails();
    }
}
```
The method returns its own Client, so you can call it as a chain of executable methods.
**Important remark:** Whenever this is an endpoint requirement by Betfair, the code will check if the header exists and isn't null or empty.

## Other remarks about way of working

- Betfair's session token is valid for 24 hours, if using the international (.com) exchange. More information can be found [here](https://docs.developer.betfair.com/pages/viewpage.action?pageId=3834909).
