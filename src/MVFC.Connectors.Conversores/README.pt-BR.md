# MVFC.Connectors.Conversores

Conectores para serviços de conversão de conteúdo, incluindo tradução de texto, consulta de dicionário e geração de PDF a partir de HTML.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Conversores.svg)](https://www.nuget.org/packages/MVFC.Connectors.Conversores)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Conversores.svg)](https://www.nuget.org/packages/MVFC.Connectors.Conversores)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Tradução de texto via Google Tradutor
- Definições e fonética de palavras via Dictionary API
- Conversão de HTML para PDF via Html2Pdf

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Conversores
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IGoogleTradutorApi` | Tradução de texto via Google Tradutor |
| `IDictionaryApi` | Definições, fonética e exemplos de palavras |
| `IHtml2PdfApi` | Conversão de conteúdo HTML para PDF |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddConversores();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Traduzir texto
public class TraducaoService(IGoogleTradutorApi tradutorApi)
{
    public async Task<string> TraduzirAsync(string texto, string idiomaDestino, CancellationToken ct)
    {
        var resultado = await tradutorApi.TraduzirAsync(texto, idiomaDestino, ct);
        return resultado.TranslatedText;
    }
}
```

```csharp
// Consultar definição de palavra
public class DicionarioService(IDictionaryApi dictionaryApi)
{
    public async Task<DefinitionDto> ObterAsync(string palavra, CancellationToken ct)
    {
        return await dictionaryApi.ObterAsync(palavra, ct);
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.pt-BR.md) | Infraestrutura HTTP compartilhada |
| [MVFC.Connectors](../../README.pt-BR.md) | Visão geral do repositório |

---

## Contribuindo

Leia o [CONTRIBUTING.md](../../CONTRIBUTING.md) antes de abrir issues ou pull requests.

---

## Segurança

Se você encontrar uma vulnerabilidade, consulte o [SECURITY.md](../../SECURITY.md).

---

## Licença

Distribuído sob a licença disponível em [LICENSE](../../LICENSE).
