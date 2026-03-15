# MVFC.Connectors.BancoData

Connector for fetching raw and transformed bank data from Banco Central do Brasil.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.BancoData.svg)](https://www.nuget.org/packages/MVFC.Connectors.BancoData)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BancoData.svg)](https://www.nuget.org/packages/MVFC.Connectors.BancoData)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Fetches raw bank data directly from the source (`Bruto`)
- Fetches and transforms bank data into normalized DTOs (`Tratado`)
- Scraper-based approach for resilient data extraction
- Integrated with `MVFC.Connectors.Commons` HTTP infrastructure

---

## Installation

```bash
dotnet add package MVFC.Connectors.BancoData
```

---

## Supported APIs

| Interface | Description |
|---|---|
| `IBancoDataBrutoApi` | Raw bank list from Banco Central do Brasil |
| `IBancoDataTratadoApi` | Normalized and structured bank list |
| `IBancoDataScraper` | Scraper abstraction for data extraction |
| `IBancoDataTransform` | Transformation pipeline for raw data |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBancoData();

var app = builder.Build();
```

---

## Examples

```csharp
// Fetch raw bank list
public class BankService(IBancoDataBrutoHandler handler)
{
    public async Task<IEnumerable<BancoBrutoDto>> GetRawAsync(CancellationToken ct)
    {
        return await handler.ObterAsync(ct);
    }
}
```

```csharp
// Fetch normalized bank list
public class BankService(IBancoDataTratadoHandler handler)
{
    public async Task<IEnumerable<BancoTratadoDto>> GetAsync(CancellationToken ct)
    {
        return await handler.ObterAsync(ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md) | Shared HTTP infrastructure |
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.md) | BrasilAPI bank endpoint |
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
