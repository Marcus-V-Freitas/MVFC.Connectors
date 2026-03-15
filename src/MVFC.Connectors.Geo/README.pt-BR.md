# MVFC.Connectors.Geo

Conectores para geolocalização e resolução de endereços, com suporte a ViaCEP, Geocoding e GeoNet.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Geo.svg)](https://www.nuget.org/packages/MVFC.Connectors.Geo)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Geo.svg)](https://www.nuget.org/packages/MVFC.Connectors.Geo)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Consulta de endereços brasileiros por CEP via ViaCEP
- Resolução de coordenadas e endereços via Geocoding
- Dados de geolocalização via GeoNet

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Geo
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IViaCepApi` | Consulta de endereço brasileiro por CEP |
| `IGeocodingApi` | Geocodificação direta e reversa |
| `IGeoNetApi` | Dados de geolocalização e metadados de rede |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGeo();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Buscar endereço por CEP
public class EnderecoService(IViaCepApi viaCepApi)
{
    public async Task<EnderecoDto> ObterAsync(string cep, CancellationToken ct)
    {
        return await viaCepApi.ObterAsync(cep, ct);
    }
}
```

```csharp
// Geocodificar um endereço em coordenadas
public class GeoService(IGeocodingApi geocodingApi)
{
    public async Task<CoordenadasDto> ObterCoordenadasAsync(string endereco, CancellationToken ct)
    {
        return await geocodingApi.ObterAsync(endereco, ct);
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
| [MVFC.Connectors.BrasilApi](../MVFC.Connectors.BrasilApi/README.pt-BR.md) | Consulta alternativa de CEP via BrasilAPI |
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
