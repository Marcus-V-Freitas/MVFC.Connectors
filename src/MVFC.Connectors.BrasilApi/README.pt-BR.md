# MVFC.Connectors.BrasilApi

Conector para a [BrasilAPI](https://brasilapi.com.br), cobrindo uma ampla gama de dados públicos brasileiros.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.BrasilApi.svg)](https://www.nuget.org/packages/MVFC.Connectors.BrasilApi)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BrasilApi.svg)](https://www.nuget.org/packages/MVFC.Connectors.BrasilApi)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Interfaces tipadas para cada endpoint da BrasilAPI
- Cobre dados de endereço, financeiros, veículos, geográficos e fiscais
- Não requer autenticação
- Totalmente integrado com a infraestrutura HTTP do `MVFC.Connectors.Commons`

---

## Instalação

```bash
dotnet add package MVFC.Connectors.BrasilApi
```

---

## Endpoints Suportados

| Interface | Descrição |
|---|---|
| `IBancoBrasilApi` | Lista de bancos brasileiros |
| `ICepBrasilApi` | Consulta de endereço por CEP |
| `ICnpjBrasilApi` | Consulta de dados empresariais por CNPJ |
| `ICambioBrasilApi` | Taxas de câmbio |
| `ICorretoraBrasilApi` | Corretoras registradas na CVM |
| `ICptecBrasilApi` | Previsões do tempo via CPTEC |
| `IDddBrasilApi` | Informações de DDD |
| `IFeriadoBrasilApi` | Feriados nacionais brasileiros |
| `IFipeBrasilApi` | Tabela FIPE de precificação de veículos |
| `IIbgeBrasilApi` | Dados de municípios e estados do IBGE |
| `IIsbnBrasilApi` | Dados de livros por ISBN |
| `INcmBrasilApi` | Classificação fiscal NCM |
| `IPixParticipantesBrasilApi` | Lista de participantes do PIX |
| `IRegistroBrApi` | Dados de registro de domínios .br |
| `ITaxaBrasilApi` | Taxas de juros financeiras brasileiras |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBrasilApi();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Consultar endereço por CEP
public class EnderecoService(ICepBrasilApi cepApi)
{
    public async Task<CepDto> ObterAsync(string cep, CancellationToken ct)
    {
        return await cepApi.ObterAsync(cep, ct);
    }
}
```

```csharp
// Consultar empresa por CNPJ
public class EmpresaService(ICnpjBrasilApi cnpjApi)
{
    public async Task<CnpjDto> ObterAsync(string cnpj, CancellationToken ct)
    {
        return await cnpjApi.ObterAsync(cnpj, ct);
    }
}
```

```csharp
// Listar feriados nacionais de um ano
public class FeriadoService(IFeriadoBrasilApi feriadoApi)
{
    public async Task<IEnumerable<FeriadoDto>> ObterAsync(int ano, CancellationToken ct)
    {
        return await feriadoApi.ObterAsync(ano, ct);
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.pt-BR.md) | Infraestrutura HTTP compartilhada |
| [MVFC.Connectors.Geo](../MVFC.Connectors.Geo/README.pt-BR.md) | Consulta alternativa de endereço via ViaCEP |
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
