namespace MVFC.Connectors.Commons.Settings;

public sealed record HttpSettings(
    int MaximoDeTentativas = 3,
    int TimeoutRetrySegundos = 10,
    int DelayRetrySegundos = 2)
{
    public double CalcularTimeoutTotal()
    {
        var totalMaximoPorTentativas = MaximoDeTentativas * TimeoutRetrySegundos;
        var totalMaximoDelay = 0.0;

        for (int i = 0; i < MaximoDeTentativas - 1; i++)
        {
            totalMaximoDelay += DelayRetrySegundos * Math.Pow(2, i);
        }

        return (totalMaximoPorTentativas + totalMaximoDelay) * 1.2;
    }
}