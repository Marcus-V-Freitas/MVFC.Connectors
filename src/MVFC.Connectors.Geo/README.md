# MVFC.Connectors.Geo

Connectors for geolocation and address resolution, supporting ViaCEP, Geocoding, and GeoNet.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Geo.svg)](https://www.nuget.org/packages/MVFC.Connectors.Geo)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Geo.svg)](https://www.nuget.org/packages/MVFC.Connectors.Geo)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Brazilian address lookup by ZIP code via ViaCEP
- Coordinates and address resolution via Geocoding
- Geolocation data via GeoNet

---

## Installation

```bash
dotnet add package MVFC.Connectors.Geo
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IViaCepApi` | Brazilian address lookup by ZIP code (CEP) |
| `IGeocodingApi` | Forward and reverse geocoding |
| `IGeoNetApi` | Geolocation data and network metadata |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGeo();

var app = builder.Build();
```

---

## Examples

```csharp
// Fetch address by CEP
public class AddressService(IViaCepApi viaCepApi)
{
    public async Task<EnderecoDto> GetAsync(string cep, CancellationToken ct)
    {
        return await viaCepApi.ObterAsync(cep, ct);
    }
}
```

```csharp
// Geocode an address into coordinates
public class GeoService(IGeocodingApi geocodingApi)
{
    public async Task<CoordenadasDto> GetCoordinatesAsync(string address, CancellationToken ct)
    {
        return await geocodingApi.ObterAsync(address, ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.md) | Alternative CEP lookup via BrasilAPI |
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md) | Shared HTTP infrastructure |
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
