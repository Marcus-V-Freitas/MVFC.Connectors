# MVFC.Connectors.IA

Conectores para serviços de geração com inteligência artificial via a API Pollinations, com suporte a geração de imagens e textos.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.IA.svg)](https://www.nuget.org/packages/MVFC.Connectors.IA)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.IA.svg)](https://www.nuget.org/packages/MVFC.Connectors.IA)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Geração de imagens a partir de prompts de texto via Pollinations
- Geração de texto via Pollinations
- Provedor plugável de geração de imagens via `IImagemPollinationsProvider`
- Extension methods para uso simplificado

---

## Instalação

```bash
dotnet add package MVFC.Connectors.IA
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IImagemPollinationsApi` | Geração de imagens a partir de prompts |
| `ITextoPollinationsApi` | Geração de respostas textuais a partir de prompts |
| `IImagemPollinationsProvider` | Abstração de provedor para geração de imagens |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIA();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Gerar imagem a partir de um prompt
public class ImagemService(IImagemPollinationsProvider provider)
{
    public async Task<byte[]> GerarAsync(string prompt, CancellationToken ct)
    {
        return await provider.GenerateAsync(prompt, ct);
    }
}
```

```csharp
// Gerar texto a partir de um prompt
public class TextoService(ITextoPollinationsApi textoApi)
{
    public async Task<string> GerarAsync(string prompt, CancellationToken ct)
    {
        var resultado = await textoApi.GerarAsync(prompt, ct);
        return resultado.Text;
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
