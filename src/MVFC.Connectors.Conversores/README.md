# MVFC.Connectors.Conversores

Connectors for content conversion services, including text translation, dictionary lookup, and HTML to PDF generation.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Conversores.svg)](https://www.nuget.org/packages/MVFC.Connectors.Conversores)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Conversores.svg)](https://www.nuget.org/packages/MVFC.Connectors.Conversores)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Text translation via Google Translator
- Word definitions and phonetics via Dictionary API
- HTML to PDF conversion via Html2Pdf

---

## Installation

```bash
dotnet add package MVFC.Connectors.Conversores
```

---

## Supported Services

| Interface | Description |
|---|---|
| `IGoogleTradutorApi` | Text translation via Google Translator |
| `IDictionaryApi` | Word definitions, phonetics and examples |
| `IHtml2PdfApi` | HTML content to PDF conversion |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddConversores();

var app = builder.Build();
```

---

## Examples

```csharp
// Translate text
public class TranslationService(IGoogleTradutorApi tradutorApi)
{
    public async Task<string> TranslateAsync(string text, string targetLang, CancellationToken ct)
    {
        var result = await tradutorApi.TraduzirAsync(text, targetLang, ct);
        return result.TranslatedText;
    }
}
```

```csharp
// Lookup word definition
public class DictionaryService(IDictionaryApi dictionaryApi)
{
    public async Task<DefinitionDto> GetDefinitionAsync(string word, CancellationToken ct)
    {
        return await dictionaryApi.ObterAsync(word, ct);
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
