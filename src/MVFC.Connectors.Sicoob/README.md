# MVFC.Connectors.Sicoob

Connector for Sicoob banking APIs, covering bank billing, boleto management, payments, negativation, protests, and webhooks.

[![NuGet](https://img.shields.io/nuget/v/MVFC.Connectors.Sicoob.svg)](https://www.nuget.org/packages/MVFC.Connectors.Sicoob)
[![Downloads](https://img.shields.io/nuget/dt/MVFC.Connectors.Sicoob.svg)](https://www.nuget.org/packages/MVFC.Connectors.Sicoob)
[![License](https://img.shields.io/github/license/Marcus-V-Freitas/MVFC.Connectors.svg)](../../LICENSE)
[![CI](https://img.shields.io/github/actions/workflow/status/Marcus-V-Freitas/MVFC.Connectors/ci.yml?branch=main)](../../actions)
![Platform](https://img.shields.io/badge/.NET-9%20%7C%2010-blue)

English | [Português](README.pt-BR.md)

---

## Features

- Boleto issuance, query, and cancellation
- Billing movements and payer management
- Negativation and protest operations
- Webhook registration and management
- Payment queries and settlement
- OAuth2 authentication via `SicoobAuthProvider`

---

## Installation

```bash
dotnet add package MVFC.Connectors.Sicoob
```

---

## Supported APIs

| Interface | Description |
|---|---|
| `ISicoobCobrancaBancariaApi.Boleto` | Issue, query, and cancel boletos |
| `ISicoobCobrancaBancariaApi.Health` | API health check |
| `ISicoobCobrancaBancariaApi.Movimentacao` | Billing movement queries |
| `ISicoobCobrancaBancariaApi.Negativacao` | Negativation operations |
| `ISicoobCobrancaBancariaApi.Pagador` | Payer registration and management |
| `ISicoobCobrancaBancariaApi.Protesto` | Protest operations |
| `ISicoobCobrancaBancariaApi.Webhook` | Webhook registration and management |
| `ISicoobCobrancaBancariaPagamentoApi.Boleto` | Boleto payment queries |
| `ISicoobCobrancaBancariaPagamentoApi.Pagamento` | Payment confirmation and settlement |

---

## Quick Start

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSicoob(options =>
{
    options.ClientId = "your-client-id";
    options.ClientSecret = "your-client-secret";
});

var app = builder.Build();
```

---

## Examples

```csharp
// Issue a boleto
public class BoletoService(ISicoobCobrancaBancariaApi cobrancaApi)
{
    public async Task<BoletoDto> EmitirAsync(EmitirBoletoRequest request, CancellationToken ct)
    {
        return await cobrancaApi.EmitirBoletoAsync(request, ct);
    }
}
```

```csharp
// Register a webhook
public class WebhookService(ISicoobCobrancaBancariaApi cobrancaApi)
{
    public async Task RegistrarAsync(WebhookRequest request, CancellationToken ct)
    {
        await cobrancaApi.RegistrarWebhookAsync(request, ct);
    }
}
```

```csharp
// Query a payment
public class PagamentoService(ISicoobCobrancaBancariaPagamentoApi pagamentoApi)
{
    public async Task<PagamentoDto> ConsultarAsync(string nossoNumero, CancellationToken ct)
    {
        return await pagamentoApi.ConsultarAsync(nossoNumero, ct);
    }
}
```

---

## Related Packages

| Package | Description |
|---|---|
| [MVFC.Connectors.Commons](../MVFC.Connectors.Commons/README.md) | Shared HTTP infrastructure and authentication |
| [MVFC.Connectors](../../README.md) | Repository overview |

---

## Contributing

Read [CONTRIBUTING.md](../../CONTRIBUTING.md) before opening issues or pull requests.

---

## Security

If you discover a vulnerability, please refer to [SECURITY.md](../../SECURITY.md).

---

## License

Distributed under the license available in [LICENSE](../../LICENSE).
