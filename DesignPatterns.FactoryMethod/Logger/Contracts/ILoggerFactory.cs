namespace DesignPatterns.FactoryMethod.Logger.Contracts
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
