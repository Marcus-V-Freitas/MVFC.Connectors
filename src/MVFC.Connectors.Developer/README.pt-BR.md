# MVFC.Connectors.Developer

Conectores utilitários para fluxos de desenvolvimento, diagnósticos e ferramentas de infraestrutura.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Developer.svg)](https://www.nuget.org/packages/MVFC.Connectors.Developer)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Developer.svg)](https://www.nuget.org/packages/MVFC.Connectors.Developer)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Validação de e-mails descartáveis via Disify
- Detecção de phishing e URLs maliciosas via FishFish
- Geolocalização e metadados de IP via IP-API
- Armazenamento leve de chave-valor via KeyVal
- Análise de planos de execução MySQL via MySqlExplain

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Developer
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IDisifyEmailApi` | Detecta endereços de e-mail descartáveis ou inválidos |
| `IFishFishApi` | Verifica URLs e domínios contra phishing ou malware |
| `IIpApi` | Geolocalização e metadados de endereços IP |
| `IKeyValApi` | Armazenamento simples de chave-valor |
| `IMysqlExplainApi` | Análise e explicação de planos de execução MySQL |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDeveloper();

var app = builder.Build();
```

---

## Exemplos

```csharp
// Validar endereço de e-mail
public class EmailService(IDisifyEmailApi disifyApi)
{
    public async Task<bool> IsValidoAsync(string email, CancellationToken ct)
    {
        var resultado = await disifyApi.ValidarAsync(email, ct);
        return !resultado.Disposable;
    }
}
```

```csharp
// Consultar informações de um IP
public class IpService(IIpApi ipApi)
{
    public async Task<IpDto> ObterAsync(string ip, CancellationToken ct)
    {
        return await ipApi.ObterAsync(ip, ct);
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
