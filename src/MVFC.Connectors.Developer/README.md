# MVFC.Connectors.Developer

Utility connectors for development workflows, diagnostics, and infrastructure tooling.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Developer.svg)](https://www.nuget.org/packages/MVFC.Connectors.Developer)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Developer.svg)](https://www.nuget.org/packages/MVFC.Connectors.Developer)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Disposable email validation via Disify
- Phishing and malicious URL detection via FishFish
- IP geolocation and metadata via IP-API
- Lightweight key-value storage via KeyVal
- MySQL query explanation via MySqlExplain

---

## Installation

```bash
dotnet add package MVFC.Connectors.Developer
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IDisifyEmailApi` | Detect disposable or invalid email addresses |
| `IFishFishApi` | Check URLs and domains for phishing or malware |
| `IIpApi` | IP address geolocation and metadata |
| `IKeyValApi` | Simple key-value store for lightweight persistence |
| `IMysqlExplainApi` | Analyze and explain MySQL query execution plans |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDeveloper();

var app = builder.Build();
```

---

## Examples

```csharp
// Validate an email address
public class EmailService(IDisifyEmailApi disifyApi)
{
    public async Task<bool> IsValidAsync(string email, CancellationToken ct)
    {
        var result = await disifyApi.ValidarAsync(email, ct);
        return !result.Disposable;
    }
}
```

```csharp
// Check an IP address
public class IpService(IIpApi ipApi)
{
    public async Task<IpDto> GetInfoAsync(string ip, CancellationToken ct)
    {
        return await ipApi.ObterAsync(ip, ct);
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
