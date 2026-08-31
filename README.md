[![](https://img.shields.io/nuget/v/soenneker.openhands.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openhands.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openhands.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openhands.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openhands.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openhands.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openhands.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openhands.httpclients/actions/workflows/codeql.yml)

# Soenneker.OpenHands.HttpClients

Provides a cached `HttpClient` configured for the OpenHands Cloud API, including bearer authentication.

## Install

```bash
dotnet add package Soenneker.OpenHands.HttpClients
```

## Configuration

```json
{
  "OpenHands": {
    "ApiKey": "your-api-key"
  }
}
```

`OpenHands:ClientBaseUrl`, `OpenHands:AuthHeaderName`, and `OpenHands:AuthHeaderValueTemplate` can override the defaults.

## Usage

```csharp
using Soenneker.OpenHands.HttpClients.Abstract;
using Soenneker.OpenHands.HttpClients.Registrars;

services.AddOpenHandsOpenApiHttpClientAsSingleton();

IOpenHandsOpenApiHttpClient provider = serviceProvider
    .GetRequiredService<IOpenHandsOpenApiHttpClient>();

HttpClient client = await provider.Get(cancellationToken);
HttpResponseMessage response = await client.GetAsync(
    "app-conversations/search?limit=20",
    cancellationToken);
response.EnsureSuccessStatusCode();
```

The provider owns its cached client. Disposing the provider removes and disposes that client. Scoped registration gives each provider instance its own cached client.
