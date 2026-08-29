[![](https://img.shields.io/nuget/v/soenneker.openhands.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openhands.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openhands.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openhands.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openhands.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openhands.httpclients/)

# Soenneker.OpenHands.HttpClients

A .NET thread-safe singleton HttpClient for.

## Install

```bash
dotnet add package Soenneker.OpenHands.HttpClients
```

## Quick start

```csharp
using Soenneker.OpenHands.HttpClients.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddOpenHandsOpenApiHttpClientAsSingleton();
```

Adds `OpenHandsOpenApiHttpClient` as a singleton service.

## What you get

- `IOpenHandsOpenApiHttpClient` — A .NET thread-safe singleton HttpClient for.
- `OpenHandsOpenApiHttpClientRegistrar` — Registers the OpenAPI HttpClient wrapper for dependency injection.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `OpenHandsOpenApiHttpClientRegistrar.AddOpenHandsOpenApiHttpClientAsSingleton(services)` | Adds `OpenHandsOpenApiHttpClient` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `OpenHandsOpenApiHttpClientRegistrar.AddOpenHandsOpenApiHttpClientAsScoped(services)` | Adds `OpenHandsOpenApiHttpClient` as a scoped service. | The same service collection, so additional registrations can be chained. |

## Practical notes

- Reuse the registered client instead of constructing one per operation.
- Calls that return a cached or singleton value reuse the same instance until the owning service is disposed.
- Dispose instances you own when their scope ends so held resources can be released.
