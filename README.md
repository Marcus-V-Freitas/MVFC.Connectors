# MVFC.Connectors

A collection of .NET connectors for integrating external services and REST APIs
with a consistent, reusable, and testable approach.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
[![codecov](https://codecov.io/gh/Marcus-V-Freitas/MVFC.Connectors/branch/main/graph/badge.svg)](https://codecov.io/gh/Marcus-V-Freitas/MVFC.Connectors)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Modular connector architecture organized by domain
- Reusable HTTP abstractions with authentication and logging handlers
- Typed API interfaces for external service integration
- Designed for testability with dedicated test coverage
- Domains covered: finance, geolocation, government, AI, education, developer tools, and more

---

## Packages

| Package | Service | Downloads |
|---|---|---|
| [MVFC.Connectors.BancoData](src/MVFC.Connectors.BancoData/README.md) | Raw and transformed bank data from Banco Central do Brasil | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BancoData) |
| [MVFC.Connectors.BrasilApi](src/MVFC.Connectors.BrasilApi/README.md) | BrasilAPI: CEP, CNPJ, banks, FIPE, IBGE, holidays, PIX, and more | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BrasilApi) |
| [MVFC.Connectors.Commons](src/MVFC.Connectors.Commons/README.md) | Shared handlers, providers, interfaces, and HTTP settings | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Commons) |
| [MVFC.Connectors.Conversores](src/MVFC.Connectors.Conversores/README.md) | Google Translator, Dictionary API, HTML to PDF | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Conversores) |
| [MVFC.Connectors.Developer](src/MVFC.Connectors.Developer/README.md) | IP lookup, email validation, key-value store, MySQL Explain | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Developer) |
| [MVFC.Connectors.Educacao](src/MVFC.Connectors.Educacao/README.md) | Education data via Hipolabs API | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Educacao) |
| [MVFC.Connectors.Financas](src/MVFC.Connectors.Financas/README.md) | BCB institutions, Yahoo Finance, Reddit stocks | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Financas) |
| [MVFC.Connectors.Geo](src/MVFC.Connectors.Geo/README.md) | Geolocation and address resolution: ViaCEP, Geocoding, GeoNet | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Geo) |
| [MVFC.Connectors.IA](src/MVFC.Connectors.IA/README.md) | AI connectors: Pollinations image and text generation | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.IA) |
| [MVFC.Connectors.Justica](src/MVFC.Connectors.Justica/README.md) | Legal data via DataJud judicial records | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Justica) |
| [MVFC.Connectors.Sicoob](src/MVFC.Connectors.Sicoob/README.md) | Sicoob banking: billing, boleto, payment, and webhooks | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Sicoob) |

---

## Installation

Install the meta-package for all connectors:

```bash
dotnet add package MVFC.Connectors
```

Or install only the package you need:

```bash
dotnet add package MVFC.Connectors.BrasilApi
dotnet add package MVFC.Connectors.Sicoob
dotnet add package MVFC.Connectors.Geo
```

---

## Quick Start

Register your desired connectors in your service collection:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBrasilApi();
builder.Services.AddSicoob(options =>
{
    options.ClientId = "your-client-id";
    options.ClientSecret = "your-client-secret";
});

var app = builder.Build();
```

Consuming a connector via dependency injection:

```csharp
public class MyService(ICepBrasilApi cepApi)
{
    public async Task<CepDto> GetAddressAsync(string cep, CancellationToken ct)
    {
        return await cepApi.ObterAsync(cep, ct);
    }
}
```

---

## Design Principles

- **Explicit over magic** — no hidden reflection or opaque abstractions
- **Composable** — each connector is independent and self-contained
- **Reusable infrastructure** — authentication and HTTP handled via shared handlers in Commons
- **Domain-driven organization** — packages are grouped by responsibility
- **Testability first** — every connector ships with test coverage

---

## Tests

All connectors are covered by integration tests located in `tests/MVFC.Connectors.Tests`.

```bash
dotnet test
```

---

## Contributing

Read [CONTRIBUTING.md](CONTRIBUTING.md) before opening issues or pull requests.

---

## Security

If you discover a vulnerability, please refer to [SECURITY.md](SECURITY.md).

---

## License

Distributed under the license available in [LICENSE](LICENSE).
