# MVFC.Connectors.Educacao

Conector para dados educacionais via a API pública Hipolabs, fornecendo informações sobre universidades e países ao redor do mundo.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Educacao.svg)](https://www.nuget.org/packages/MVFC.Connectors.Educacao)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Educacao.svg)](https://www.nuget.org/packages/MVFC.Connectors.Educacao)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Busca de universidades por nome e país
- Não requer autenticação
- Integrado com a infraestrutura HTTP do `MVFC.Connectors.Commons`

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Educacao
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IHipolabsApi` | Busca universidades por nome e/ou país |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEducacao();

var app = builder.Build();
```

---

## Exemplo

```csharp
public class UniversidadeService(IHipolabsApi hipolabsApi)
{
    public async Task<IEnumerable<UniversidadeDto>> BuscarAsync(string nome, string pais, CancellationToken ct)
    {
        return await hipolabsApi.BuscarAsync(nome, pais, ct);
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
