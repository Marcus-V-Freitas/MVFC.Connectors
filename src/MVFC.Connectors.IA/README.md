# MVFC.Connectors.IA

Connectors for AI-powered generation services via the Pollinations API, supporting both image and text generation.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.IA.svg)](https://www.nuget.org/packages/MVFC.Connectors.IA)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.IA.svg)](https://www.nuget.org/packages/MVFC.Connectors.IA)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- AI image generation from text prompts via Pollinations
- AI text generation via Pollinations
- Pluggable image generation provider via `IImagemPollinationsProvider`
- Extension methods for simplified usage

---

## Installation

```bash
dotnet add package MVFC.Connectors.IA
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IImagemPollinationsApi` | Generate images from text prompts |
| `ITextoPollinationsApi` | Generate text responses from prompts |
| `IImagemPollinationsProvider` | Provider abstraction for image generation |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIA();

var app = builder.Build();
```

---

## Examples

```csharp
// Generate an image from a prompt
public class ImageService(IImagemPollinationsProvider provider)
{
    public async Task<byte[]> GenerateAsync(string prompt, CancellationToken ct)
    {
        return await provider.GenerateAsync(prompt, ct);
    }
}
```

```csharp
// Generate text from a prompt
public class TextService(ITextoPollinationsApi textoApi)
{
    public async Task<string> GenerateAsync(string prompt, CancellationToken ct)
    {
        var result = await textoApi.GerarAsync(prompt, ct);
        return result.Text;
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
