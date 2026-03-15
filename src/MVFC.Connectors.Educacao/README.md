# MVFC.Connectors.Educacao

Connector for education-related data via the Hipolabs public API, providing information about universities and countries worldwide.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Educacao.svg)](https://www.nuget.org/packages/MVFC.Connectors.Educacao)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Educacao.svg)](https://www.nuget.org/packages/MVFC.Connectors.Educacao)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Search universities by name and country
- No authentication required
- Integrated with `MVFC.Connectors.Commons` HTTP infrastructure

---

## Installation

```bash
dotnet add package MVFC.Connectors.Educacao
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IHipolabsApi` | Search universities by name and/or country |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEducacao();

var app = builder.Build();
```

---

## Example

```csharp
public class UniversityService(IHipolabsApi hipolabsApi)
{
    public async Task<IEnumerable<UniversidadeDto>> SearchAsync(string name, string country, CancellationToken ct)
    {
        return await hipolabsApi.BuscarAsync(name, country, ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
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
