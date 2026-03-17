# MVFC.Connectors.Commons

Shared HTTP infrastructure for all MVFC.Connectors packages. Provides authentication handlers, logging, user-agent providers, and HTTP settings.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Token-based authentication via `AuthTokenHandler`
- HTTP request/response logging via `LoggingHandler`
- Pluggable token provider interface `ITokenProvider`
- Random user-agent rotation via `RandomUserAgentProvider`
- Centralized HTTP configuration via `HttpSettings`

---

## Installation

```bash
dotnet add package MVFC.Connectors.Commons
```

---

## Components

| Component | Description |
|---|---|
| `AuthTokenHandler` | `DelegatingHandler` that injects bearer tokens into outgoing requests |
| `LoggingHandler` | `DelegatingHandler` that logs HTTP requests and responses |
| `ITokenProvider` | Abstraction for supplying authentication tokens |
| `IUserAgentProvider` | Abstraction for supplying User-Agent headers |
| `RandomUserAgentProvider` | Rotates user-agents on each request |
| `HttpSettings` | Centralized HTTP client configuration |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITokenProvider, MyTokenProvider>();
builder.Services.AddSingleton<IUserAgentProvider, RandomUserAgentProvider>();

var app = builder.Build();
```

---

## Example

```csharp
// Implement your own token provider
public class MyTokenProvider : ITokenProvider
{
    public async Task<string> GetTokenAsync(CancellationToken ct)
    {
        // retrieve token from your auth server
        return "your-bearer-token";
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors](../../README.md) | Repository overview |

---

## Contributing

Read [CONTRIBUTING.md](../../CONTRIBUTING.md) before opening issues or pull requests.

---

## Security

If you discover a vulnerability, please refer to [SECURITY.md](../../SECURITY.md).

---

## License

Distributed under the license available in [LICENSE](../../LICENSE).
