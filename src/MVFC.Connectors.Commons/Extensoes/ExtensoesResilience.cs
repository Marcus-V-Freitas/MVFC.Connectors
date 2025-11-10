namespace MVFC.Connectors.Commons.Extensoes;

internal static class ExtensoesResilience
{
    public static IHttpClientBuilder AdicionarResiliencia(this IHttpClientBuilder builder, Action<HttpSettings>? httpSettings = null)
    {
        var settings = new HttpSettings();
        httpSettings?.Invoke(settings);

        builder.AddStandardResilienceHandler(options =>
        {
            options.Retry.MaxRetryAttempts = settings.MaximoDeTentativas;
            options.Retry.Delay = TimeSpan.FromSeconds(settings.DelayRetrySegundos);
            options.Retry.BackoffType = DelayBackoffType.Exponential;
            options.Retry.UseJitter = true;
            options.AttemptTimeout.Timeout = TimeSpan.FromSeconds(settings.TimeoutRetrySegundos);
            options.TotalRequestTimeout.Timeout = TimeSpan.FromSeconds(settings.CalcularTimeoutTotal());
            options.CircuitBreaker.SamplingDuration = TimeSpan.FromHours(1);
        });

        return builder;
    }

    public static ResilienceHandler CriarStandardResilienceHandler(HttpSettings settings)
    {
        var pipeline = new ResiliencePipelineBuilder<HttpResponseMessage>()
            .AddConcurrencyLimiter(new ConcurrencyLimiterOptions
            {
                PermitLimit = 1000,
                QueueLimit = 0
            })
            .AddTimeout(TimeSpan.FromSeconds(settings.CalcularTimeoutTotal()))
            .AddRetry(new RetryStrategyOptions<HttpResponseMessage>
            {
                MaxRetryAttempts = settings.MaximoDeTentativas,
                Delay = TimeSpan.FromSeconds(settings.DelayRetrySegundos),
                BackoffType = DelayBackoffType.Exponential,
                UseJitter = true,
                ShouldHandle = new PredicateBuilder<HttpResponseMessage>()
                    .Handle<HttpRequestException>()
                    .Handle<TimeoutRejectedException>()
                    .HandleResult(r => (int)r.StatusCode >= 500 ||
                                      r.StatusCode == HttpStatusCode.RequestTimeout)
            })
            .AddCircuitBreaker(new CircuitBreakerStrategyOptions<HttpResponseMessage>
            {
                FailureRatio = 0.5,
                MinimumThroughput = 5,
                SamplingDuration = TimeSpan.FromHours(1),
                BreakDuration = TimeSpan.FromSeconds(5),
                ShouldHandle = new PredicateBuilder<HttpResponseMessage>()
                    .Handle<HttpRequestException>()
                    .HandleResult(r => (int)r.StatusCode >= 500)
            })
            .AddTimeout(TimeSpan.FromSeconds(settings.TimeoutRetrySegundos))
            .Build();

        return new ResilienceHandler(pipeline);
    }
}