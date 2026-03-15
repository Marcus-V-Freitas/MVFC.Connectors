# MVFC.Connectors.BrasilApi

Connector for the [BrasilAPI](https://brasilapi.com.br) public API, covering a wide range of Brazilian public data.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.BrasilApi.svg)](https://www.nuget.org/packages/MVFC.Connectors.BrasilApi)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BrasilApi.svg)](https://www.nuget.org/packages/MVFC.Connectors.BrasilApi)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Typed interfaces for each BrasilAPI endpoint
- Covers address, financial, vehicle, geographic, and fiscal data
- No authentication required
- Fully integrated with `MVFC.Connectors.Commons` HTTP infrastructure

---

## Installation

```bash
dotnet add package MVFC.Connectors.BrasilApi
```

---

## Supported Endpoints

| Interface | Description |
|---|---|
| `IBancoBrasilApi` | Brazilian bank list |
| `ICepBrasilApi` | Address lookup by ZIP code (CEP) |
| `ICnpjBrasilApi` | Company data lookup by CNPJ |
| `ICambioBrasilApi` | Exchange rates |
| `ICorretoraBrasilApi` | Stock brokers registered at CVM |
| `ICptecBrasilApi` | Weather forecasts via CPTEC |
| `IDddBrasilApi` | DDD area code information |
| `IFeriadoBrasilApi` | Brazilian national holidays |
| `IFipeBrasilApi` | FIPE vehicle pricing table |
| `IIbgeBrasilApi` | IBGE cities and states data |
| `IIsbnBrasilApi` | Book data by ISBN |
| `INcmBrasilApi` | NCM fiscal classification |
| `IPixParticipantesBrasilApi` | PIX participants list |
| `IRegistroBrApi` | .br domain registration data |
| `ITaxaBrasilApi` | Brazilian financial interest rates |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBrasilApi();

var app = builder.Build();
```

---

## Examples

```csharp
// Lookup address by ZIP code
public class AddressService(ICepBrasilApi cepApi)
{
    public async Task<CepDto> GetAsync(string cep, CancellationToken ct)
    {
        return await cepApi.ObterAsync(cep, ct);
    }
}
```

```csharp
// Lookup company by CNPJ
public class CompanyService(ICnpjBrasilApi cnpjApi)
{
    public async Task<CnpjDto> GetAsync(string cnpj, CancellationToken ct)
    {
        return await cnpjApi.ObterAsync(cnpj, ct);
    }
}
```

```csharp
// List national holidays for a given year
public class HolidayService(IFeriadoBrasilApi feriadoApi)
{
    public async Task<IEnumerable<FeriadoDto>> GetAsync(int year, CancellationToken ct)
    {
        return await feriadoApi.ObterAsync(year, ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md) | Shared HTTP infrastructure |
| [MVFC.Connectors.Geo](../MVFC.Connectors.Geo/README.md) | Alternative address resolution via ViaCEP |
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
