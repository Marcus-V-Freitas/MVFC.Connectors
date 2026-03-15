# MVFC.Connectors.Commons

Infraestrutura HTTP compartilhada para todos os pacotes MVFC.Connectors. Fornece handlers de autenticação, logging, provedores de user-agent e configurações HTTP.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Commons.svg)](https://www.nuget.org/packages/MVFC.Connectors.Commons)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Autenticação baseada em token via `AuthTokenHandler`
- Log de requisições e respostas HTTP via `LoggingHandler`
- Interface plugável de provedor de token `ITokenProvider`
- Rotação aleatória de user-agent via `RandomUserAgentProvider`
- Configuração centralizada de HTTP via `HttpSettings`

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Commons
```

---

## Componentes

| Componente | Descrição |
|---|---|
| `AuthTokenHandler` | `DelegatingHandler` que injeta tokens bearer nas requisições de saída |
| `LoggingHandler` | `DelegatingHandler` que registra requisições e respostas HTTP |
| `ITokenProvider` | Abstração para fornecimento de tokens de autenticação |
| `IUserAgentProvider` | Abstração para fornecimento de headers User-Agent |
| `RandomUserAgentProvider` | Rotaciona user-agents a cada requisição |
| `HttpSettings` | Configuração centralizada do cliente HTTP |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITokenProvider, MeuTokenProvider>();
builder.Services.AddSingleton<IUserAgentProvider, RandomUserAgentProvider>();

var app = builder.Build();
```

---

## Exemplo

```csharp
// Implemente seu próprio provedor de token
public class MeuTokenProvider : ITokenProvider
{
    public async Task<string> GetTokenAsync(CancellationToken ct)
    {
        // recupere o token do seu servidor de autenticação
        return "seu-bearer-token";
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
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
