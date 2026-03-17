# MVFC.Connectors.Financas

Conectores para dados financeiros, incluindo instituições do BCB, Yahoo Finance e discussões de ações no Reddit.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Financas.svg)](https://www.nuget.org/packages/MVFC.Connectors.Financas)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Financas.svg)](https://www.nuget.org/packages/MVFC.Connectors.Financas)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Lista completa de instituições financeiras registradas no Banco Central do Brasil (BCB)
- Dados de mercado de ações e ativos via Yahoo Finance
- Dados de discussões e sentimento de ações no Reddit

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Financas
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IBcbInstituicaoApi` | Instituições financeiras registradas no BCB |
| `IYahooApi` | Dados de mercado de ações e ativos |
| `IRedditStockApi` | Discussões e sentimento de ações no Reddit |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFinancas();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Listar todas as instituições financeiras do BCB
public class InstituicaoService(IBcbInstituicaoApi bcbApi)
{
    public async Task<IEnumerable<InstituicaoDto>> ObterAsync(CancellationToken ct)
    {
        return await bcbApi.ObterAsync(ct);
    }
}
```

```csharp
// Consultar cotação via Yahoo Finance
public class AcaoService(IYahooApi yahooApi)
{
    public async Task<QuoteDto> ObterAsync(string ticker, CancellationToken ct)
    {
        return await yahooApi.ObterAsync(ticker, ct);
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.pt-BR.md) | Infraestrutura HTTP compartilhada |
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.pt-BR.md) | Endpoints financeiros da BrasilAPI (câmbio, taxas) |
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
