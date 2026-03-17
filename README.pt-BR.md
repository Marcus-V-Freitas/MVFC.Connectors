# MVFC.Connectors

Uma coleção de conectores .NET para integração com serviços externos e APIs REST de forma consistente, reutilizável e testável.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
[![codecov](https://codecov.io/gh/Marcus-V-Freitas/MVFC.Connectors/branch/main/graph/badge.svg)](https://codecov.io/gh/Marcus-V-Freitas/MVFC.Connectors)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Arquitetura modular de conectores organizada por domínio
- Abstrações HTTP reutilizáveis com handlers de autenticação e logging
- Interfaces tipadas para integração com serviços externos
- Projetado para testabilidade com cobertura de testes dedicada
- Domínios cobertos: finanças, geolocalização, governo, IA, educação, ferramentas de desenvolvimento e mais

---

## Pacotes

| Pacote | Serviço | Downloads |
|---|---|---|
| [MVFC.Connectors.BancoData](src/MVFC.Connectors.BancoData/README.pt-BR.md) | Dados bancários brutos e tratados do Banco Central do Brasil | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BancoData) |
| [MVFC.Connectors.BrasilApi](src/MVFC.Connectors.BrasilApi/README.pt-BR.md) | BrasilAPI: CEP, CNPJ, bancos, FIPE, IBGE, feriados, PIX e mais | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.BrasilApi) |
| [MVFC.Connectors.Commons](src/MVFC.Connectors.Commons/README.pt-BR.md) | Handlers, provedores, interfaces e configurações HTTP compartilhadas | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Commons) |
| [MVFC.Connectors.Conversores](src/MVFC.Connectors.Conversores/README.pt-BR.md) | Google Tradutor, Dictionary API e conversão de HTML para PDF | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Conversores) |
| [MVFC.Connectors.Developer](src/MVFC.Connectors.Developer/README.pt-BR.md) | Utilitários: consulta de IP, validação de e-mail, chave-valor e MySQL Explain | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Developer) |
| [MVFC.Connectors.Educacao](src/MVFC.Connectors.Educacao/README.pt-BR.md) | Dados educacionais via Hipolabs | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Educacao) |
| [MVFC.Connectors.Financas](src/MVFC.Connectors.Financas/README.pt-BR.md) | Instituições do BCB, Yahoo Finance e ações no Reddit | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Financas) |
| [MVFC.Connectors.Geo](src/MVFC.Connectors.Geo/README.pt-BR.md) | Geolocalização e resolução de endereços: ViaCEP, Geocoding, GeoNet | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Geo) |
| [MVFC.Connectors.IA](src/MVFC.Connectors.IA/README.pt-BR.md) | Conectores de IA: geração de imagens e textos via Pollinations | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.IA) |
| [MVFC.Connectors.Justica](src/MVFC.Connectors.Justica/README.pt-BR.md) | Dados judiciais via DataJud (CNJ) | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Justica) |
| [MVFC.Connectors.Sicoob](src/MVFC.Connectors.Sicoob/README.pt-BR.md) | Sicoob: cobrança bancária, boletos, pagamentos e webhooks | ![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Sicoob) |

---

## Instalação

Instale o meta-pacote com todos os conectores:

```bash
dotnet add package MVFC.Connectors
```

Ou instale apenas o pacote que você precisa:

```bash
dotnet add package MVFC.Connectors.BrasilApi
dotnet add package MVFC.Connectors.Sicoob
dotnet add package MVFC.Connectors.Geo
```

---

## Início Rápido

Registre os conectores desejados na sua coleção de serviços:

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBrasilApi();
builder.Services.AddSicoob(options =>
{
    options.ClientId = "seu-client-id";
    options.ClientSecret = "seu-client-secret";
});

var app = builder.Build();
```

Consumindo um conector via injeção de dependência:

```csharp
public class EnderecoService(ICepBrasilApi cepApi)
{
    public async Task<CepDto> ObterAsync(string cep, CancellationToken ct)
    {
        return await cepApi.ObterAsync(cep, ct);
    }
}
```

---

## Princípios de Design

- **Explícito em vez de mágico** — sem reflection oculta ou abstrações opacas
- **Composável** — cada conector é independente e auto-suficiente
- **Infraestrutura reutilizável** — autenticação e HTTP gerenciados via handlers compartilhados no Commons
- **Organização orientada a domínio** — pacotes agrupados por responsabilidade
- **Testabilidade em primeiro lugar** — cada conector acompanha cobertura de testes

---

## Testes

Todos os conectores são cobertos por testes de integração localizados em `tests/MVFC.Connectors.Tests`.

```bash
dotnet test
```

---

## Contribuindo

Leia o [CONTRIBUTING.md](CONTRIBUTING.md) antes de abrir issues ou pull requests.

---

## Segurança

Se você encontrar uma vulnerabilidade, consulte o [SECURITY.md](SECURITY.md).

---

## Licença

Distribuído sob a licença disponível em [LICENSE](LICENSE).
