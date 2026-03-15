# MVFC.Connectors.Justica

Connector for legal and judicial data via the DataJud API, provided by the Conselho Nacional de Justiça (CNJ).

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Justica.svg)](https://www.nuget.org/packages/MVFC.Connectors.Justica)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Justica.svg)](https://www.nuget.org/packages/MVFC.Connectors.Justica)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Access to judicial case data via DataJud (CNJ)
- Token-based authentication via `DataJudAuthProvider`
- Integrated with `MVFC.Connectors.Commons` authentication infrastructure

---

## Installation

```bash
dotnet add package MVFC.Connectors.Justica
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IDataJudApi` | Judicial case data from CNJ DataJud |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddJustica(options =>
{
    options.ApiKey = "your-datajud-api-key";
});

var app = builder.Build();
```

---

## Example

```csharp
public class ProcessoService(IDataJudApi dataJudApi)
{
    public async Task<ProcessoDto> GetAsync(string numero, CancellationToken ct)
    {
        return await dataJudApi.ObterAsync(numero, ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md) | Shared HTTP infrastructure and authentication |
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
