# MVFC.Connectors.Financas

Connectors for financial data including BCB institutions, Yahoo Finance, and ETF data via Investo.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Financas.svg)](https://www.nuget.org/packages/MVFC.Connectors.Financas)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Financas.svg)](https://www.nuget.org/packages/MVFC.Connectors.Financas)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Full list of financial institutions registered at Banco Central do Brasil (BCB)
- Stock and asset market data via Yahoo Finance
- ETF product data via Investo

---

## Installation

```bash
dotnet add package MVFC.Connectors.Financas
```

---

## Supported Services

| Interface            | Description                              |
| -------------------- | ---------------------------------------- |
| `IBcbInstituicaoApi` | Financial institutions registered at BCB |
| `IYahooApi`          | Stock and asset market data              |
| `IInvestoApi`        | ETF product lookup by name               |

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
    public async Task<YahooCurrencyDto> GetQuoteAsync(string ticker, CancellationToken ct)
    {
        var result = await yahooApi.ObterMoedaPorNomeEPeriodoAsync(ticker);
        return result.Content!;
    }
}
```

```csharp
// Look up an ETF by name via Investo
public class EtfService(IInvestoApi investoApi)
{
    public async Task<InvestoEtfDto> GetEtfAsync(string name, CancellationToken ct)
    {
        var result = await investoApi.ObterEtfPorNomeAsync(name);
        return result.Content!;
    }
}
```

---

## Related Packages

| Package                                                             | Description                                                    |
| ------------------------------------------------------------------- | -------------------------------------------------------------- |
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md)     | Shared HTTP infrastructure                                     |
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.md) | BrasilAPI financial endpoints (exchange rates, interest rates) |
| [MVFC.Connectors](../../README.md)                                  | Repository overview                                            |

---

## Contributing

Read [CONTRIBUTING.md](../../CONTRIBUTING.md) before opening issues or pull requests.

---

## Security

If you discover a vulnerability, please refer to [SECURITY.md](../../SECURITY.md).

---

## License

Distributed under the license available in [LICENSE](../../LICENSE).
