# MVFC.Connectors.Sicoob

Conector para as APIs bancárias do Sicoob, cobrindo cobrança bancária, gestão de boletos, pagamentos, negativação, protestos e webhooks.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Sicoob.svg)](https://www.nuget.org/packages/MVFC.Connectors.Sicoob)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Sicoob.svg)](https://www.nuget.org/packages/MVFC.Connectors.Sicoob)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

[English](README.md) | Português

---

## Funcionalidades

- Emissão, consulta e cancelamento de boletos
- Movimentações de cobrança e gestão de pagadores
- Operações de negativação e protesto
- Registro e gerenciamento de webhooks
- Consulta e liquidação de pagamentos
- Autenticação OAuth2 via `SicoobAuthProvider`

---

## Instalação

```bash
dotnet add package MVFC.Connectors.Sicoob
```

---

## APIs Suportadas

| Interface | Descrição |
|---|---|
| `ISicoobCobrancaBancariaApi.Boleto` | Emissão, consulta e cancelamento de boletos |
| `ISicoobCobrancaBancariaApi.Health` | Verificação de saúde da API |
| `ISicoobCobrancaBancariaApi.Movimentacao` | Consulta de movimentações de cobrança |
| `ISicoobCobrancaBancariaApi.Negativacao` | Operações de negativação |
| `ISicoobCobrancaBancariaApi.Pagador` | Cadastro e gestão de pagadores |
| `ISicoobCobrancaBancariaApi.Protesto` | Operações de protesto |
| `ISicoobCobrancaBancariaApi.Webhook` | Registro e gerenciamento de webhooks |
| `ISicoobCobrancaBancariaPagamentoApi.Boleto` | Consulta de boletos para pagamento |
| `ISicoobCobrancaBancariaPagamentoApi.Pagamento` | Confirmação e liquidação de pagamentos |

---

## Início Rápido

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSicoob(options =>
{
    options.ClientId = "seu-client-id";
    options.ClientSecret = "seu-client-secret";
});

var app = builder.Build();
```

---

## Exemplos

```csharp
// Emitir um boleto
public class BoletoService(ISicoobCobrancaBancariaApi cobrancaApi)
{
    public async Task<BoletoDto> EmitirAsync(EmitirBoletoRequest request, CancellationToken ct)
    {
        return await cobrancaApi.EmitirBoletoAsync(request, ct);
    }
}
```

```csharp
// Registrar um webhook
public class WebhookService(ISicoobCobrancaBancariaApi cobrancaApi)
{
    public async Task RegistrarAsync(WebhookRequest request, CancellationToken ct)
    {
        await cobrancaApi.RegistrarWebhookAsync(request, ct);
    }
}
```

```csharp
// Consultar um pagamento
public class PagamentoService(ISicoobCobrancaBancariaPagamentoApi pagamentoApi)
{
    public async Task<PagamentoDto> ConsultarAsync(string nossoNumero, CancellationToken ct)
    {
        return await pagamentoApi.ConsultarAsync(nossoNumero, ct);
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
