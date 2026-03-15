# MVFC.Connectors.Financas

Connectors for financial data including BCB institutions, Yahoo Finance, and Reddit stock discussions.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Financas.svg)](https://www.nuget.org/packages/MVFC.Connectors.Financas)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Financas.svg)](https://www.nuget.org/packages/MVFC.Connectors.Financas)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Full list of financial institutions registered at Banco Central do Brasil (BCB)
- Stock and asset market data via Yahoo Finance
- Stock ticker sentiment and discussion data from Reddit

---

## Installation

```bash
dotnet add package MVFC.Connectors.Financas
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IBcbInstituicaoApi` | Financial institutions registered at BCB |
| `IYahooApi` | Stock and asset market data |
| `IRedditStockApi` | Reddit stock discussions and sentiment |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFinancas();

var app = builder.Build();
```

---

## Examples

```csharp
// List all BCB-registered financial institutions
public class InstitutionService(IBcbInstituicaoApi bcbApi)
{
    public async Task<IEnumerable<InstituicaoDto>> GetAllAsync(CancellationToken ct)
    {
        return await bcbApi.ObterAsync(ct);
    }
}
```

```csharp
// Get stock quote from Yahoo Finance
public class StockService(IYahooApi yahooApi)
{
    public async Task<QuoteDto> GetQuoteAsync(string ticker, CancellationToken ct)
    {
        return await yahooApi.ObterAsync(ticker, ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md) | Shared HTTP infrastructure |
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.md) | BrasilAPI financial endpoints (exchange rates, interest rates) |
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
