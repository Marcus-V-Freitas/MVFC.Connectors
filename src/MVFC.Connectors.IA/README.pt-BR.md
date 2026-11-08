# MVFC.Connectors.IA

Conectores para serviços de geração com inteligência artificial via a API Pollinations, com suporte a geração de textos.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.IA.svg)](https://www.nuget.org/packages/MVFC.Connectors.IA)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.IA.svg)](https://www.nuget.org/packages/MVFC.Connectors.IA)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Geração de texto via Pollinations
- Extension methods para uso simplificado

---

## Instalação

```bash
dotnet add package MVFC.Connectors.IA
```

---

## Serviços Suportados

| Interface                     | Descrição                                         |
| -----------------------       | ------------------------------------------------- |
| `ITextoPollinationsApi`       | Geração de respostas textuais a partir de prompts |

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
// Gerar texto a partir de um prompt
public class TextoService(ITextoPollinationsApi textoApi)
{
    public async Task<string> GerarAsync(string prompt, CancellationToken ct)
    {
        var resultado = await textoApi.GerarTextoAsync(prompt);
        return resultado.Content!;
    }
}
```

---

## Pacotes Relacionados

| Pacote                                                                | Descrição                         |
| --------------------------------------------------------------------- | --------------------------------- |
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.pt-BR.md) | Infraestrutura HTTP compartilhada |
| [MVFC.Connectors](../../README.pt-BR.md)                              | Visão geral do repositório        |

---

## Contribuindo

Leia o [CONTRIBUTING.md](../../CONTRIBUTING.md) antes de abrir issues ou pull requests.

---

## Segurança

Se você encontrar uma vulnerabilidade, consulte o [SECURITY.md](../../SECURITY.md).

---

## Licença

Distribuído sob a licença disponível em [LICENSE](../../LICENSE).
