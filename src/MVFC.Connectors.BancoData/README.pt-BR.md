# MVFC.Connectors.BancoData

Conector para busca de dados bancários brutos e tratados do Banco Central do Brasil.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.BancoData.svg)](https://www.nuget.org/packages/MVFC.Connectors.BancoData)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BancoData.svg)](https://www.nuget.org/packages/MVFC.Connectors.BancoData)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Busca dados bancários brutos diretamente da fonte (`Bruto`)
- Busca e transforma dados bancários em DTOs normalizados (`Tratado`)
- Abordagem baseada em scraper para extração resiliente de dados
- Integrado com a infraestrutura HTTP do `MVFC.Connectors.Commons`

---

## Instalação

```bash
dotnet add package MVFC.Connectors.BancoData
```

---

## APIs Suportadas

| Interface | Descrição |
|---|---|
| `IBancoDataBrutoApi` | Lista bruta de bancos do Banco Central do Brasil |
| `IBancoDataTratadoApi` | Lista de bancos normalizada e estruturada |
| `IBancoDataScraper` | Abstração de scraper para extração de dados |
| `IBancoDataTransform` | Pipeline de transformação dos dados brutos |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBancoData();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Buscar lista bruta de bancos
public class BankService(IBancoDataBrutoHandler handler)
{
    public async Task<IEnumerable<BancoBrutoDto>> ObterBrutosAsync(CancellationToken ct)
    {
        return await handler.ObterAsync(ct);
    }
}
```

```csharp
// Buscar lista normalizada de bancos
public class BankService(IBancoDataTratadoHandler handler)
{
    public async Task<IEnumerable<BancoTratadoDto>> ObterAsync(CancellationToken ct)
    {
        return await handler.ObterAsync(ct);
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.pt-BR.md) | Infraestrutura HTTP compartilhada |
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.pt-BR.md) | Endpoint de bancos via BrasilAPI |
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
