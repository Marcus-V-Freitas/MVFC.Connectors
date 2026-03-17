# MVFC.Connectors.Justica

Conector para dados judiciais via a API DataJud, fornecida pelo Conselho Nacional de Justiça (CNJ).

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Justica.svg)](https://www.nuget.org/packages/MVFC.Connectors.Justica)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Justica.svg)](https://www.nuget.org/packages/MVFC.Connectors.Justica)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](../../LICENSE)
[![CI](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml/badge.svg)](https://github.com/Marcus-V-Freitas/MVFC.Connectors/actions/workflows/ci.yml)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Acesso a dados de processos judiciais via DataJud (CNJ)
- Autenticação baseada em token via `DataJudAuthProvider`
- Integrado com a infraestrutura de autenticação do `MVFC.Connectors.Commons`

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Justica
```

---

## Serviços Suportados

| Interface | Descrição |
|---|---|
| `IDataJudApi` | Dados de processos judiciais do CNJ DataJud |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddJustica(options =>
{
    options.ApiKey = "sua-chave-datajud";
});

var app = builder.Build();
```

---

## Exemplo

```csharp
public class ProcessoService(IDataJudApi dataJudApi)
{
    public async Task<ProcessoDto> ObterAsync(string numero, CancellationToken ct)
    {
        return await dataJudApi.ObterAsync(numero, ct);
    }
}
```

---

## Pacotes Relacionados

| Pacote | Descrição |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.pt-BR.md) | Infraestrutura HTTP compartilhada e autenticação |
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
